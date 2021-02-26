using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atm_api_net_core.Tarjeta.Entities
{
    [Table("Tarjeta")]
    public class TarjetaEntity
    {

        [Key]
        [Column("IdTarjeta")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarjeta { get; set; } 

        [Required]
        [Column("Numero")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]{16,16}$")]
        [MaxLength(16)]
        public string Numero { get; set; }

        [Required]
        [Column("Pin")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9]{4,4}$")]
        [MaxLength(4)]

        public string Pin { get; set; }

        [Required]
        [Column("Bloqueado")]
        public bool Bloqueado { get; set; }

        [Required]
        [Column("Intentos")]
        public int Intentos { get; set; }

        [Column("Fecha_Creacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("Fecha_Actualizacion")]
        public DateTime FechaActualizacion { get; set; }


    }
}
