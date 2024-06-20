using Microsoft.EntityFrameworkCore;
using StateAPI.State;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StateAPI.Data
{
    public class StateDBContext : DbContext
    {
        public StateDBContext(DbContextOptions<StateDBContext> options) : base(options) { }
        public DbSet<TasksModel> TasksModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TasksModel>().Property(t => t.State);

            base.OnModelCreating(modelBuilder);
        }
    }
}
