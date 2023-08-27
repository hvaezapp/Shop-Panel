using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Common;

namespace ShopPanel.Models.Domain
{
    public class UserAlarm : BaseEntity<int>
    {

      

        public long appuser_id { get; set; }

        public string title { get; set; }

        public string body { get; set; }

        public bool isenable { get; set; }



         // nav

        [ForeignKey(nameof(appuser_id))]
        public virtual UserApp Tbl_Userapp { get; set; }


    }
}
