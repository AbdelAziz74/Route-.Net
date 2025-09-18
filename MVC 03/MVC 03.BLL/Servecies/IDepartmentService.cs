using MVC_03.BLL.DataTransferObjects;
       
namespace MVC_03.BLL.Servecies
{
    public interface IDepartmentService
    {
        DepartmentDetailsResponse? GetById(int id);
        IEnumerable<DepartmentResponse> GetAll();
        int Update(DepartmentUpdateRequest request);
        bool Delete(int id);
        int Add(DepartmentRequest request);
    }
}
