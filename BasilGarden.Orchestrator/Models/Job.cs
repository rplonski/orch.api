using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasilGarden.Orchestrator.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int WorkflowId { get; set; }
        public string WorkflowBody { get; set; }
    }
}
