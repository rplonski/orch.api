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
    public class CommandController : ControllerBase
    {
        [HttpGet("GetCommand/{robotId}")]
        public ActionResult<Command> GetCommand(int robotId)
        {
            return new Command() { };
           
        }
    }
}