using Gambit.Recruitment.Business.Data;
using Gambit.Recruitment.Business.Interfaces;
using Gambit.Recruitment.WebApi.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambit.Recruitment.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerformanceController : ControllerBase
    {
        private readonly IPerformanceService _performanceService;
        public PerformanceController(IPerformanceService performanceService)
        {
            _performanceService = performanceService;
        }

        [HttpGet]
        public ActionResult List(DateTime dateFrom, DateTime dateTo)
        {
            var data = Initializer.Initiate();

            try
            {
                var result = _performanceService.GetPerformance(dateFrom, dateTo, data);
                return Ok(Math.Round(result, 2));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
