using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class Fixrequest : BaseEntity<int>
    {


        [Display(Name = "فروشنده درخواست دهنده")]
        public long seller_id { get; set; }

        public bool isenable { get; set; }


        // nav

        [ForeignKey(nameof(seller_id))]
        public virtual Salsman Tbl_Salsman { get; set; }


    }
}
