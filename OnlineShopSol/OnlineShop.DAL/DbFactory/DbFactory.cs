using OnlineShop.DAL.Core;
using OnlineShop.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace OnlineShop.DAL.DbFactory
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly ShopContext shopContext;
        public DbFactory(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        private bool isDisposed;
        public DbContext GetDbContext => this.shopContext;
        public void Dispose()
        {
            this.Dispose(true); 
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing) 
        {
            if (!this.isDisposed) 
            {
                if(this.shopContext != null) 
                {
                    this.shopContext.Dispose();
                }
            }
        }
    }
}
