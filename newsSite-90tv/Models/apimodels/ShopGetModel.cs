﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ShopGetModel
    {
        public long id { get; set; } 

        public string title { get; set; }

        public string cat_title { get; set; }

        public string imagepath { get; set; }
    }
}
