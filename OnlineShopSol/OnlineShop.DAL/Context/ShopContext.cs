
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Entities;

namespace OnlineShop.DAL.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext() 
        {
            
        }

        public DbSet<Suppliers> Suppliers { get; set; }
    }
}
