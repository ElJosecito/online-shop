using OnlineShop.BL.Core;
using OnlineShop.BL.Datos.Production;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Contract
{
    public interface IProductionService : IBaseService
    {
        ServiceResult SaveProduction(ProductionSaveDto saveDto);
        ServiceResult UpdateProduction(ProductionUpdateDto updateDto);
        ServiceResult DeleteProduction(ProductionRemoveDto removeDto);
    }
}
