using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class RegisterApiModel
    {

        
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string mobile { get; set; }
    }
}
