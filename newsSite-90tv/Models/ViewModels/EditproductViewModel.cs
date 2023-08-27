using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class EditproductViewModel : CreateproductViewModel
    {
        public IEnumerable<ProductGallary> productGallaries { get; set; }
        public IEnumerable<propertyviewmodel> productproperty { get; set; }
        public IEnumerable<Size> productsize { get; set; }
        public IEnumerable<int> coloridselect { get; set; }
        
       
    }
}
