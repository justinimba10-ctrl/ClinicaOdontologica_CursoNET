using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura", TypeName = "Serial")]
        public int factura { get; set; }

        [Column("fecha_emision", TypeName = "timestamp whithout time zone")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("subtotal", TypeName = "numeric(10,2)")]
        [Required]
        public int subtotal { get; set; }

        [Column("impuestos", TypeName = "numeric(10,2)")]
        [Required]
        public int impueesto { get; set; }

        [Column("total", TypeName = "numeric(10,2)")]
        [Required]
        public int total { get; set; }

        [Column("estado_pago", TypeName = "character varying")]
        [Required]
        [MaxLength (20)]
        public int estadoPago { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita", TypeName = "integer")]
        public Cita? cita { get; set; }
    }
}
