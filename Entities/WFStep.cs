using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Entities
{
    public class WFStep
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public bool IsFirst { get; set; }
        public bool IsFinal { get; set; }
        public int WFStatusId { get; set; }
        public int WFId { get; set; }
        public WF WorkFlow { get; set; }
        public WFStatus WFStatus { get; set; }


    }
}
