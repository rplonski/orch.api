using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasilGarden.Orchestrator.Models
{
    public class RobotData
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Ipv4 { get; set; }
        public string Ipv6 { get; set; }
        public string HostName { get; set; }
        public string MachineName { get; set; }
    }
}
