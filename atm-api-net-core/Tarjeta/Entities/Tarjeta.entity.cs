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

        [Column("Numero")]
        public string Numero { get; set; }

        [Column("Pin")]
        public string Pin { get; set; }

    }
}
