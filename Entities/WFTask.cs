using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Entities
{
    public class WFTask
    {

        public int ID { get; set; }
        public string Description  { get; set; }
        public int WFId { get; set; }
        public WF WorkFlow { get; set; }

    }
}
