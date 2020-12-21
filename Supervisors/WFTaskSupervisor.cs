using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;

namespace WorkFlow.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<WFModel>> GetAllWorkFlows()
        {
            var workflows = await _IWFRepo.GetAllWorkFlows();
            return _mapper.Map<List<WFModel>>(workflows);
        }
    }
}
