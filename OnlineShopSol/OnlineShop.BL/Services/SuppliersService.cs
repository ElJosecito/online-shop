using Microsoft.Extensions.Logging;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Core;
using OnlineShop.BL.Dtos.Suppliers;
using OnlineShop.BL.Models;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BL.Services
{
    public class SuppliersService : ISupplierService
    {
        private readonly ISuppliersRepository suppliersRepository;
        private readonly ILogger<SuppliersService> logger;

        public SuppliersService(ISuppliersRepository suppliersRepository, ILogger<SuppliersService> logger)
        {
            this.suppliersRepository = suppliersRepository;
            this.logger = logger;
        }

        public ServiceResult DeleteSuppliers(SuppliersRemoveDto removeDto)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var supplier = this.suppliersRepository.GetEntities().Select(cd => new SuppliersResultModel()
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
                    Fax = cd.Fax,
                    Creation_Date = cd.Creation_Date
                }).ToList();

                result.Data = supplier;
                result.Success = true;
            }   
            catch(Exception ex) 
            {
                result.Message = "Ha ocurrido un error al obtener los suplidores";
                result.Success= false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }

            return result;
        }

        public ServiceResult GetById(int Id)
        {
            ServiceResult result = new ServiceResult();
            try
            {

                var supplier = this.suppliersRepository.Get(Id);

                SuppliersResultModel supplierResultModel = new SuppliersResultModel()
                {
                    SupplierId = supplier.SupplierId,
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    ContactTitle = supplier.ContactTitle,
                    Address = supplier.Address,
                    City = supplier.City,
                    Region = supplier.Region,
                    PostalCode = supplier.PostalCode,
                    Country = supplier.Country,
                    Phone = supplier.Phone,
                    Fax = supplier.Fax,
                    Creation_Date = supplier.Creation_Date
                };

                result.Data = supplier;
                result.Success = true;
            }
            catch(Exception ex ) 
            {
                result.Message = "Ha ocurrido un error al obtener el suplidor";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveSupplier(SuppliersSaveDto saveDto)
        {
            throw new NotImplementedException();
        }

        public ServiceResult UpdateSupplier(SuppliersUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
