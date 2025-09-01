namespace EF_Core_04.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<Employee> Employees { get; set; } = [];
    }
}
