using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Data.Entities
{
    [Table("tb_product")]
    public class Product
    {
        [Key]
        [Column("PK_PRO")]
        public uint Id { get; set; }

        [Required]
        [Column("ST_PRO_NAME", TypeName = "VARCHAR(30)")]
        public string Name { get; set; }

        [Required]
        [Column("DB_PRO_SALE_PRICE")]
        public double SalePrice { get; set; }

        [Required]
        [Column("DB_PRO_PURCHASE_PRICE")]
        public double PurchasePrice { get; set; }
        
        [Column("IN_PRO_STORAGE")]
        public int Storage { get; set; }
        
        [Column("ST_PRO_CATEGORY", TypeName = "VARCHAR(30)")]
        public string Category { get; set; }

        [Required]
        [Column("DT_PRO_CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        
        [Column("DT_PRO_UPDATED_AT")]
        public DateTime UpdatedAt { get; set; }
    }
}
