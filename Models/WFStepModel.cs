using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Models
{
    public class WFStepModel
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public bool IsFirst { get; set; }
        public bool IsFinal { get; set; }
        public int WFStatusId { get; set; }
        public int WFId { get; set; }

        public WFStatus WFStatus { get; set; }
    }
}
