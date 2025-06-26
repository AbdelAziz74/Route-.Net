using System;
using System.ComponentModel;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Q1
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");

            #endregion

            #region Q2
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine((num2 >= 0 ) ? "positive" : "negative");
            #endregion

            #region Q3
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int mx = a, mn = c;
            //if (a >= b && a >= c) mx = a; 
            //else if (b >= a && b >= c) mx = b;
            //else mx = c;

            //if (a <= b && a <= c) mn = a;
            //else if (b <= a && b <= c) mn = b;
            //else mn = c;
            //Console.WriteLine("Max =: "+ mx);
            //Console.WriteLine("Min =: "+ mn);

            #endregion

            #region Q4
            // int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine((num3 % 2 == 0 ) ? "even" : "odd");

            #endregion

            #region Q5
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') ? "vowel": "consonant");
            #endregion

            #region Q6
            //int num4 = int.Parse(Console.ReadLine());
            //if (num4 < 0)
            //{
            //    Console.WriteLine("Invalid input");
            //    return;
            //}
            //for (int i = 1; i <= num4; i++) Console.Write(i + " ");

            #endregion

            #region Q7
            //int num5 = int.Parse(Console.ReadLine());
            //if (num5 < 0)
            //{
            //    Console.WriteLine("Invalid input");
            //    return;
            //}
            //for (int i = 1; i <= 12; i++) Console.WriteLine(num5 * i);

            #endregion

            #region Q8
            //int num5 = int.Parse(Console.ReadLine());
            //if (num5 < 0)
            //{
            //    Console.WriteLine("Invalid input");
            //    return;
            //}
            //for (int i = 1; i <= num5; i++)
            //{
            //    if (i % 2 == 0) Console.Write(i + " ");
            //}

            #endregion

            #region Q9
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 1; i <= m; i++) {
            //    res *= n;
            //}
            //Console.WriteLine(res);
            #endregion

            #region Q10
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //int n4 = int.Parse(Console.ReadLine());
            //int n5 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Total marks =" + (n1+n2+n3+n4+n5));
            //Console.WriteLine("Average marks =" + ((n1 + n2 + n3 + n4 + n5) / 5));

            #endregion

            #region Q11
            //int x = int.Parse(Console.ReadLine());
            //int d;
            //if (x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12)  d = 31;
            //else if (x == 4 || x == 6 || x == 9 || x == 11) d = 30;
            //else if (x == 2) d = 28;
            //else
            //{
            //    Console.WriteLine("Invalid month");
            //    return;
            //}
            //Console.WriteLine(d);
            #endregion

            #region Q12
            //int s = int.Parse(Console.ReadLine());
            //for (int i = 0; i < s; i++)
            //{
            //    for (int j = 0; j < s; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q13
            //int number = int.Parse(Console.ReadLine());
            //int[] arr = new int[number];
            //int sum = 0;
            //for (int i = 0; i < number; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Q14
            //int  num= int.Parse(Console.ReadLine());
            //int[] arr = new int[num];
            //int[] counter = new int[num]; 
            //int vis = -1;

            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < num; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            counter[j] = vis; 
            //        }
            //    }

            //    if (counter[i] != vis)
            //    {
            //        counter[i] = count;
            //    }
            //}
            //for (int i = 0; i < num; i++)
            //{
            //    if (counter[i] != vis)

            //        Console.WriteLine($"{arr[i]} appears {counter[i]} time(s)");
            //}
            #endregion

            #region Q15
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion

            #region Q16
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine(arr[3]);
            #endregion
        }
    }
   
}
