using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class AdvGetModel
    {
        public long id { get; set; }
        public string image { get; set; }

        public string title { get; set; }

        public string shopname { get; set; }


        public int viewcount { get; set; }


    }
}
