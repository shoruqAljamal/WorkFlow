using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.IRepos
{
    public interface IWFStatusRepo
    {

        Task<List<WFStatus>> GetAllWFStatus();
        Task<WFStatus> GetWFStatusByID(int id);
    
    }
}
