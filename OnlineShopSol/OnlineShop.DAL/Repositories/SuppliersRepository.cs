

using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;



namespace OnlineShop.DAL.Repositories
{
    public class SuppliersRepository : Core.RepositoryBase<Suppliers>, ISuppliersRepository 
    { 

        private readonly ShopContext _shopContext;
        private readonly ILogger<SuppliersRepository> _logger;

    public SuppliersRepository(ShopContext shopContext, ILogger<SuppliersRepository> logger): base(shopContext)
        {
            _shopContext = shopContext;
            _logger = logger;
        }

       /* public void Save(Suppliers suppliers)
        {
            try
            {
                Suppliers suppliersToAdd = new Suppliers()
                {
                    SupplierId = suppliers.SupplierId,
                    CompanyName = suppliers.CompanyName,
                    ContactName = suppliers.ContactName,
                    ContactTitle = suppliers.ContactTitle,
                    Address = suppliers.Address,
                    City = suppliers.City,
                    Region = suppliers.City,
                    PostalCode = suppliers.PostalCode,
                    Country = suppliers.Country,
                    Phone = suppliers.Phone,
                    Fax = suppliers.Fax,
                    Creation_User = suppliers.Creation_User,
                    Creation_Date = DateTime.Now,

                };

                _shopContext.Suppliers.Add(suppliersToAdd);
                _shopContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al agregar el Supplier {ex.Message}", ex.ToString());
            }

        }

        public void Delete(Suppliers suppliers)
        {
            try
            {
                Suppliers suppliersToRemove = Get(suppliers.SupplierId);

                suppliersToRemove.Delete_Date = DateTime.Now;
                suppliersToRemove.Deleted = true;
                suppliersToRemove.Delete_User = suppliers.Delete_User;

                _shopContext.Suppliers.Remove(suppliersToRemove);
                _shopContext.SaveChanges();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al remover el Supplier {ex.Message}", ex.ToString());
            }
        }

        public Suppliers Get(int SuppliersId)
        {
            return _shopContext.Suppliers.Find(SuppliersId);
        }

        public void Update(Suppliers suppliers)
        {

            try
            {
                Suppliers suppliersToUpdate = Get(suppliers.SupplierId);

                suppliersToUpdate.SupplierId = suppliers.SupplierId;
                suppliersToUpdate.CompanyName = suppliers.CompanyName;
                suppliersToUpdate.ContactName = suppliers.ContactName;
                suppliersToUpdate.ContactTitle = suppliers.ContactTitle;
                suppliersToUpdate.Address = suppliers.Address;
                suppliersToUpdate.City = suppliers.City;
                suppliersToUpdate.Region = suppliers.City;
                suppliersToUpdate.PostalCode = suppliers.PostalCode;
                suppliersToUpdate.Country = suppliers.Country;
                suppliersToUpdate.Phone = suppliers.Phone;
                suppliersToUpdate.Fax = suppliers.Fax;

                suppliersToUpdate.Modify_Date = DateTime.Now;
                suppliersToUpdate.Delete_User = suppliers.Delete_User;

                _shopContext.Suppliers.Update(suppliersToUpdate);
                _shopContext.SaveChanges();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizando el Supplier {ex.Message}", ex.ToString());
            }
        }

        List<SuppliersModel> ISuppliersRepository.GetAll()
        {

                var suppliers = _shopContext.Suppliers.Select(cd => new SuppliersModel()
                {
                    SupplierId = cd.SupplierId,
                    CompanyName = cd.CompanyName,
                    ContactName = cd.ContactName,
                    ContactTitle = cd.ContactTitle,
                    Address = cd.Address,
                    City = cd.City,
                    Region = cd.Region,
                    PostalCode = cd.PostalCode,
                    Country = cd.Country,
                    Phone = cd.Phone,
                    Fax = cd.Fax
                }).ToList();

                return suppliers;

        }
        bool ISuppliersRepository.Exists(string CompanyName)
        {
            return this._shopContext.Suppliers.Any(cd => cd.CompanyName == CompanyName);
        }*/
    }
}
