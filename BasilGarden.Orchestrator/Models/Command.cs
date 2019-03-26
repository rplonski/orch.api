using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasilGarden.Orchestrator.Models
{
    public class Command
    {
        public int Id { get; set; }
        public int CommandTypeId { get; set; }
        public string Data { get; set; }

    }
}
