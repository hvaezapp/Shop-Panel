﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class ProductSizeEditViewModel
    {
        public Size size { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<int> selectedid { get; set; }
    }
}
