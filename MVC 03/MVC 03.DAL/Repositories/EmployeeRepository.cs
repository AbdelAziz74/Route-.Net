using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_03.DAL.Context;
using MVC_03.DAL.Entities;

namespace MVC_03.DAL.Repositories
{
    public class EmployeeRepository(CompanyDbContext context) : IRepository<Employee>
    {
        private DbSet<Employee> _employees = context.Employees;
        private object _dbSet;

        public IEnumerable<Employee> GetAll(bool trackChanges = false)
            => trackChanges
                ? _employees.ToList()
                : _employees.AsNoTracking().ToList();

        public Employee? GetById(int id)
            => _employees.Find(id);

        public int Add(Employee employee)
        {
            _employees.Add(employee);
            return context.SaveChanges();
        }

        public int Update(Employee employee)
        {
            _employees.Update(employee);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            var dept = _employees.Find(id);
            if (dept != null)
            {
                _employees.Remove(dept);
                return context.SaveChanges();
            }
            return 0;
        }
        public IQueryable<Employee> GetAllAsQueryable()
        {
            return _dbSet.Where(x => !x.IsDeleted);
        }
          
    }
}
