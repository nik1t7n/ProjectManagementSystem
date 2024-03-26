using Microsoft.EntityFrameworkCore;
using SibersInternshipMind.Shared.Entities;

namespace SibersInternshipMind.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ActiveProject> ActiveProjects { get; set; }
        public DbSet<Document> Documents { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
