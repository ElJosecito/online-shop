using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Entities;

namespace OnlineShop.DAL.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {

        }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }


        #region "Registros"
        public DbSet<Suppliers> Suppliers { get; set; }
        #endregion

        #region "Registros"
        public DbSet<Categories> Categories{ get; set; }
        #endregion

        public DbSet<Production> Production { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suppliers>()
                .HasKey(c => c.SupplierId); // Agregar esta línea para definir la clave primaria

            modelBuilder.Entity<Categories>()
                .HasKey(c => c.categoryid); // Agregar esta línea para definir la clave primaria

            base.OnModelCreating(modelBuilder);
        }
        //


    }
}