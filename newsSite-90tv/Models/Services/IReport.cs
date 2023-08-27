using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface IReport
    {
        Task<AllApi> AddProductReport(ErrorReportApiModel model , string token);
        Task<AllApi> AddshopReport(ErrorReportApiModel model, string token);
        Task<ReportReasonListApiObject> GetReasonList(int type);
    }
}
