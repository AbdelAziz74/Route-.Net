namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Q1 main
            //Employee emp = new Employee(10, "Abdel Aziz", 'A', Security.Developer, 700.50m, new DateTime(2025, 7, 9));
            //Console.WriteLine(emp.ToString());
            #endregion

            #region Q2 main
            //HiringDate hireDate = new HiringDate(9, 7, 2025);
            //Console.WriteLine("Hire Date: " + hireDate.ToString());
            #endregion

            #region Q3 main
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee("Ahmed", "DBA", "Read, Write, Backup", new DateTime(2025, 7, 10));
            //EmpArr[1] = new Employee("Guest User", "Guest", "Read Only", new DateTime(2025, 7, 1));
            //EmpArr[2] = new Employee("Security Admin", "Security Officer", "Full Access", new DateTime(2025, 7, 8));

            //foreach (Employee emp in EmpArr)
            //{
            //    emp.Display();
            //}
            #endregion

        }
    }
}

#region Q1
//public enum Security
//{
//    Guest,
//    Developer,
//    Secretary,
//    DBA
//}
//public class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    private char gender;



//    public char Gender
//    {
//        get => gender;
//        set
//        {
//            if (value == 'M' || value == 'F')
//                gender = value;
//            else
//                throw new ArgumentException("Gender must be 'M' or 'F'");
//        }
//    }

//    public Security Security { get; set; }
//    public decimal Salary { get; set; }
//    public DateTime HireDate { get; set; }



//    public Employee(int id, string name, char gender, Security security, decimal salary, DateTime hireDate)
//    {
//        ID = id;
//        Name = name;
//        Gender = gender;
//        Security = security;
//        Salary = salary;
//        HireDate = hireDate;
//    }
//    public override string ToString()
//    {
//        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, " +
//               $"Security: {Security}, Salary: {String.Format("{0:C}", Salary)}, " +
//               $"Hire Date: {HireDate.ToShortDateString()}";
//    }
//}

#endregion

#region Q2
//public class HiringDate
//{
//    public int Day { get; set; }
//    public int Month { get; set; }
//    public int Year { get; set; }
//    public HiringDate(int day, int month, int year)
//    {
//        if (!ValidDate(day, month, year))
//            throw new ArgumentException("Invalid date.");

//        Day = day;
//        Month = month;
//        Year = year;
//    }

//    private bool ValidDate(int day, int month, int year)
//    {
//        return DateTime.TryParse($"{year}-{month}-{day}", out _);
//    }


//    public override string ToString()
//    {
//        return $"{Day:D2}/{Month:D2}/{Year}";
//    }
//    public DateTime ToDateTime()
//    {
//        return new DateTime(Year, Month, Day);
//    }
//}

#endregion

#region Q3
class Employee
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Permissions { get; set; }
    public DateTime HiringDate { get; set; }
    public Employee()
    {
        Name = "Unknown";
        Role = "Unknown";
        Permissions = "None";
        HiringDate = DateTime.Now;
    }
    public Employee(string name, string role, string permissions, DateTime hiringDate)
    {
        Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
        Role = string.IsNullOrWhiteSpace(role) ? "Unknown" : role;
        Permissions = string.IsNullOrWhiteSpace(permissions) ? "None" : permissions;
        HiringDate = hiringDate > DateTime.MinValue ? hiringDate : DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Role: {Role}");
        Console.WriteLine($"Permissions: {Permissions}");
        Console.WriteLine($"Hiring Date: {HiringDate.ToShortDateString()}");
  
    }
}

#endregion