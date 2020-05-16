using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IProductRepository
    {
        Product Get(string code);
    }
}
