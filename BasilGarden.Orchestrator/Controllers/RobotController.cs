using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasilGarden.Orchestrator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasilGarden.Orchestrator.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        
        [HttpPost("Register")]
        public ActionResult<int> Register([FromBody] RobotData robotData)
        {
            //TODO
            return 1234;
        }

        [HttpPut("Heartbeat/{robotId}")]
        public ActionResult Heartbeat(int robotId)
        {
            //TODO
            return Ok();
        }
    }
}