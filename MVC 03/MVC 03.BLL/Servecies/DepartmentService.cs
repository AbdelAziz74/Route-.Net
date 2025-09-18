using MVC_03.DAL.Repositories;
using MVC_03.BLL.DataTransferObjects;
using MVC_03.DAL.Entities;
namespace MVC_03.BLL.Servecies
{
    public class DepartmentService (IDepartmentRepository departmentRepository) 
        : IDepartmentService
    {
        public int Add(DepartmentRequest request)
        {
            var department = request.ToEntity();
            return departmentRepository.Add(department);    
        }

        public IEnumerable<DepartmentResponse> GetAll()
        {
            return departmentRepository.GetAll().Select(x => x.ToResponse());
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DepartmentDetailsResponse? GetById(int id)
        {
          return departmentRepository.GetById(id)?.ToDetailsResponse();
        }
        public int Update(DepartmentUpdateRequest request)
        {
            return departmentRepository.Update(request.ToEntity());
        }
    }
}
