using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class Repository<T> : IRepository 
        where T : EntityModel
    {
        public Product Get(string code)
        {
            throw new NotImplementedException();
        }
    }
}
