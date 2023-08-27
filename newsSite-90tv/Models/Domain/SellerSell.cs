using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class SellerSell : BaseEntity<long>
    {
      

        public long appuser_id { get; set; }


        public long orderdetail_id { get; set; }


        public byte sellstate { get; set; }

        public bool isenable { get; set; }

        public byte fixstate { get; set; }




        // nav


        [ForeignKey("orderdetail_id")]
        public virtual orderDetail Tbl_OrderDetail { get; set; }

        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_UserApp { get; set; }

    }
}
