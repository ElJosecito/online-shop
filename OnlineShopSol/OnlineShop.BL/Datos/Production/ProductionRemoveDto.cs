using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Datos.Production
{
    public class ProductionRemoveDto
    {
        public int ProductionId { get; set; }
        public int? Delete_User { get; set; }
        public DateTime? Delete_Date { get; set; }
        public bool Deleted { get; set; }
    }
}
