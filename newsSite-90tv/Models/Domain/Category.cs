using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class Category : BaseEntity<int>
    {

        [Display(Name = "عنوان دسته بندی")]
        public string Title { get; set; }

        [Display(Name = "والد دسته بندی")]
        public int ParentId { get; set; }

        [Display(Name = "تصویر")]
        public string image { get; set; }


        [Display(Name = "نوع دسته بندی")]
        public byte type { get; set; }

        public bool isenable { get; set; }


    }
}
