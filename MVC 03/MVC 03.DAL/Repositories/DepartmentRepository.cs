using Microsoft.EntityFrameworkCore;
using MVC_03.DAL.Context;
using MVC_03.DAL.Entities;


namespace MVC_03.DAL.Repositories
{
  
    public class DepartmentRepository : IDepartmentRepository
    {
        private  CompanyDbContext _dbContext;
        private  DbSet<Department> _departments;

        public DepartmentRepository(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
            _departments = dbContext.Departments;
        }

        public IEnumerable<Department> GetAll(bool trackChanges = false)
            => trackChanges
                ? _departments.ToList()
                : _departments.AsNoTracking().ToList();

        public Department? GetById(int id)
            => _departments.Find(id);

        public int Add(Department department)
        {
            _departments.Add(department);
            return _dbContext.SaveChanges();
        }

        public int Update(Department department)
        {
            _departments.Update(department);
            return _dbContext.SaveChanges();
        }

        public int Delete(int id)
        {
            var dept = _departments.Find(id);
            if (dept != null)
            {
                _departments.Remove(dept);
                return _dbContext.SaveChanges();
            }
            return 0;
        }

    }
}
