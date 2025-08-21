using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; } 
        public ICollection<Instructor> Instructors { get; set; }
    }

}
