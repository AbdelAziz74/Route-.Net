using System;
class Product
{
    public string Name { get; set; }
}
namespace Demo
{

    
    class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Console.WriteLine("Please Enter a Number");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine($"You Number: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please Enter a number");
            //}
            #endregion

            #region Q2
            //string s = "74zoz";
            //if (int.TryParse(s, out int res))
            //{
            //    Console.WriteLine("Converted number: " + res);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid formatint");
            //}


            #endregion

            #region Q3
            //float num1 = 12.6f;
            //float num2 = 4.3f;

            //Console.WriteLine("Addition: " + num1 + num2);
            //Console.WriteLine("product: " + num1 * num2);
            #endregion

            #region Q4
            //string s = "AbdelAziz";
            //string sub = s.Substring(5, 4);
            //Console.WriteLine("Substring: " + sub);
            #endregion

            #region Q5
            //int a = 5;
            //int b = a; // correct
            //b = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region Q6
            Product p1 = new Product();
            p1.Name = "Product 1";
            Product p2 = new Product();
            p2 = p1;
            p2.Name = "Product 2";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
            #endregion

            #region Q7
            //Console.Write("please enter the first string: ");
            //string s1 = Console.ReadLine();
            //Console.Write("please enter the second string: ");
            //string s2 = Console.ReadLine();
            //Console.WriteLine(s1+s2);
            #endregion

            #region Q8
            #endregion

            #region Q9
            #endregion


            #region Q10
            #endregion

        }
    }
}