using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;
using WorkFlow.Models;

namespace WorkFlow.IRepos
{
    public interface ITestRepo
    {
        Task<List<WF>> Test();
    }
}
