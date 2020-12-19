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
                
        }
    }
}
