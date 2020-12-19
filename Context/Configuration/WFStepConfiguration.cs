using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Context.Configuration
{
    public class WFStepConfiguration
    {
        public WFStepConfiguration(EntityTypeBuilder<WFStep> entity)
        {
            entity.HasIndex(e => new { e.Number }).IsUnique();

            entity.HasOne<WFStatus>(p => p.WFStatus)
                  .WithMany()
                  .HasForeignKey(p => p.WFStatusId)
                  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            entity.HasOne<WF>(p => p.WorkFlow)
           .WithMany(wf=>wf.WFSteps)
           .HasForeignKey(p => p.WFId)
           .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

        }
    }
}
