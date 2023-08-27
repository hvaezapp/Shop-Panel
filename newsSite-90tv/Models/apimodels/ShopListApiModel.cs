using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ShopListApiModel
    {

        public long id { get; set; }

        public string   title { get; set; }

        public string category { get; set; }

        public int viewcount { get; set; }

        public int  followcount { get; set; }


        public string image { get; set; }

    }
}
