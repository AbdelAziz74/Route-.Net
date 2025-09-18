using MVC_03.DAL.Entities;

namespace MVC_03.BLL.DataTransferObjects
{
    internal static class DepartmentFactory
    {
        public static DepartmentResponse ToResponse(this Department department) => new()
        {
            Id = department.Id,
            Name = department.Name,
            Description = department.Description,
            Code = department.Code
        };
        public static Department ToEntity(this DepartmentRequest request)
        {
            return new Department
            {
                Name = request.Name,
                Description = request.Description,
                Code = request.Code
            };
        }
        public static Department ToEntity(this DepartmentUpdateRequest request)
        {
            return new Department
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Code = request.Code
            };
        }
        public static DepartmentDetailsResponse ToDetailsResponse(this Department department)
        {
            return new DepartmentDetailsResponse
            {
                Id = department.Id,
                Name = department.Name,
                Description = department.Description,
                Code = department.Code
            };
        }

    }
}
