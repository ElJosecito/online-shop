
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OnlineShop.DAL.Core
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Save(TEntity[] entities);
        void Update(TEntity entity);
        void Update(TEntity[] entities);
        void Delete(TEntity entity);
        void Delete(TEntity[] entities);
        TEntity Get(int id);
        List<TEntity> GetEntities();
        bool Exists(Expression<Func<TEntity, bool>> filter);
        void SaveChange();
    }
}
