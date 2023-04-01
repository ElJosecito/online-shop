using Microsoft.Extensions.Logging;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Core;
using OnlineShop.BL.Dtos.Suppliers;
using OnlineShop.BL.Models;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using OnlineShop.DAL.Exceptions;
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
            ServiceResult result = new ServiceResult();
            try 
            {
                Suppliers suppliersToRemove = this.suppliersRepository.Get(removeDto.SupplierId);
                suppliersToRemove.Deleted = removeDto.Deleted;
                suppliersToRemove.Delete_Date = removeDto.Delete_Date;
                suppliersToRemove.Delete_User = removeDto.Delete_User;

                this.suppliersRepository.Delete(suppliersToRemove);
                result.Message = "El suplidor ha sido borrado";
                result.Success = true;
                this.suppliersRepository.SaveChange();
            }
            catch (ISuppliersException sdex) 
            {
                result.Message = sdex.Message;
                result.Success = false;
                this.logger.LogError(sdex.Message, sdex.ToString());
            }
            catch (Exception ex)
            {
                result.Message = "Ha ocurrido un error al remover el suplidor";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
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
            catch (ISuppliersException sdex)
            {
                result.Message = sdex.Message;
                result.Success = false;
                this.logger.LogError(sdex.Message, sdex.ToString());
            }
            catch (Exception ex ) 
            {
                result.Message = "Ha ocurrido un error al obtener el suplidor";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveSupplier(SuppliersSaveDto saveDto)
        {
           ServiceResult result = new ServiceResult();
            try
            {
                Suppliers supplier = new Suppliers()
                {
                    Creation_Date = saveDto.Creation_Date,
                    Creation_User = saveDto.Creation_User,
                    CompanyName = saveDto.CompanyName,
                    ContactName = saveDto.ContactName,
                    ContactTitle = saveDto.ContactTitle,
                    Address = saveDto.Address,
                    City = saveDto.City,
                    Region = saveDto.Region,
                    PostalCode = saveDto.PostalCode,
                    Country = saveDto.Country,
                    Phone = saveDto.Phone,
                    Fax = saveDto.Fax
                };

                this.suppliersRepository.Save(supplier);
                result.Message = "El suplidor ha sido Agregado";
                result.Success = true;
                this.suppliersRepository.SaveChange();
            }
            catch (ISuppliersException sdex)
            {
                result.Message = sdex.Message;
                result.Success = false;
                this.logger.LogError(sdex.Message, sdex.ToString());
            }
            catch (Exception ex)
            {
                result.Message = "Ha ocurrido un error al guardar el suplidor";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }

            return result;
        }

        public ServiceResult UpdateSupplier(SuppliersUpdateDto updateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Suppliers suppliersToUpdate = this.suppliersRepository.Get(updateDto.SupplierId);
                suppliersToUpdate.Modify_Date = updateDto.Modify_Date;
                suppliersToUpdate.Modify_User = updateDto.Modify_User;

                this.suppliersRepository.Update(suppliersToUpdate);
                result.Message = "El suplidor ha sido actualizado";
                result.Success = true;
                this.suppliersRepository.SaveChange();   
            }
            catch (ISuppliersException sdex)
            {
                result.Message = sdex.Message;
                result.Success = false;
                this.logger.LogError(sdex.Message, sdex.ToString());
            }
            catch (Exception ex)
            {
                result.Message = "Ha ocurrido un error al actualizar el suplidor";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }
    }
}
