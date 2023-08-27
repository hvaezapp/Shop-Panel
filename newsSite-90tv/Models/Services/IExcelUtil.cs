using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models.ExtraClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public   interface IExcelUtil
    {
        Task<FileStreamResult> CreateExcel(List<PayaModel> model);
    }
}
