using Microsoft.Extensions.Logging;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Core;
using OnlineShop.BL.Datos.Production;
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
                  /*  ProductionId = production.ProductionId,
                    Name = production.Name,
                    categoryId = production.categoryid,
                    unitprice = production.unitprice,
                    discontinued = production.discontinued,
                    Creation_Date = production.Creation_Date*/
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
            throw new NotImplementedException();
        }

        public ServiceResult UpdateProduction(ProductionUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }

}
