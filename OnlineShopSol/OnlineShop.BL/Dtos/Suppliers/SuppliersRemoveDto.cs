using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Dtos.Suppliers
{
    public class SuppliersRemoveDto
    {
        public int SupplierId { get; set; }

        public int? Delete_User { get; set; }
        public DateTime? Delete_Date { get; set; }
        public bool Deleted { get; set; }
    }
}
