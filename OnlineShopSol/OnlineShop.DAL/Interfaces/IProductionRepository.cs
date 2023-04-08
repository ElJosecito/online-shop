using OnlineShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Interfaces
{
    public interface IProductionRepository
    {
        void Add(Production production);
        void Update(Production production);
        List<Production> GetEntities();
        Suppliers GetEntity(int ID);
        void Delete(Production production);
        object Get(int id);
    }
}