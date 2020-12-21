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
    public class WFStepRepo : IWFStepRepo
    {
        private readonly WFContext _wFContext;
        public WFStepRepo(WFContext wFContext)
        {
            _wFContext = wFContext;
        }
        public async Task<WFStep> Add(WFStep wFStep)
        {
            _wFContext.WFSteps.Add(wFStep);
            await _wFContext.SaveChangesAsync();
            return wFStep;
        }

        public async Task<bool> DeleteByID(int id)
        {
            var wFStep = GetWFStepsByID(id);
            _wFContext.Remove(wFStep);
            var success = await _wFContext.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }

        public async Task<List<WFStep>> GetAllWFSteps()
        {
            var wFSteps = await _wFContext.WFSteps.ToListAsync();
            return wFSteps;
        }

        public async Task<WFStep> GetWFStepsByID(int id)
        {
            var wFStep = await _wFContext.WFSteps.Where(e => e.ID == id)
                                                   .Include(e => e.WFStatus)
                                                   .FirstOrDefaultAsync();
            return wFStep;
        }

        public async Task<bool> Update(WFStep wFStep)
        {
            _wFContext.Update(wFStep); //Change Tracker : only change the state 
            try
            {
                await _wFContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        public async Task<int> ReturnLastNumber(int id)
        {
            var lastnumber = await _wFContext.WFSteps.Where(e=>e.WFId ==id).MaxAsync(e => e.Number);
            if (lastnumber == 0)
                return 1;
            return lastnumber + 1;
        }

    }
}
