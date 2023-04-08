using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Datos.Production
{
    public class ProductionUpdateDto
    {
        public int ProductionId { get; set; }
        public string Name { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }
        public int? Modify_User { get; set; }
        public DateTime? Modify_Date { get; set; }
    }
    
}
