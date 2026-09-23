using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("recetas")]
    public class Recetas
    {
        [Key]
        [Column("id_receta", TypeName = "Serial")]
        public int idReceta { get; set; }

        [Column("fecha_emision", TypeName = "timestamp whitout time zone")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("indicaciones", TypeName = "text")]
        [Required]
        public string indicacion { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita", TypeName = "integer")]
        public Cita? cita { get; set; }


    }
}
