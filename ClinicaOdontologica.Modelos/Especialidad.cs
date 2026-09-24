using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Especialidades")]

    public class Especialidad
    {
        [Key]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }

        [Column("nombre_especialidad")]
        [MaxLength(50)]
        [Required]
        public string nombreEspecialidad { get; set; }

        [Column("descripcion")]
        [MaxLength(200)]
        [Required]
        public string descripcion { get; set; }

        //realciones
        List<Odontologo>? Odontologo { get; set; } = new List<Odontologo>();

    }
}
