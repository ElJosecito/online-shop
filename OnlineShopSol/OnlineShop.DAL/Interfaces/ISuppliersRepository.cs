using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Interfaces
{
    public interface ISuppliersRepository
    {
        void Add(Suppliers suppliers);
        void Update(Suppliers suppliers);
        List<SuppliersModel> GetAll();
        Suppliers Get(int idSuppliers);
        void Delete(Suppliers suppliers);

    }
}
