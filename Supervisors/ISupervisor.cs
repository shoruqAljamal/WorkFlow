using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;

namespace WorkFlow.Supervisors
{
    public interface ISupervisor
    {
        #region WorkFlow
        Task<WFModel> AddWorkFlow(WFModel wFModel); 
        #endregion
    }
}
