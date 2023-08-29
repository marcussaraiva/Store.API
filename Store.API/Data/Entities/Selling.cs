using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Data.Entities
{
    [Table("tb_selling")]
    public class Selling
    {
        [Key]
        [Column("PK_SEL")]
        public uint Id { get; set; }

        [Required]
        [Column("DB_SEL_PRICE")]
        public double Price { get; set; }
        
        [Required]
        [Column("DT_SEL_START_AT")]
        public DateTime StartAt { get; set; }
        
        [Required]
        [Column("DT_SEL_END_AT")]
        public DateTime EndAt { get; set; }

        public virtual ICollection<SellItem> Items { get; set; }
    }
}
