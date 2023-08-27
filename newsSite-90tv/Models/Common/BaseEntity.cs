using ShopPanel.PublicClass;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Common
{
    public class BaseEntity<T> where T : struct
    {
        [Key, Display(Name = "شناسه ")]
        public T Id { get; set; }

        [Display(Name = "زمان ایجاد")]
        public DateTime dateMiladi { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public string dateShamsi { get; set; }

        [Display(Name = "وضیعت")]
        public byte status { get; set; }

        public BaseEntity()
        {
            dateMiladi = DateTime.Now;
            dateShamsi = DateAndTimeShamsi.DateTimeShamsi();
        }
    }
}
