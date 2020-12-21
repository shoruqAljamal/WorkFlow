using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.IRepos
{
   public interface IWFStepRepo
    {

        Task<List<WFStep>> GetAllWFSteps();
        Task<WFStep> GetWFStepsByID(int id);
        Task<WFStep> Add(WFStep wFStep);
        Task<bool> Update(WFStep wFStep);
        Task<bool> DeleteByID(int id);
        Task<int> ReturnLastNumber(int id);
    }
}
