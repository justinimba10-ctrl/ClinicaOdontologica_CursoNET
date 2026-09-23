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
        [Column("id_cita", TypeName = "Serial")]
        public int idCita { get; set; }

        [Column("fecha_cita", TypeName = "timestamp whithout time zone")]
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
        [Column("id_paciente", TypeName = "Integer")]
        public Paciente? paciente { get; set; }

        [ForeignKey("odontologo")]
        [Column("id_odontologo", TypeName = "Integer")]
        public Odontologo? odontologo { get; set; }

        [ForeignKey("consultorio")]
        [Column("id_consultorio", TypeName = "Integer")]
        public Consultorio? consultorio { get; set; }

       
    }
}
