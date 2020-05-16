﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{
    public class Product 
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}
