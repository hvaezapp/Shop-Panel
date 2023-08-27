using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class AddCommentReplyTo : AddCommentModel
    {
        public int   commentid { get; set; }
    }
}
