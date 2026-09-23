using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo", TypeName = "Serial")]
        public int idOdontologo { get; set; }

        [Column("nombres", TypeName = "character varying")]
        [MaxLength(50)]
        [Required]
        public string nombre { get; set; }

        [Column("apellidos", TypeName = "character varying")]
        [MaxLength(50)]
        [Required]
        public string apellido { get; set; }

        [Column("registro_medico", TypeName = "character varying")]
        [MaxLength(20)]
        [Required]
        public string registroMedico { get; set; }

        [ForeignKey("especialidad")]
        [Column("id_especialidad", TypeName = "Integer")]

        public Especialidad? especialidad {get;set;}

    }
}
