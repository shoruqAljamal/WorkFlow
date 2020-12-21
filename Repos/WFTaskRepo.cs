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
    public class WFTaskRepo : IWFTaskRepo
    {
        private readonly WFContext _wFContext;
        public WFTaskRepo(WFContext wFContext)
        {
            _wFContext = wFContext;
        }
        public async Task<WFTask> Add(WFTask wFTasks)
        {

            _wFContext.WFTasks.Add(wFTasks);
            await _wFContext.SaveChangesAsync();
            return wFTasks;
        }

        public async Task<bool> DeleteByID(int id)
        {
            var wFTasks = GetWFTasksByID(id);
            _wFContext.Remove(wFTasks);
            var success = await _wFContext.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }

        public async Task<List<WFTask>> GetAllWFTasks()
        {
            var wFTasks = await _wFContext.WFTasks.ToListAsync();
            return wFTasks; 
        }

        public async Task<WFTask> GetWFTasksByID(int id)
        {
            var wFTask = await _wFContext.WFTasks.Where(e => e.ID == id)
                                    
                                                  .FirstOrDefaultAsync();
            return wFTask;
        }

        public async Task<bool> Update(WFTask wFTask)
        {
            _wFContext.Update(wFTask); //Change Tracker : only change the state 
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
