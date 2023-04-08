
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OnlineShop.DAL.Exceptions;

namespace OnlineShop.DAL.Repositories
{
    public class SuppliersRepository : Core.RepositoryBase<Suppliers>, ISuppliersRepository
    {

        private readonly ShopContext shopContext;
        private readonly ILogger<SuppliersRepository> _logger;

        public SuppliersRepository(ShopContext shopContext, ILogger<SuppliersRepository> logger) : base(shopContext)
        {
            this.shopContext = shopContext;
            _logger = logger;
        }

        public override void Save(Suppliers entity)
        {
            if (string.IsNullOrEmpty(entity.CompanyName))
            {
                throw new ISuppliersException("El nombre de la compañia es requerido");
            }

            base.Save(entity);
            base.SaveChange();
        }

        public override void Delete(Suppliers entity)
        {
            base.Delete(entity);
            base.SaveChange();

        }

        public override void Update(Suppliers entity)
        {
            base.Update(entity);
            base.SaveChange();

        }

        public override List<Suppliers> GetEntities()
        {
            return this.shopContext.Suppliers.Where(cd => !cd.Deleted).ToList();
        }

        public override Suppliers Get(int id)
        {
            return this.shopContext.Suppliers.FirstOrDefault(cd => cd.SupplierId == id && !cd.Deleted);
        }

        public object GetEntity(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}