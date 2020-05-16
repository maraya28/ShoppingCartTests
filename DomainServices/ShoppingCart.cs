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

        private void IntializeItems()
        {
            Items ??= new List<Product>();
        }

        public List<Product> Items { get; private set; }

        public void AddItem(string codeItem)
        {
            IntializeItems();

            var item = _productRepository.Get(codeItem);
            if (item == null)
                throw new ShoppingCartException($"The code: {codeItem} doesn´t exist.");
            Items.Add(item);


        }
    }
}
