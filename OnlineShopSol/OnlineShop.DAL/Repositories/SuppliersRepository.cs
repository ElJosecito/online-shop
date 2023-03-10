

using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Exceptions;
using OnlineShop.DAL.Interfaces;
using OnlineShop.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.DAL.Repositories
{
    public class SuppliersRepository : ISuppliersRepository
    {
        public void Add(Suppliers suppliers)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Suppliers suppliers)
        {
            throw new System.NotImplementedException();
        }

        public Suppliers Get(int idSuppliers)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Suppliers suppliers)
        {
            throw new System.NotImplementedException();
        }

        List<SuppliersModel> ISuppliersRepository.GetAll()
        {
            return new List<SuppliersModel>
            {
                new SuppliersModel()
                {

                    SupplierId = 1,
                    CompanyName = "Uncanny",
                    ContactName = "Jose",
                    ContactTitle = "Lider",
                    Address = "SomePlace In Neverland",
                    City = "Neverland",
                    Region = "Este",
                    PostalCode = "22000",
                    Country = "EveryWhere",
                    Phone = "809-123-1234",
                    Fax = "Uncanny@gmail.com"
                }
            };
        }
    }
}
