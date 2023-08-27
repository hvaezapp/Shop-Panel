using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class OrderHistoryApiModel
    {

        public long idorder { get; set; }
        public string codeorder { get; set; }

        public long totalprice { get; set; }

        public bool isfinish { get; set; }

        public string createdate { get; set; }

        public string paydate { get; set; }
    }
}
