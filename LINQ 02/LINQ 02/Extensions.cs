using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_02
{
    internal static class Extensions
    {
        public static void Print(this object obj) => Console.WriteLine(obj);

        public static void Print<T>(this IEnumerable<T> collection)
        {
            ArgumentNullException.ThrowIfNull(collection);

            if(collection is string s)
               Console.WriteLine(s);

            else
                foreach (var value in collection)
                {
                    if(value is IEnumerable<object> objects)
                        foreach (var item in objects)
                            Console.WriteLine(item);
                    else
                        Console.WriteLine(value);
                }
        }
    }
}
