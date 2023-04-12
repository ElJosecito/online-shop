using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Model
{
    public class ProductionResultModel
    {
        public int ProductionId { get; set; }
        public string Name { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public int categoryid { get; internal set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }
        public int Creation_User { get; set; }
        public DateTime Creation_Date { get; set; }
                    
        public string CreationDateDisplay
        {
            get { return Creation_Date.ToString("dd/MM/yyyy"); }

        }
    }

}
