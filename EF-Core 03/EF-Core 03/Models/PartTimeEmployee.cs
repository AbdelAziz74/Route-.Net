using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_03.Models
{
    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public override string ToString()
        {
            return $"PartTimeEmployee: Name={Name}, Id={Id}, Email={Email}, Address={Address}, HoursWorked={HoursWorked},HourlyRate={HourlyRate:C}";
        }
    }
}   
