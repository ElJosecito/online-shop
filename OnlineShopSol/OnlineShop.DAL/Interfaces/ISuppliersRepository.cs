using OnlineShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Interfaces
{
    public interface ISuppliersRepository
    {
        void Add(Suppliers suppliers);
        void Update(Suppliers suppliers);
        List<Suppliers> GetAll();
        Suppliers GetEntity(int idSuppliers);
        void Delete(Suppliers suppliers);

    }
}
