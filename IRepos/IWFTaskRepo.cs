using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.IRepos
{
    public interface IWFTaskRepo
    {

        Task<List<WFTask>> GetAllWFTasks();
        Task<WFTask> GetWFTasksByID(int id);
        Task<WFTask> Add(WFTask wFTasks);
        Task<bool> Update(WFTask wFTask);
        Task<bool> DeleteByID(int id);
    }
}
