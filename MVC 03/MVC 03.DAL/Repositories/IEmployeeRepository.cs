using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.DAL.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll(bool trackChanges = false);
        Employee? GetById(int id);
        int Add(Employee employee);
        int Update(Employee employee);
        int Delete(Employee employee);
    }
}
