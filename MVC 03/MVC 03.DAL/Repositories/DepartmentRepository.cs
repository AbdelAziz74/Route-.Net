using MVC_03.DAL.Context;


namespace MVC_03.DAL.Repositories
{
    public class DepartmentRepository
    {
       private CompanyDbContext _dbContext;
         public DepartmentRepository(CompanyDbContext dbContext)
         {
            _dbContext = dbContext;
        }
    }
}
