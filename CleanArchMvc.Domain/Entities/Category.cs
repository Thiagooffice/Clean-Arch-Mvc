﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
