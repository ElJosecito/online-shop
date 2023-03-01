using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Exceptions
{
    internal class IProductionException : Exception
    {
        public IProductionException(string message) : base(message)
        {
            //Logica de excepcion
            //Y se envia por correo
        }
    }
}

