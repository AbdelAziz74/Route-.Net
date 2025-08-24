

namespace EF_Core_03.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        
        public int? DepartmentId { get; set; }
        public Department Department { get; set; } = default!;


    }
}
