using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologica.Modelos
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura")]
        public int idFactura { get; set; } 

        [Column("fecha_emision", TypeName = "date")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("subtotal", TypeName = "numeric(10,2)")]
        [Required]
        public decimal subtotal { get; set; }

        [Column("impuestos", TypeName = "numeric(10,2)")]
        [Required]
        public decimal impuestos { get; set; }

        [Column("total", TypeName = "numeric(10,2)")]
        [Required]
        public decimal total { get; set; }

        [Column("estado_pago")]
        [Required]
        [MaxLength(20)]
        public string estadoPago { get; set; } = "Pendiente";

        [Column("id_cita")]
        public int idCita { get; set; }

        [ForeignKey(nameof(idCita))]
        public Cita? cita { get; set; }
    }
}