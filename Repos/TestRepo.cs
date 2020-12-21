using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Context;
using WorkFlow.Entities;
using WorkFlow.IRepos;
using WorkFlow.Models;

namespace WorkFlow.Repos
{
    public class TestRepo :ITestRepo
    {
        private readonly WFContext _context;
        public TestRepo(WFContext context)
        {
            _context = context;
        }

        public async Task<List<WF>>Test()
        {
            var result = await _context.WorkFlows.Include(e => e.WFStatus)
                                                 .ToListAsync();

            return result;
        
        }
    }
}
