using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class SellerSellListApiModel
    {

        public long idsell { get; set; }

        public long idproduct { get; set; }

        public string productname { get; set; }

        public string productimage { get; set; }

        public string selldate { get; set; }

        public byte sellstatus { get; set; }

        public byte fixstatus { get; set; }


    }
}
