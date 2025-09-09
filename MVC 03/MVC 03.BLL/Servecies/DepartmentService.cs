using MVC_03.DAL.Repositories;

namespace MVC_03.BLL.Servecies
{
    public class DepartmentService
    {
        private DepartmentRepository _departmentRepository;
        
        public DepartmentService(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
    }
}
