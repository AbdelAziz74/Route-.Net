using EF_Core_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EF_Core_03.Data
{
    public class CompanyDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ;Database = CompanyDb ;Trusted_Connection=True; TrustServerCertificate = true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FullTimeEmployee>()
            //    .HasBaseType<Employee>()
            //    .HasDiscriminator<String>("EmployeeType")
            //    .HasValue<FullTimeEmployee>("FTE");

            //modelBuilder.Entity<PartTimeEmployee>()
            //    .HasBaseType<Employee>()
            //    .HasDiscriminator<String>("EmployeeType")
            //    .HasValue<PartTimeEmployee>("PTE");



        }

    }
}
