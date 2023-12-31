﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class productDetailViewModel
    {
        public Product product { get; set; }
        public IEnumerable<ProductProperties> productProperties { get; set; }
        public IEnumerable<string> productColor { get; set; }

        public IEnumerable<string> productSize { get; set; }


    }
}
