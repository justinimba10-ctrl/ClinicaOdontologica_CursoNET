using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita")]
        public int idCita { get; set; }

        [Column("fecha_cita", TypeName = "timestamp")]
        [Required]
        public DateTime fechaCita { get; set; }

        [Column("motivo", TypeName = "character varying")]
        [MaxLength(200)]
        [Required]
        public string motivo { get; set; }

        [Column("estado_cita", TypeName = "character varying")]
        [MaxLength(20)]
        [Required]
        public string estadoCita { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }
        

        [ForeignKey("odontologo")]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }
        

        [ForeignKey("consultorio")]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }
        

        //OBEJTOS DE NAVEGACION
        public Paciente? paciente { get; set; }
        public Odontologo? odontologo { get; set; }
        public Consultorio? consultorio { get; set; }

        //RELACIONES
        List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();
        List<Recetas>? Recetas { get; set; } = new List<Recetas>();

    }
}
