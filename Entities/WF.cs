using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Entities
{
    public class WF
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int WFStatusId { get; set; }
        public int CurrentProgressNumberWFStep { get; set; }
        public WFStatus WFStatus { get; set; }
        public ICollection<WFStep> WFSteps { get; set; }
        public ICollection<WFTask> WFTasks { get; set; }

    }
}
