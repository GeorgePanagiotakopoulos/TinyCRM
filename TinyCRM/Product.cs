﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCRM
{
    public class Product
    {
        public string Name { get; set; }
        public string ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; private set; }
        
        

    }
}
