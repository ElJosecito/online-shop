
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Core
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ShopContext context;
        private readonly DbSet<TEntity> myDbSet;

        public RepositoryBase(ShopContext context) 
        {
            this.context = context;
            this.myDbSet = this.context.Set<TEntity>();
        }

        public virtual void Delete(TEntity entity)
        {
            this.myDbSet.Remove(entity);
        }

        public void Delete(TEntity[] entities)
        {
            this.myDbSet.RemoveRange(entities);
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.myDbSet.Any(filter);
        }

        public virtual TEntity Get(int id)
        {
            return this.myDbSet.Find(id);
        }

        public virtual List<TEntity> GetEntities()
        {
            return this.myDbSet.ToList();
        }

        public virtual void Save(TEntity entity)
        {
            this.myDbSet.Add(entity);
        }

        public virtual void Save(TEntity[] entities)
        {
            this.myDbSet.AddRange(entities);
        }

        public virtual void SaveChange() 
        {
            this.context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            this.myDbSet.Update(entity);
        }

        public virtual void Update(TEntity[] entities)
        {
            this.myDbSet.AddRange(entities);
        }
    }
}
