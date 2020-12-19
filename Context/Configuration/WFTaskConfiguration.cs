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
        }
    }
}
