using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Context;
using WorkFlow.Entities;
using WorkFlow.IRepos;

namespace WorkFlow.Repos
{
    public class WFRepo : IWFRepo
    {
        private readonly WFContext _wFContext;
        public WFRepo(WFContext wFContext)
        {
            _wFContext = wFContext;      
        }
        public async Task<WF> Add(WF workFlow)
        {
            /// check next line 
            _wFContext.WorkFlows.Add(workFlow);
            await _wFContext.SaveChangesAsync();
            return workFlow;

        }

        public async Task<bool> DeleteByID(int id)
        {
            var workFlow = GetWorkFlowByID(id);
            _wFContext.Remove(workFlow);
            var success = await _wFContext.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }

        public async Task<List<WF>> GetAllWorkFlows()
        {
            var workFlows = await _wFContext.WorkFlows.ToListAsync();
            return workFlows;
        }

        public async Task<WF> GetWorkFlowByID(int id)
        {
            var workFlow = await _wFContext.WorkFlows.Where(e=>e.ID == id)
                                                     .Include(e=>e.WFStatus)  
                                                     .FirstOrDefaultAsync();
            return workFlow;
        }

        public async Task<bool> Update(WF workFlow)
        {
            _wFContext.Update(workFlow); //Change Tracker : only change the state 
            try
            {
                await _wFContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return true;
        }
    }
}
