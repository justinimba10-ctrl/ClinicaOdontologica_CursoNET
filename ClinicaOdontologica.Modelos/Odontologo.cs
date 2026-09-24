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

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombre { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellido { get; set; }

        [Column("registro_medico")]
        [MaxLength(20)]
        [Required]
        public string registroMedico { get; set; }

        [ForeignKey("especialidad")]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }


        //OBJETOS DE NAVEGACION
        public Especialidad? especialidad { get; set; }

        //Relaciones

        List<Cita>? citas { get; set; } = new List<Cita>();
    }
}
