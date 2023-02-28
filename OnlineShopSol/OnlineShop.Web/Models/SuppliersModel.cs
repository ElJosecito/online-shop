<<<<<<< HEAD
﻿

namespace OnlineShop.Web.Models
{
    public class SuppliersModel : ContructorProductionModel
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set;}
        public string ContactName { get; set;}
        public string ContactTitle { get; set;}
        public string Address { get; set;}
        public string City { get; set;}
        public string Region { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set;}
        public string Phone { get; set;}
        public string Fax { get; set;}
=======
﻿using System;
using OnlineShop.Web.Exceptions;


namespace OnlineShop.Web.Models
{
    public class SuppliersModel
    {
        public int SupplierID { get; set; }

        private string companyName;
        public string CompanyName 
        { 
            get 
            {
                return this.companyName;
            }
            set 
            {
                if ( string.IsNullOrEmpty(value)) 
                {
                    throw new SuppliersException("El campo es requerido");
                }else if (value.Length > 40) 
                {
                    throw new SuppliersException("El nombre excede los caracteres");
                }
            } 
        }
        //
        private string contactName;
        public string ContactName 
        { 
            get 
            {
                return this.contactName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 30)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string contactTitle;
        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 30)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string address;
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 60)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string city;
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 15)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string region;
        public string Region
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 60)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string postalCode;
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 10)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string country;
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 15)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string phone;
        public string Phone
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 60)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
        //
        private string fax;
        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new SuppliersException("El campo es requerido");
                }
                else if (value.Length > 24)
                {
                    throw new SuppliersException("El campo excede los caracteres");
                }
            }
        }
>>>>>>> 29b6fc17b0203c2669673afb10f4b95c329d334a

    }
}
