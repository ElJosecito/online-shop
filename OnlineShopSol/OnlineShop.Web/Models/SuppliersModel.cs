using System;

namespace OnlineShop.Web.Models
{
    public class SuppliersModel : ContructorProductionModel
    {
        public int SupplierId { get; set; }

        //
        private string companyName { get; set; }
        public string CompanyName 
        {
            get { return this.companyName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El campo CompanyName esta vacio");
                }else if(value.Length > 40) 
                {
                    throw new ArgumentOutOfRangeException("El Nombre excedio los caracteres permitidos");
                }
            }
        }
        //
        private string containeName { get; set; }
        public string ContactName 
        { 
            get;
            set;
        }
        public string ContactTitle { get; set;}
        public string Address { get; set;}
        public string City { get; set;}
        public string Region { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set;}
        public string Phone { get; set;}
        public string Fax { get; set;}

    }
}
