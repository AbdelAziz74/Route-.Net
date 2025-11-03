global using Microsoft.EntityFrameworkCore;
global using MVC_03.DAL.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace MVC_03.DAL.Context 
{
    public class CompanyDbContext : DbContext 
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<IdentityUser> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }
    }
}
