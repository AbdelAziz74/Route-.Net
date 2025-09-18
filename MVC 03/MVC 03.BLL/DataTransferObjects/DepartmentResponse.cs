using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.BLL.DataTransferObjects
{
    public class DepartmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } // User Input
    }
}
