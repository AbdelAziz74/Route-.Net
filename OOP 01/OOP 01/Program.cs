using System.Xml.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (dayes d in Enum.GetValues(typeof(dayes) ))                
            //     Console.WriteLine(d);
            #endregion

            #region Q2
            //Person[] people = new Person[3];
            //people[0] = new Person("Ali", 20);
            //people[1] = new Person("Mohamed", 30);
            //people[2] = new Person("Eman", 22);
            //foreach (Person p in people)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            //}
            #endregion

            #region Q3

            //Console.WriteLine("Enter A Sesason: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season SSeason))
            //{
            //    switch (SSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring From March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer From June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autum From September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter From December to February");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Invalid Input");
            #endregion

            #region Q4

            //Console.WriteLine("Enter A Color: ");
            //string inputColor = Console.ReadLine();
            //if (Enum.TryParse(inputColor, true, out Colors color))
            //{ 

            //    Console.WriteLine((inputColor == "Red" || inputColor == "Green" || inputColor == "Blue") ? "This Color Is A primary Color" : "Not A Primary Color" );
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Color Input");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("Enter Your first Point: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Point p1 = new Point(x1, y1);

            //Console.WriteLine("Enter Your Second Point: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Point p2 = new Point(x2, y2);
            //double dis = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine(dis);
            #endregion

            #region Q6
            //Person[] people = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{

            //    string name = Console.ReadLine();
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //    Console.WriteLine();
            //}
            //Person old = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > old.Age)
            //    {
            //        old = people[i];
            //    }

            //    Console.WriteLine(old.Name, old.Age);

                #endregion

            }
    }
}

public enum dayes
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

public struct Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public enum Colors
{
    Red,
    Green,
    Blue
}

public struct Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

