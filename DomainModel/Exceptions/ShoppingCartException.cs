using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class ShoppingCartException : Exception
    {
        public ShoppingCartException(string message) :
            base(message)
        {

        }
    }
}
