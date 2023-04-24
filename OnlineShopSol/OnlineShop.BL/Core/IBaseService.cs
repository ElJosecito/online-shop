using OnlineShop.BL.Datos.Production;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Core
{
    public interface IBaseService
    {
        ServiceResult GetAll();
        ServiceResult GetById(int Id);
        ServiceResult UpdateProduction(ProductionUpdateDto updateDto);
    }
}