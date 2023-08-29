using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Data.Entities
{
    [Table("tb_sell_item")]
    public class SellItem
    {
        [Key]
        [Column("PK_SELI")]
        public uint Id { get; set; }

        [ForeignKey("Selling")]
        [Column("FK_SEL_SELI")]
        public uint SellingId { get; set; }

        [Required]
        [ForeignKey("Product")]
        [Column("FK_PRO_SELI")]
        public uint ProductId { get; set; }
        
        [Required]
        [Column("IN_SELI_QUANTITY")]
        public int Quantity { get; set; }

        [Required]
        [Column("DB_SELI_PRICE")]
        public double Price { get; set; }

        public Selling Selling { get; set; }
    }
}
