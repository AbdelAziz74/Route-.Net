

namespace MVC_03.BLL.DataTransferObjects
{
    public class DepartmentUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } // User Input
    }
}
