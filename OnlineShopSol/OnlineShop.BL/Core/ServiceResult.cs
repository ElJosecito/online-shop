using System;
using System.Collections.Generic;
using System.Text;


namespace OnlineShop.BL.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            this.Success = true;
        }
        public bool Success { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }

    }
}