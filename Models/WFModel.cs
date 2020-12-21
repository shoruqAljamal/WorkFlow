using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Models
{
    public class WFModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int WFStatusId { get; set; }
        public int CurrentProgressNumberWFStep { get; set; }
        public WFStatus WFStatus { get; set; }
        public ICollection<WFStepModel> WFSteps { get; set; }
        public ICollection<WFTaskModel> WFTasks { get; set; }
    }
}
