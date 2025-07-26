namespace AvdC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] nums = { 3, 2, 1, 4, 5 };
            //BubbleSort(nums);
            //Console.WriteLine(string.Join(", ", nums));
            #endregion

            #region Q2
            //var intRange = new Range<int>(10, 20);
            //Console.WriteLine(intRange.IsInRange(15));     
            //Console.WriteLine(intRange.IsInRange(25));    
            //Console.WriteLine(intRange.Length());          
            //var doubleRange = new Range<double>(5.5, 9.3);
            //Console.WriteLine(doubleRange.Length());       
            #endregion
        }
        #region  FunQ1
        //public static void BubbleSort(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        bool swapped = false;
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        //                swapped = true;
        //            }
        //        }
        //        if (!swapped)
        //            break;
        //    }
        //}
        #endregion

        #region FunQ2
        //public class Range<T> where T : IComparable<T>
        //{
        //    public T Min { get; }
        //    public T Max { get; }
        //    public Range(T min, T max)
        //    {
        //        if (min.CompareTo(max) > 0)
        //            throw new ArgumentException(" pls Min must be less than or equal to max.");

        //        Min = min;
        //        Max = max;
        //    }
        //    public bool IsInRange(T value)
        //    {
        //        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        //    }
        //    public dynamic Length()
        //    {
        //        return (dynamic)Max - (dynamic)Min;
        //    }
        //    public override string ToString() => $"[{Min} to {Max}]";
        //}
        #endregion

    }
}



