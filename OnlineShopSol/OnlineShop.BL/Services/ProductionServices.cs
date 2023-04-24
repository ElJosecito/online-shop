using Microsoft.Extensions.Logging;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Core;
using OnlineShop.BL.Datos.Production;
using OnlineShop.BL.Exceptions;
using OnlineShop.BL.Model;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BL.Services
{
    public class ProductionServices : IProductionService
    {

#pragma warning disable CS0169 // El campo 'ProductionServices._logger' nunca se usa
        private readonly ILogger _logger;
#pragma warning restore CS0169 // El campo 'ProductionServices._logger' nunca se usa
        private readonly IProductionRepository productionRepository;
        private ILogger<ProductionServices> logger;

        public ProductionServices(IProductionRepository productionRepository, ILogger<ProductionServices> logger)
    {
        this.productionRepository = productionRepository;
        this.logger = logger;
    }

        public object ProductionRepository { get; private set; }

        public ServiceResult DeleteProduction(ProductionRemoveDto removeDto)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            
            try
            {
                var production = this.productionRepository.GetEntities().Select(cd => new ProductionResultModel()
                {
                    ProductionId = cd.ProductionId,
                    Name  = cd.Name,
                    supplierId = cd.supplierid,
                    categoryId = cd.categoryid,
                    unitprice = cd.unitprice,
                    discontinued = cd.discontinued,
                    Creation_Date = cd.Creation_Date

                }).ToList();
                result.Data = production;
                result.Success = true;
            }
            catch (Exception ex) {

                result.Message = "Ha ocurrido un error al obtener los production";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
                   
            return result;
        }

        public ServiceResult GetById(int Id) 
        {
            ServiceResult result = new ServiceResult();

            try
            {

                var production = this.productionRepository.Get(Id);

                ProductionResultModel productionResultModel = new ProductionResultModel()
                {
                    ProductionId = production.ProductionId,
                    Name = production.Name,
                    categoryId = production.categoryid,
                    unitprice = production.unitprice,
                    discontinued = production.discontinued,
                    Creation_Date = production.Creation_Date
               
            };
                  

                result.Data = production;
                result.Success = true;
            }


            
            catch (Exception ex)
            {
                result.Message = "Ha ocurrido un error al obtener el production";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveProduction(ProductionSaveDto saveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Production production = new Production()
                {
                  Creation_Date = saveDto.Creation_Date,
                    Creation_User = saveDto.Creation_User,
                    Name = saveDto.Name,

                    ProductionId  = saveDto.ProductionId,
                    ContactTitle = saveDto.ContactTitle,
                    categoryid = saveDto.categoryid,
                    unitprice = saveDto.unitprice,
                    discontinued = saveDto.discontinued,


                };

                this.productionRepository.Save(production);
                result.Message = "El suplidor ha sido Agregado";
                result.Success = true;
                this.productionRepository.SaveChange();
            }
            catch (IProductionEx sdex)
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

        public ServiceResult UpdateProduction(ProductionUpdateDto updateDto)
        {
          
        
           ServiceResult result = new ServiceResult();
            try
            {
               Production productionToUpdate = this.productionRepository.Get(updateDto.ProductionId);
                productionToUpdate.Modify_Date = updateDto.Modify_Date;
                productionToUpdate.Modify_User = updateDto.Modify_User;

                this.productionRepository.Update(productionToUpdate);
                result.Message = "El suplidor ha sido actualizado";
                result.Success = true;
                this.productionRepository.SaveChange();
            
            }
            catch (IProductionException sdex)
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