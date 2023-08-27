using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class OrderDetailListApiModel
    {
        public long iddetail { get; set; }

        public string productname { get; set; }

        public string productimage { get; set; }

        public string shopname { get; set; }

       // public long price { get; set; }

        public int count { get; set; }

        public string color { get; set; }

        public long finalprice { get; set; }
       

    }
}
