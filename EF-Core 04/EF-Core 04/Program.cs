using System.Linq;
using EF_Core_04.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new Data.CompanyDbContext();

            #region Joins
            //var result = from employee in context.Employees
            //             join department in context.Departments
            //             on employee.DepartmentId equals department.Id
            //             select new
            //             {
            //                 EmployeeName = employee.Name,
            //                 DepartmentName = department.Name

            //             };
            //var result = context.Departments.Join(context.Employees ,
            //    d => d.Id,
            //    e => e.DepartmentId,
            //    (d, e) => new
            //    {
            //        EmployeeName = e.Name,
            //        DepartmentName = d.Name
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            var data = context.EmployeeDepartmentView.ToList();

            foreach (var item in data)
                Console.WriteLine($"Emp_Id: {item.EmployeeId}, Emp_Name: {item.EmployeeName}, Dept_Id: {item.DepartmentId}, Dept_Name: {item.DepartmentName}");



        }
    }
   
}
