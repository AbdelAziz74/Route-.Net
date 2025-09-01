using System.Text.Json;
using EF_Core_04.Data;
using EF_Core_04.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_04.Data
{
    public class CompanyDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ;Database = CompanyDb ;Trusted_Connection=True; TrustServerCertificate = true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartmentView { get; set; }
    }

   
}
