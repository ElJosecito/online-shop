using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Datos.Production
{
    public class ProductionSaveDto
    {
        public string Name { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }
        public int Creation_User { get; set; }
        public DateTime Creation_Date { get; set; }


    }
}
