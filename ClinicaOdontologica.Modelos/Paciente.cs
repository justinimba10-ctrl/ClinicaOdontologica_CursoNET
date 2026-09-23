using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{

    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [Column("dni")]
        [MaxLength(10)]
        [Required]
        public string dni { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombre { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellido { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime fechaNacimiento { get; set; }

        [Column("email")]
        [MaxLength(100)]
        [Required]
        public string email { get; set; }

        [Column("telefono")]
        [MaxLength(15)]
        [Required]
        public string telefono { get; set; }
    }
}
