﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Services;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]
    [Route("api/errorReport/[action]")]
    public class errorReportController : Controller
    {
        private readonly IReport _report;

        public errorReportController(IReport report)
        {
            _report = report;
        }


        [HttpPost]
        public async Task<AllApi> AddErrorReportProduct([FromBody] ErrorReportApiModel model)
        {
            var token = Request.Headers["token"];
            return await _report.AddProductReport(model ,token);
        }

        [HttpPost]
        public async Task<AllApi> AddErrorReportShop([FromBody] ErrorReportApiModel model)
        {
            var token = Request.Headers["token"];
            return await _report.AddshopReport(model, token);
        }


        [HttpGet]
        public async Task<ReportReasonListApiObject> GetReasonList(int type=0)
        {
            return await _report.GetReasonList(type);
        }

    }
}