using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class ShoppingCartLine
    {
        public string CodeProduct { get; private set; }
        public int Amount { get; private set; }
        public decimal Subtotal { get; private set; }
    }
}
