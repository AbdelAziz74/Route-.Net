using System.Drawing;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            // part 1
            #region Q1
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(5, 4));             
            //Console.WriteLine(calc.Add(1, 2, 3));       
            //Console.WriteLine(calc.Add(7.5, 4.7));
            #endregion

            #region Q2
            //Rec r1 = new Rec();
            //Rec r2 = new Rec(2, 5);
            //Rec r3 = new Rec(5);

            //Console.WriteLine( r1.ClacArea());
            //Console.WriteLine(r2.ClacArea());
            //Console.WriteLine(r3.ClacArea());
            #endregion

            #region Q4
            //Employee emp = new Employee();
            //Manager mang = new Manager();

            //emp.Work();
            //mang.Work();
            #endregion

            #region Q5
            //BaseClass baseObj;

            //baseObj = new BaseClass();
            //baseObj.DisplayMessage(); 

            //baseObj = new DerivedClass1();
            //baseObj.DisplayMessage();  

            //baseObj = new DerivedClass2();
            //baseObj.DisplayMessage();  

            //DerivedClass2 obj2 = new DerivedClass2();
            //obj2.DisplayMessage();
            #endregion

            // Part 2
            #region Q1
            //Duration d1 = new Duration();               
            //Duration d2 = new Duration(10, 45, 20);       

            //d1.Display();
            //d2.Display();
            #endregion

            #region Q3

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());


            //D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());


            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());


            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            #endregion

            #region Q4
        //    Duration D1 = new Duration(1, 10, 15);
        //    Duration D2 = new Duration(7800); 

        //    Duration D3;

        //    D3 = D1 + D2;
        //    Console.WriteLine(D3);

        //    D3 = D1 + 7800;
        //    Console.WriteLine(D3);

        //    D3 = 666 + D3;
        //    Console.WriteLine(D3);

        //    D3 = ++D1;
        //    Console.WriteLine(D3);

        //    D3 = --D2;
        //    Console.WriteLine(D3);

        //    D1 = D1 - D2;
        //    Console.WriteLine(D1);

        //    if (D1 > D2)
        //        Console.WriteLine("D1 is greater than D2");
        //    else if (D1 <= D2)
        //        Console.WriteLine("D1 is less than or equal to D2");

        //    if (D1)
        //        Console.WriteLine("D1 is non-zero");
        //    else
        //        Console.WriteLine("D1 is zero");

        //    DateTime dt = (DateTime)D1;
        //    Console.WriteLine(dt.ToLongTimeString());
        //}
        #endregion



    }
    }
}

// Part 1

#region Class Q1
//public class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//}
#endregion

#region Class Q2
//public class Rec
//{
//    public int W { get; set; }
//    public int H { get; set; }
//    public Rec()
//    {
//        W = 0;
//        H = 0;
//    }

//    public Rec(int w, int h)
//    {
//        W = w;
//        H = h;
//    }
//    public Rec(int size)
//    {
//        W = size;
//        H = size;
//    }
//    public int ClacArea()
//    {
//        return W * H;
//    }
//}
#endregion


#region Class Q4
//public class Employee
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("Employee is working");
//    }
//}
//class Manager : Employee
//{
//    public override void Work()
//    {
//        base.Work();
//        Console.WriteLine("Manager is managing");
//    }
//}
#endregion

#region Class Q5
//public class BaseClass
//{
//    public virtual void DisplayMessage()
//    {
//        Console.WriteLine("Message from BaseClass");
//    }
//}

//public class DerivedClass1 : BaseClass
//{
//    public override void DisplayMessage()
//    {
//        Console.WriteLine("DerivedClass1!");
//    }
//}
//public class DerivedClass2 : BaseClass
//{
//    public new void DisplayMessage()
//    {
//        Console.WriteLine("DerivedClass2");
//    }
//}
#endregion


// Part 2

#region Part 2
//public class Duration
//{
//    public int H { get; set; }
//    public int M { get; set; }
//    public int S { get; set; }

//    public Duration()
//    {
//        H = 0;
//        M = 0;
//        S = 0;
//    }

//    public Duration(int h, int m, int s)
//    {
//        H = h;
//        M = m;
//        S = s;
//        Normalize();
//    }
//    public void Display()
//    {
//        Console.WriteLine($"{H}h {M}m {S}s");
//    }
//    public Duration(int totalSs)
//    {
//        H = totalSs / 3600;
//        int r = totalSs % 3600;
//        M = r / 60;
//        S = r % 60;
//    }

//    public override string ToString()
//    {
//        string res = "";
//        if (H > 0)
//            res += H;
//        if (M > 0 || H > 0)
//            res += M;
//        res += S;
//        return res;
//    }


//    private void Normalize()
//    {
//        int total = ToSeconds();
//        H = total / 3600;
//        int rem = total % 3600;
//        M = rem / 60;
//        S = rem % 60;
//    }
//    public int ToSeconds()
//    {
//        return H * 3600 + M * 60 + S;
//    }

//    // +
//    public static Duration operator +(Duration d1, Duration d2)
//    {
//        return new Duration(d1.ToSeconds() + d2.ToSeconds());
//    }
//    public static Duration operator +(Duration d, int seconds)
//    {
//        return new Duration(d.ToSeconds() + seconds);
//    }

//    public static Duration operator +(int seconds, Duration d)
//    {
//        return new Duration(d.ToSeconds() + seconds);
//    }

//    // -
//    public static Duration operator -(Duration d1, Duration d2)
//    {
//        return new Duration(d1.ToSeconds() - d2.ToSeconds());
//    }

//    // ++
//    public static Duration operator ++(Duration d)
//    {
//        return new Duration(d.ToSeconds() + 1);
//    }

//    // --
//    public static Duration operator --(Duration d)
//    {
//        return new Duration(d.ToSeconds() - 1);
//    }
//    public static bool operator >(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() > d2.ToSeconds();
//    }

//    public static bool operator <(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() < d2.ToSeconds();
//    }

//    public static bool operator >=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() >= d2.ToSeconds();
//    }

//    public static bool operator <=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() <= d2.ToSeconds();
//    }

//    public static bool operator true(Duration d)
//    {
//        return d.ToSeconds() > 0;
//    }

//    public static bool operator false(Duration d)
//    {
//        return d.ToSeconds() == 0;
//    }
//    public static explicit operator DateTime(Duration d)
//    {
//        return new DateTime(1, 1, 1, d.H, d.M, d.S);
//    }

//    public override bool Equals(object obj)
//    {
//        return obj is Duration other && this.ToSeconds() == other.ToSeconds();
//    }

//    public override int GetHashCode()
//    {
//        return ToSeconds().GetHashCode();
//    }

//}
#endregion