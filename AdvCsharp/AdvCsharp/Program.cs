using System.Collections;

namespace AdvCsharp
{
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Collections.Generic;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int n = int.Parse(Console.ReadLine());
            //int t = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //while (t > 0)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    int cnt = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (arr[i] > num)
            //            cnt++;
            //    }
            //    Console.WriteLine(cnt);
            //    t--;
            //}

            #endregion

            #region Q2
            //        string n = Console.ReadLine(); 

            //        for (int i = 0; i < n.Length; i++)
            //        {
            //            string zeros = new string('0', i);
            //            string x = zeros + n;

            //            char[] arr = x.ToCharArray();
            //            Array.Reverse(arr);
            //            string reversed = new string(arr);

            //            if (x == reversed)
            //            {
            //                Console.WriteLine("Yes");
            //                return;
            //            }
            //        }

            //        Console.WriteLine("No");
            //    }
            //}

            #endregion

            #region Q3
            //Queue<int> nums = new Queue<int>(new[] { 10, 20, 30, 40, 50 });
            //Queue.ReverseQueue(nums);
            //Console.WriteLine(string.Join(", ", nums)); 
            #endregion

            #region Q4
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Console.WriteLine(IsBalanced(input) ? "Yes" : "No");
            //}
            //static bool IsBalanced(string str)
            //{
            //    Stack<char> stack = new Stack<char>();

            //    foreach (char ch in str)
            //    {
            //        if (ch == '(' || ch == '[')
            //        {
            //            stack.Push(ch);
            //        }
            //        else if (ch == ')')
            //        {
            //            if (stack.Count == 0 || stack.Pop() != '(')
            //                return false;
            //        }
            //        else if (ch == ']')
            //        {
            //            if (stack.Count == 0 || stack.Pop() != '[')
            //                return false;
            //        }
            //    }

            //    return stack.Count == 0;
            //}
            #endregion

            #region Q5
            //string[] names = { "Ali", "Mona", "Ali", "Asnaa", "Sara" };
            //var uniqueNames = ArrayUtils.RemoveDuplicates(names);
            //Console.WriteLine(string.Join(", ", uniqueNames)); 
            //int[] numbers = { 1, 2, 2, 3, 1, 4 };
            //var uniqueNumbers = ArrayUtils.RemoveDuplicates(numbers);
            //Console.WriteLine(string.Join(", ", uniqueNumbers));

            #endregion

            #region Q6
            //ArrayList nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            //List.RemoveOddNums(nums);

            //foreach (var item in nums)
            //{
            //    Console.Write(item + " ");  
            //}

            #endregion

            #region Q7
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);          
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);      
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            #endregion

            #region Q9
            #endregion

            #region Q10
            //ArrayList nums = new ArrayList() { 10, 22, 31, 8, 15 };
            //int target = 12;
            //ArrayList res = sum.FindSublist(nums, target);
            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

        }
    } 
  
}

#region Q3 Fun
//public static class Queue
//{
//    public static void ReverseQueue<T>(Queue<T> queue)
//    {
//        Stack<T> stack = new Stack<T>();

//        while (queue.Count > 0)
//        {
//            stack.Push(queue.Dequeue());
//        }

//        while (stack.Count > 0)
//        {
//            queue.Enqueue(stack.Pop());
//        }
//    }
//}
#endregion

#region Q5 fun
//public static class ArrayUtils
//{
//    public static T[] RemoveDuplicates<T>(T[] array)
//    {
//        HashSet<T> seen = new HashSet<T>();
//        List<T> result = new List<T>();

//        foreach (T item in array)
//        {
//            if (seen.Add(item))
//            {
//                result.Add(item);
//            }
//        }

//        return result.ToArray();
//    }
//}
#endregion

#region Q6 fun
//public static class List
//{
//    public static void RemoveOddNums(ArrayList list)
//    {
//        for (int i = list.Count - 1; i >= 0; i--)
//        {
//            if (list[i] is int num && num % 2 != 0)
//            {
//                list.RemoveAt(i);
//            }
//        }
//    }
//}
#endregion

#region Q10 fun
//public static class sum
//{
//    public static ArrayList FindSublist(ArrayList list, int target)
//    {
//        int s = 0;
//        int sum = 0;

//        for (int e = 0; e < list.Count; e++)
//        {
//            if (!(list[e] is int))
//                continue; 

//            sum += (int)list[e];

//            while (sum > target && s < e)
//            {
//                sum -= (int)list[s];
//                s++;
//            }

//            if (sum == target)
//            {
//                ArrayList sublist = new ArrayList();
//                for (int i = s; i <= e; i++)
//                    sublist.Add(list[i]);

//                return sublist;
//            }
//        }
//        return new ArrayList(); 
//    }
//}
#endregion




