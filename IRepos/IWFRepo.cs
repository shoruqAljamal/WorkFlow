using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.IRepos
{
    public interface IWFRepo
    {
        Task<List<WF>> GetAllWorkFlows();
        Task<WF> GetWorkFlowByID(int id);
        Task<WF> Add(WF workFlow);
        Task<bool> Update(WF workFlow);
        Task<bool> DeleteByID(int id);
    }
}
