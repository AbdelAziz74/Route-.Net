global using Microsoft.EntityFrameworkCore;
global using MVC_03.DAL.Entities;

namespace MVC_03.DAL.Context 
{
    public class CompanyDbContext : DbContext 
    {
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }
    }
}
