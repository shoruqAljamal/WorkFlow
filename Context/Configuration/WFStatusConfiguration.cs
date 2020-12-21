using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;

namespace WorkFlow.Context.Configuration
{
    public class WFStatusConfiguration 
    {
        public WFStatusConfiguration(EntityTypeBuilder<WFStatus> entity)
        {
            entity.HasData( 
                
                new WFStatus()
                {
                    ID=1 ,
                    Name="Create"
                },
                  new WFStatus()
                  {
                      ID =2 ,
                      Name = "In Progress"
                  },
                    new WFStatus()
                    {
                        ID = 3,
                        Name = "Finished"
                    },
                      new WFStatus()
                      {
                          ID = 4,
                          Name = "Declined"
                      }

                );
             

        }
    }
}
