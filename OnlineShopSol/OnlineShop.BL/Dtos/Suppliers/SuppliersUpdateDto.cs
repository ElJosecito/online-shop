using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BL.Dtos.Suppliers
{
    public class SuppliersUpdateDto
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string? Fax { get; set; }

        public int? Modify_User { get; set; }
        public DateTime? Modify_Date { get; set; }
    }
}
