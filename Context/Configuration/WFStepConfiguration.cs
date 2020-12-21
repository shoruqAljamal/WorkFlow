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
            entity.HasIndex(e => new { e.Number , e.WFId}).IsUnique();

            entity.HasOne<WFStatus>(p => p.WFStatus)
                  .WithMany()
                  .HasForeignKey(p => p.WFStatusId)
                  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            entity.HasOne<WF>(p => p.WorkFlow)
           .WithMany(wf => wf.WFSteps)
           .HasForeignKey(p => p.WFId)
           .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);


            entity.HasData(

                new WFStep()
                {
                    ID = 1,
                    WFStatusId = 1,
                    WFId = 1,
                    Number = 1,
                    IsFirst = true,
                    IsFinal = false


                },
                new WFStep()
                 {   
                        ID = 2,
                        WFStatusId = 1,
                        WFId = 1,
                        Number = 2,
                        IsFirst = false,
                        IsFinal = false
                    },
                     new WFStep()
                       {
                        ID = 3,
                        WFStatusId = 1,
                        WFId = 1,
                        Number = 3,
                        IsFirst = false,
                        IsFinal = true
                       }                      

                );
        }
    }
}
