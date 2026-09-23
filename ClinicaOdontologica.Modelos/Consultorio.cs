using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Consultorios")]
    public class Consultorio
    {
        [Key]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }

        [Column("numero_sala")]
        [MaxLength(10)]
        [Required]
        public string numeroSala { get; set; }

        [Column("piso")]
        public int piso { get; set; }

        [Column("equipamiento_principal")]
        [MaxLength(100)]
        [Required]
        public string equipamientoPrincipal { get; set; }
    }
}
