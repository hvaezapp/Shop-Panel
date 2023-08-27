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
    public class Order : BaseEntity<long>
    {



        [Display(Name = "خریدار")]
        public long appuser_id { get; set; }


        [Display(Name = "جمع کل سفارش")]
        public int sumprice { get; set; }


        [Display(Name = "هزینه پستی ")]
        public int postprice { get; set; }


        [Display(Name = "نوع پست ")]
        public byte posttype { get; set; }


        [Display(Name = "ادرس خریدار ")]
        public int useradd_id { get; set; } // user address select


        [Display(Name = "کد سفارش ")]
        public string codeorder { get; set; } // is unique


        [Display(Name = "وضیعت پرداخت  ")]
        public bool isfinish { get; set; }



        public DateTime finishdateMiladi { get; set; }


        [Display(Name = "تاریخ تکمیل   ")]
        public string finishdateShamsi { get; set; }



        public bool isEnable { get; set; }



        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_UserApp { get; set; }









    }
}
