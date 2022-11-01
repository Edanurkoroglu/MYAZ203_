﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}
