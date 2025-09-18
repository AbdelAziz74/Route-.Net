using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.BLL.DataTransferObjects
{
    public class DepartmentDetailsResponse
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }  // User Id
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedBy { get; set; } // User Id
        public DateTime LastModifiedOn { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } // User Input

    }
}
