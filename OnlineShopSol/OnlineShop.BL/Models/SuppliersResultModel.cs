﻿

using System;

namespace OnlineShop.BL.Models
{
    public class SuppliersResultModel
    {
        public int SupplierId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }

        //public int Creation_User { get; set; }
        public DateTime Creation_Date { get; set; }
        public string CreationDateDisplay 
        {
            get { return Creation_Date.ToString("dd/MM/yyyy"); }
            
        }
    }
}
