﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class GetUserProfileInfoApiModel
    {
        public long appuser_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string nationalcode { get; set; }

        public string mobile { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public byte gender { get; set; }
        public byte type { get; set; }

        public string image { get; set; }
    }


}
