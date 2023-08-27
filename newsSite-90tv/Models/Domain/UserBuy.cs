using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class UserBuy : BaseEntity<long>
    {


        public long appuser_id { get; set; }


        public long orderdetail_id { get; set; }


        public byte buystate { get; set; }

        public bool isenable { get; set; }



        // nav


        [ForeignKey("orderdetail_id")]
        public virtual orderDetail Tbl_OrderDetail { get; set; }

        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_UserApp { get; set; }

    }
}
