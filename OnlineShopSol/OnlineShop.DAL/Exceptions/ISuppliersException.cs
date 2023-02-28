﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Exceptions
{
    internal class ISuppliersException : Exception
    {
        public ISuppliersException(string message) : base(message) 
        {
            //Logica de excepcion
            //Y se envia por correo
        }
    }
}
