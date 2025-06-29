using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Q1
            //While Passing The Parameter it takes A copy of Variable
            // Any changes made inside the Fuction will not affect the original variable.
            //void PassByValue(int x)
            //{
            //    x = 10;
            //}
            #endregion

            #region Q2  
            //Passing the parameter by reference allows the function to modify the original variable.
            //void PassByReference(ref int x)
            //{
            //    x = 10;
            //}
            #endregion

            #region Q3
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //Functions.Fun(a,b, c, d);
            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("The sum of the digits of the number " + n + " is: " + Functions.SumOfDigits(n));

            #endregion

            #region Q5
            //Console.Write("Enter a number to check if it is prime: ");
            //int number = int.Parse(Console.ReadLine());
            //Functions.IsPrime(number);



            #endregion

            #region Q6
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int min = 0, max = 0;

            //Functions.NinMax(arr, ref min, ref max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region Q7
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Functions.Factorial(number));
                
            #endregion



        }


    }
}
public class Functions
{
    // Functino Q3
    public static void Fun(int a, int b, int c, int d)
    {
        int sum = a + b;
        int sub = c - d;
        Console.WriteLine(sum);
        Console.WriteLine(sub);
    }
    // Functino Q4
    public static int SumOfDigits(int x)
    {
        int sum = 0;
        while (x > 0)
        {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }
    // Functino Q5
    public static int IsPrime(int num)
    {
        int x = 0;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                x = 1;
        }
        Console.WriteLine((x == 1) ? "True" : "False");
        return x;

    }

    // Function Q6

    public static void NinMax(int[] arr, ref int min, ref int max)
    {
        if (arr.Length == 0)
        {
            min = 0;
            max = 0;
            return;
        }
        min = arr[0];
        max = arr[0];
        foreach (int num in arr)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        ref int minn = ref min;
        ref int maxx = ref max;
        Console.WriteLine(minn);
        Console.WriteLine(maxx);
    }

    public static long Factorial(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
    }

