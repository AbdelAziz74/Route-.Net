using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_03.DAL.Entities.Enums;

namespace MVC_03.DAL.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; } = default!;
        public int? Age { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; } // FK
        public Gender Gender { get; set; }

        public EmployeeType EmployeeType { get; set; }

    }
}
