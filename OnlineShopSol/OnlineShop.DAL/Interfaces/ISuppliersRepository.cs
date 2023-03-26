using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Interfaces
{
    public interface ISuppliersRepository
    {
        void Save(Suppliers suppliers);
        void Update(Suppliers suppliers);
        List<SuppliersModel> GetAll();
        Suppliers Get(int SuppliersId);
        void Delete(Suppliers suppliers);
        bool Exists(string CompanyName);

    }
}
