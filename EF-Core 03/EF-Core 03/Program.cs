using System.Text.Json;
using EF_Core_03.Data;
using EF_Core_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_03
{
    public class Program
    {
        static void Main()
        {
            #region Inheritance Mapping

            /// EF Core supports three strategies for mapping inheritance hierarchies to database tables:
            // 1. Table per Hierarchy (TPH) => All types in the hierarchy are mapped to a single table.
            //        A discriminator column is used to differentiate between types. => Default Strategy
            // 2. Table per Type (TPT) => Each type in the hierarchy is mapped to its own table.
            // 3. TPCC Table per Concrete Class 


            // Pros of TPH => Simplifies The Schema by Sorting All Employees in a Single Table With a Discriminator Column.
            // TPT => Create Table For Every Type and it will be Like: Table For Employee And Table For PartTimeEmployee And Table For FullTimeEmployee
            // Cons => Joins
            // TPCC => 2 Table
            //using var context = new CompanyDbContext();

            ////context.Employees.Add();

            //var partTime1 = new PartTimeEmployee
            //{
            //    Name = "Ahmed Saad",
            //    Email = "Ahmed.Null404a@gmail.com",
            //    Address = "123 Main St, City, Country",
            //    HoursWorked = 20,
            //    HourlyRate = 15.50m
            //};
            //var partTime2 = new PartTimeEmployee
            //{
            //    Name = "Ali Saad",
            //    Email = "Ali.Null404a@gmail.com",
            //    Address = "123 Main St, City, Country",
            //    HoursWorked = 20,
            //    HourlyRate = 17.50m
            //};
            //var fullTime1 = new FullTimeEmployee
            //{
            //    Name = "Mohamed Saad",
            //    Email = "Mohamed.Null404a@gmail.com",
            //    Address = "123 Main St, City, Country",
            //    MontlySalary = 20000,
            //};
            //var fullTime2 = new FullTimeEmployee
            //{
            //    Name = "Mostafa Saad",
            //    Email = "Mostafa.Null404a@gmail.com",
            //    Address = "123 Main St, City, Country",
            //    MontlySalary = 25000,
            //};

            //// TPCC
            //context.FullTimeEmployees.AddRange(fullTime1, fullTime2); // add local => change entity state => added
            //context.PartTimeEmployees.AddRange(partTime1, partTime2); // add local => change entity state => added
            //context.SaveChanges(); // Apply Changes

            //context.Employees.AddRange(partTime1, partTime2, fullTime1, fullTime2); // add local => change entity state => added
            //context.SaveChanges(); // Apply Changes 

            //foreach(var item in context.Employees.OfType<FullTimeEmployee>())
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Insert Data & Related Data
            //using var context = new CompanyDbContext();
            //var dept1 = new Department { Name = "IT" };
            //var dept2 = new Department { Name = "HR" };
            //var dept3 = new Department { Name = "Payroll" };

            //var employees1 = new List<Employee>
            //{
            //    new () { Name = "Ali ", Email= "lol404@gmail.com", Address="123 Main St"},
            //    new () { Name = "Ahmed ", Email= "Ahmed404@gmail.com", Address="123 Main St"},
            //    new () { Name = "Mostafa ", Email= "Mostafa404@gmail.com", Address="123 Main St"}
            //};
            //dept1.Employees = employees1; 
            //context.Departments.Add(dept1);
            //context.SaveChanges();

            //var employees2 = new List<Employee>
            //{
            //    new () { Name = "Ali ", Email= "lol404@gmail.com", Address="123 Main St", DepartmentId = 1},
            //    new () { Name = "Ahmed ", Email= "Ahmed404@gmail.com", Address="123 Main St", DepartmentId = 1},
            //    new () { Name = "Mostafa ", Email= "Mostafa404@gmail.com", Address="123 Main St", DepartmentId = 1}
            //};

            //context.Employees.AddRange(employees2);
            //context.SaveChanges();

            //var employees3 = new List<Employee>
            //{
            //    new () { Name = "Ali ", Email= "lol404@gmail.com", Address="123 Main St", Department = dept3},
            //    new () { Name = "Ahmed ", Email= "Ahmed404@gmail.com", Address="123 Main St", Department = dept3},
            //    new () { Name = "Mostafa ", Email= "Mostafa404@gmail.com", Address="123 Main St", Department = dept3}
            //};

            //context.Employees.AddRange(employees3);
            //context.SaveChanges(); 

            #endregion

            #region Data Seeding

            //using var context = new CompanyDbContext();

            //var data = File.ReadAllText(); 

            //var employees = JsonSerializer.Deserialize<List<Employee>>("");

            //context.Employees.AddRange(employees);
            //context.SaveChanges();

            //if(context.Database.GetPendingMigrations().Any())
            //{
            //    context.Database.Migrate();
            //}

            //if(!context.Employees.Any())
            //{
            //    //var data = File.ReadAllText(); 

            //    _ = JsonSerializer.Deserialize<List<Employee>>("");

            //    //context.Employees.AddRange(employees);
            //    //context.SaveChanges();
            //}


            #endregion

            #region
            
            using var context = new CompanyDbContext();

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 10 );
            //var department = context.Departments.First();

            //Console.WriteLine($"Employee {employee?.Name ?? "NA"} :: Department {employee?.Department?.Name ?? "NA"}");

            // loading Related Data 
            // 1. Explicit Loading

            // refrenece
            //context.Entry(employee).Reference(x => x.Department).Load();

            // collection
            //context.Entry(department!).Collection(d => d.Employees).Load();

            // 2. Eager Loading => join
            // 1 Request
            //var employee = context.Employees.Include(x => x.Department).FirstOrDefault();

            // Projection
            var employees = context.Employees.Select(emp => new
            {
                emp.Id,
                emp.Name,
                DepartmentName = emp.Department,
                DepartmentId = emp.Department.Id

            }).Where(x => x.DepartmentId == 1);

            foreach(var item in employees)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
