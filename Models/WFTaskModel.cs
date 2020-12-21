using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Models
{
    public class WFTaskModel
    {

        public int ID { get; set; }
        public string Description { get; set; }
        public int WFId { get; set; }
        
    }
}
