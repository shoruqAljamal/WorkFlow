using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Context.Configuration
{
    public class WFConfiguration
    {
        public WFConfiguration(EntityTypeBuilder<WF> entity)
        {


            entity.HasOne<WFStatus>(wf => wf.WFStatus)
                  .WithMany()
                  .HasForeignKey(wf => wf.WFStatusId)
                  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);


            entity.HasData(
                
                new WF()
                {
                    ID =1,
                    Name = "Add User",
                    WFStatusId = 1,
                    CurrentProgressNumberWFStep = 0,
                    
                    
                }
                
                );
        }
    }
}
