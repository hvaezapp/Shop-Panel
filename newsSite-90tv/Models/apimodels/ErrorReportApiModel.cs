using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ErrorReportApiModel
    {
        public string desc { get; set; }

        public long id { get; set; }

        public int reason_id { get; set; }
    }
    
  
}
