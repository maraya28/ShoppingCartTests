using DomainModel;
using DomainModel.Model;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class ShoppingCart
    {
        private IProductRepository _productRepository;

        public ShoppingCart(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> Items { get; private set; }

        public void AddItem(string codeItem)
        {
            try
            {
                var item = _productRepository.Get(codeItem);
                if (item == null)
                    throw new ShoppingCartException("The code doesn´t exist");
                Items.Add(item);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
