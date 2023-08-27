using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class City : BaseEntity<int>
    {


        public string title { get; set; }

        public int ostan_id { get; set; }


        [ForeignKey("ostan_id")]
        public virtual Ostan Tblostan { get; set; }




    }
}
