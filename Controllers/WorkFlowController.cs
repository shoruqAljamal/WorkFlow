using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkFlow.IRepos;
using WorkFlow.Models;
using WorkFlow.Supervisors;

namespace WorkFlow.Controllers
{
    [Route("api/WF")]
    public class WorkFlowController : Controller
    {
        private readonly ILogger<WorkFlowController> _logger;
        private readonly ISupervisor _ISupervisor ;
        public WorkFlowController(ILogger<WorkFlowController> logger, ISupervisor ISupervisor)
        {
            _logger = logger;
            _ISupervisor = ISupervisor;
        }

        [HttpPost("AddWorkFlow")]
        public async Task<IActionResult> AddWorkFlow([FromBody]WFModel workFlow)
        {
            try
            {

                var result = await _ISupervisor.AddWorkFlow(workFlow);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return null;
            }
        

        }
    
        public IActionResult Index()
        {
            return View();
        }
    }
}