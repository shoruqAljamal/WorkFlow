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
    public class WFStatusRepo : IWFStatusRepo
    {
        private readonly WFContext _wFContext;
        public WFStatusRepo(WFContext wFContext)
        {
            _wFContext = wFContext;
        }
        public async Task<List<WFStatus>> GetAllWFStatus()
        {
            var wFStatus = await _wFContext.WFStatus.ToListAsync();
            return wFStatus;
        }

        public async Task<WFStatus> GetWFStatusByID(int id)
        {
            var wFStatus = await _wFContext.WFStatus.Where(e => e.ID == id)
                                         .FirstOrDefaultAsync();

            return wFStatus;
        }
    }
}
