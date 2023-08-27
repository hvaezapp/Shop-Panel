using ShopPanel.PublicClass;
using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class Salsman : BaseEntity<long>
    {

        public bool isEnable { get; set; }


        public long appuser_id { get; set; }

        public string user_id { get; set; }


        // nav

        [ForeignKey("user_id")]
        public virtual ApplicationUsers user { get; set; }


        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_Userapp { get; set; }



    }
}
