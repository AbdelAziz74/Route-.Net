

using MVC_03.DAL.Entities;

namespace MVC_03.BLL.MappingProfiles;

internal class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<EmployeeRequest, Employee>();
        CreateMap<EmployeeUpdateRequest, Employee>();
        CreateMap<Employee, EmployeeDetailsResponse>();
        
    }
}
