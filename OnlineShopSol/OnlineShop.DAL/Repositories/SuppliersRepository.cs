

using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Exceptions;
using OnlineShop.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.DAL.Repositories
{
    public class SuppliersRepositories : ISuppliersRepository
    {
        private readonly  ShopContext context;
        private readonly ILogger<SuppliersRepositories> logger;
        public SuppliersRepositories(ShopContext context, ILogger<SuppliersRepositories> Logger) 
        {
            this.context = context;
            this.logger = Logger;
        }
        public void Add(Suppliers suppliers)
        {
            try 
            {
                if(this.context.Suppliers.Any(cd => cd.SupplierId == suppliers.SupplierId))
                {
                    throw new ISuppliersException("El Supplier Ya existe");
                }

                this.context.Suppliers.Add(suppliers);
                this.context.SaveChanges();
            }
            catch (ISuppliersException ex)
            {
                this.logger.LogError($"ocurrio un error {ex.Message}", ex.ToString());
            }
        }

        public void Delete(Suppliers suppliers)
        {
            throw new System.NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Suppliers GetById(int idSuppliers)
        {
            throw new System.NotImplementedException();
        }

        public List<Suppliers> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public Suppliers GetEntity(int idSuppliers)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Suppliers suppliers)
        {
            throw new System.NotImplementedException();
        }
    }
}
