using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasilGarden.Orchestrator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasilGarden.Orchestrator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpGet("GetJob/{robotId}")]
        public ActionResult<Job> GetJob(int robotId)
		{
            //TODO
            return new Job()
            {
                Id = 1, 
                WorkflowId = 15,
                WorkflowBody = "<xml><workflow></workflow></xml>"
            };
		}

        [HttpPut("UpdateJobStatus")]
        public void UpdateJobStatus(int jobId, int jobStatusId, int robotId)
        {
            //TODO
           // return Ok();
        }

        [HttpPost]
        public void DoJob([FromBody] string workflowName, string data)
        {

            //TODO
        }


        [HttpPut("Test")]
        public void Test([FromBody] Command command)
        {
            //TODO
        }
    }
}