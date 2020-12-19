using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Context.Configuration;
using WorkFlow.Entities;

namespace WorkFlow.Context
{
    public class WFContext : DbContext
    {

        public DbSet<WF> WorkFlows { get; set; }
        public DbSet<WFStatus> WFStatus { get; set; }
        public DbSet<WFStep> WFSteps { get; set; }
        public DbSet<WFTask> WFTasks { get; set; }

        public WFContext(DbContextOptions<WFContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new WFConfiguration(modelBuilder.Entity<WF>());

            new WFStatusConfiguration(modelBuilder.Entity<WFStatus>());
            new WFStepConfiguration(modelBuilder.Entity<WFStep>());
            new WFTaskConfiguration(modelBuilder.Entity<WFTask>());
          

        }
    }
}
