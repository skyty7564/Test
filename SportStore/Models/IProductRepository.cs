﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SportStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Product { get; }
    }
}
