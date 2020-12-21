using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Context.Configuration
{
    public class WFTaskConfiguration
    {
        public WFTaskConfiguration(EntityTypeBuilder<WFTask> entity)
        {
       
            entity.HasOne<WF>(t => t.WorkFlow)
           .WithMany(wf => wf.WFTasks)
           .HasForeignKey(t => t.WFId)
           .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            entity.HasData(
                
                new WFTask() 
                {
                  ID =1,
                  WFId =1,
                  Description ="add name"
                
                },

               new WFTask()
               {
                  ID = 2,
                  WFId = 1,
                  Description = "add gender"

               },
               new WFTask()
               {
                  ID = 3,
                  WFId = 1,
                  Description = "add age"

               }




                );
        }
    }
}
