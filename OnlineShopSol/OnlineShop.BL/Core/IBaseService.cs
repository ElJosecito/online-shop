using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Core
{
    public interface IBaseService
    {
        ServiceResult GetAll();
        ServiceResult GetById(int Id);
    }
}