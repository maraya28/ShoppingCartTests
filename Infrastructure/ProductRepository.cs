using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ProductRepository<T> : IProductRepository 
        where T : class
    {
        public Product Get(string code)
        {
            throw new NotImplementedException();
        }
    }
}
