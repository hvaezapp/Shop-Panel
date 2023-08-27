using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class UserAddress : BaseEntity<int>
    {
        public long appuser_id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string postalcode { get; set; }

        public string phone { get; set; }

        public string mobile { get; set; }

        public int city_id { get; set; }

        public int ostan_id { get; set; }

        public string lat { get; set; }

        public string lot { get; set; }



        public bool isenable { get; set; }

        public bool isActive { get; set; }



        // nav

        [ForeignKey(nameof(city_id))]
        public virtual City Tbl_city { get; set; }


        [ForeignKey(nameof(ostan_id))]
        public virtual Ostan Tbl_ostan { get; set; }


        [ForeignKey(nameof(appuser_id))]
        public virtual UserApp Tbl_Userapp { get; set; }

    }
}
