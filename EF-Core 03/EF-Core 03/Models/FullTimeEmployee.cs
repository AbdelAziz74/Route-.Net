
namespace EF_Core_03.Models
{
    public class FullTimeEmployee : Employee
    {
        public decimal MontlySalary { get; set; }

        public override string ToString()
        {
            return $"FullTimeEmployee: Name={Name}, Id={Id}, Email={Email}, Address={Address}, MontlySalary={MontlySalary:C}";
        }
    }
}
