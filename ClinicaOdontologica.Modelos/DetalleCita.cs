using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table ("DetallesCita")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalles_cita", TypeName = "Serial")]
        public int detalleCita { get; set; }

        [Column("costo_aplicado", TypeName = "numeric(10,2)")]
        [Required]
        public int costoAplicado { get; set; }

        [Column("observaciones")]
        [Required]
        [MaxLength(200)]
        public string observacion { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita")]
        public int idCita { get; set; }
        public Cita? cita { get; set; }

        [ForeignKey("tratamiento")]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }

        //OBEJTOS DE NAVEGACION
        public Tratamiento? tratamiento { get; set; }

        
    }
}
