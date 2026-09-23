using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologica.Modelos
{
    [Table("Tratamientos")]
    public class Tratamiento
    {
        [Key]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }

        [Column("nombre_tratamiento")]
        [MaxLength(50)]
        [Required]
        public string nombreTratamiento { get; set; }

        [Column(TypeName = "numeric(10,2)")]        
        [Required]
        public decimal costoBase { get; set; }

        [Column("duracion_Estimada_minutos")]
        [Required]
        public TimeOnly duracionEstimadaMinutos { get; set; }

        

        

    }

}
