using Microsoft.EntityFrameworkCore;
using Store.API.Data.Entities;

namespace Store.API.Context
{
    /// <summary>
    /// EF Configure for acess Store database
    /// </summary>
    public class StoreDbContext : DbContext
    {

        #region Entities Collections
        /// <summary>
        /// Acess to Product Collection
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Acess to Category Collection
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Acess to Selling Collection
        /// </summary>
        public DbSet<Selling> Sellings { get; set; }

        /// <summary>
        /// Acess to SellItem Collection
        /// </summary>
        public DbSet<SellItem> SellItems { get; set; }
        #endregion

        #region Contructor Method
        /// <summary>
        /// Constructor method to StoreDbContext class
        /// </summary>
        /// <param name="options"></param>
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        #endregion
    }
}
