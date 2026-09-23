using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Historiales Medicos")]
    public class HistorialMedico
    {
        [Key]
        [Column("id_historial", TypeName = "Serial")]
        public int IdHistorialMedico { get; set; }
        [Column("Alergias")]
        [MaxLength(200)]
        [Required]
        public string alergias { get; set; }

        [Column("enfermedades_previas")]
        [MaxLength(200)]
        [Required]
        public string enfermedadesPrevias { get; set; }

        [Column("tipo_sangre")]
        [MaxLength(4)]
        [Required]
        public string tipoSangre { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        public Paciente? paciente { get; set; }
    }
}
