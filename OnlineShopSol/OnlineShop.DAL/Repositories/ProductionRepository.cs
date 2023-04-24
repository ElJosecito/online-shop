using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Exceptions;
using OnlineShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnlineShop.DAL.Repositories
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly ShopContext context;
        private readonly ILogger<ProductionRepository> logger;
        public ProductionRepository(ShopContext context, ILogger<ProductionRepository> Logger)
        {
            this.context = context;
            this.logger = Logger;
        }

        public object Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Production production)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        void IProductionRepository.Add(Production production)
        {
            try
            {
                if (this.context.Production.Any(cd => cd.ProductionID == production.ProductionID))
                {
                    throw new IProductionException("El Producto Ya existe");
                }

                this.context.Production.Add(production);
                this.context.SaveChanges();
            }
            catch (IProductionException ex)
            {
                this.logger.LogError($"ocurrio un error {ex.Message}", ex.ToString());
            }
        }

        void IProductionRepository.Delete(Production production)
        {
            throw new NotImplementedException();
        }

        List<Production> IProductionRepository.GetEntities()
        {
            throw new NotImplementedException();
        }

        Suppliers IProductionRepository.GetEntity(int ID)
        {
            throw new NotImplementedException();
        }

        void IProductionRepository.Update(Production production)
        {
            throw new NotImplementedException();
        }
    }
        
   
}
