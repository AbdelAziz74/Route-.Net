using EF_Core_02.Data;
using EF_Core_02.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EF_Core_02
{
    public class Program
    {
        static void Main()
        {

            using var context = new ITIContext();

            var course1 = context.Courses.Find(1);
            var course2 = context.Courses.Find(2);

            if (course1 == null || course2 == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            var student = new Student
            {
                Name = "Ahmed",
                Age = 22,
                Email = "Ahmedali33@gmail.com",
                DepartmentId = 1,
                Courses = new List<Course> { course1, course2 }
            };

            context.Students.Add(student);
            context.SaveChanges();


        }
    }
}
