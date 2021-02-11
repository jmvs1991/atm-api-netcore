using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atm_api_net_core.Tarjeta.Entities
{
    [Table("TARJETA")]
    public class TarjetaEntity
    {

        [Key]
        [Column("ID_TARJETA")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarjeta { get; set; } 

        [Column("NUMERO")]
        public string Numero { get; set; }

        [Column("PIN")]
        public string Pin { get; set; }

    }
}
