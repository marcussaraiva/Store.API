using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Data.Entities
{
    [Table("tb_category")]
    public class Category
    {
        [Key]
        [Column("PK_CAT")]
        public uint Id { get; set; }

        [Required]
        [Column("ST_CAT_NAME")]
        public string Name { get; set; }
    }
}
