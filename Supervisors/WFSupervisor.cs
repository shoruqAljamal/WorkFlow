using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;
using WorkFlow.Models;

namespace WorkFlow.Supervisors
{
    public partial class Supervisor
    {

        public async Task<WFModel> AddWorkFlow(WFModel wFModel)
        {
            var wFentity = _mapper.Map<WF>(wFModel);
            var number = 1;

            foreach (var wFStep in wFentity.WFSteps)
            {
                wFStep.Number = number;
                number++;
            }
            return _mapper.Map<WFModel>(await _IWFRepo.Add(wFentity));

        }
    }
}
