
namespace MVC_03.DAL.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? Description { get; set; }
        
        public DateTime CreatedAt { get; set; } // User Input
    }
}
