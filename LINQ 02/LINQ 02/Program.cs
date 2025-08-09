namespace LINQ_02;
class Program
{
    static void Main()
    {
        /// LINQ - Element Operators

        #region Q1
        //Console.WriteLine( ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0) );
        #endregion

        #region Q2
        //Console.WriteLine(ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000) ); 

        #endregion    }

        #region Q3
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //Console.WriteLine(Arr.Where(n => n > 5).Skip(1).FirstOrDefault());

        #endregion

        // LINQ - Aggregate Operators

        #region Q1

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //Console.WriteLine(Arr.Count(n => n % 2 != 0) ); 
        #endregion

        #region Q2
        //ListGenerators.CustomerList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count(o => o != null) }).Print();

        #endregion

        #region Q3
        //ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Count = g.Count() }).Print();

        #endregion

        #region Q4
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //Console.WriteLine(Arr.Sum());
        #endregion;

        #region Q5
        string[] Dictionary = File.ReadAllLines("dictionary_english.txt");

        //Console.WriteLine(Dictionary.Sum(w => w.Length) ); 
        #endregion

        #region Q6
        //Console.WriteLine(Dictionary.Min(w => w.Length) );

        #endregion

        #region Q7
        //Console.WriteLine(Dictionary.Max(w => w.Length) );

        #endregion

        #region Q8
        //Console.WriteLine(Dictionary.Average(w => w.Length) );

        #endregion

        #region Q9

        // ListGenerators.ProductList
        //.GroupBy(p => p.Category)
        //.Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.UnitsInStock) } ).Print(); 
        #endregion

        #region Q10
        // ListGenerators.ProductList
        //.GroupBy(p => p.Category)
        //.Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) }).Print(); 
        #endregion

        #region Q12
        //ListGenerators.ProductList
        //.GroupBy(p => p.Category)
        //.Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) }).Print();  
        #endregion

        #region Q14
        //ListGenerators.ProductList
        //.GroupBy(p => p.Category)
        //.Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) }) .Print(); 
        #endregion


        // LINQ - Set Operators

        #region Q1
        //ListGenerators.ProductList.Select(p => p.Category).Distinct().Print(); 
        #endregion

        #region Q2
        //var product = ListGenerators.ProductList.Select(p => p.ProductName[0]);
        //var customer = ListGenerators.CustomerList.Select(c => c.CustomerName[0]);

        //var Union = product.Union(customer);
        //foreach (var c in Union)
        //    Console.WriteLine(c);
        #endregion

        #region Q3
        //foreach (var ch in product.Intersect(customer))
        //    Console.WriteLine(ch);

        #endregion

        #region Q4
        //foreach (var ch in product.Except(customer) ) Console.WriteLine(ch);

        #endregion

        #region Q5
        // ListGenerators.ProductList
        //.Select(p => p.ProductName)
        //.Concat(ListGenerators.CustomerList.Select(c => c.CustomerName))
        //.Select(name => name.Length >= 3 ? name.Substring(name.Length - 3) : name).Print(); 
        #endregion


        // LINQ - Partitioning Operators

        #region Q1
        // ListGenerators.CustomerList
        //.Where(c => c.Region == "WA").SelectMany(c => c.Orders)
        //.Where(o => o != null).Take(3).Print(); 
        #endregion

        #region Q2
        // ListGenerators.CustomerList.Where(c => c.Region == "WA")
        //.SelectMany(c => c.Orders).Where(o => o != null).Skip(2).Print(); 
        #endregion

        #region Q3
        //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //nums.TakeWhile((num, index) => num >= index).Print(); 
        #endregion

        #region Q4
        //nums.SkipWhile(n => n % 3 != 0).Print();

        #endregion

        #region Q5
        //nums.SkipWhile((num, index) => num >= index).Print();

        #endregion


        /// LINQ - Quantifiers

        #region Q1
        //Console.WriteLine(Dictionary.Any(word => word.Contains("ei")) ? " True" : " False");

        #endregion


        /// LINQ – Grouping Operators

        #region Q1

        //List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


        //foreach (var group in nums.GroupBy(n => n % 5).OrderBy(g => g.Key))
        //{
        //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
        //    foreach (var num in group)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Q2
        //foreach (var gro in Dictionary.Where(w => !string.IsNullOrWhiteSpace(w)).GroupBy(w => char.ToUpper(w[0]))
        //.OrderBy(g => g.Key))
        //{
        //    Console.WriteLine($"Words starting with '{gro.Key}':");
        //    foreach (var w in gro.Take(10)) 
        //    {
        //        Console.WriteLine(w);
        //    }
        //    Console.WriteLine();
        //} 
        #endregion

        #region Q3
        //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

        //foreach (var group in Arr.Select(word => word.Trim()).GroupBy(word => String.Concat(word.OrderBy(c => c))).Where(group => group.Count() > 1))
        //{
        //    foreach (var w in group)
        //    {
        //        Console.WriteLine(w);
        //    }
        //    Console.WriteLine("....");
        //}

        #endregion

        /// LINQ – Transformation Operators

        #region Q1
        //ListGenerators.ProductList.Select(p => p.ProductName).Print();

        #endregion

        #region Q2
        //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        //var transforming = words.Select(w => new
        //{
        //    Upper = w.ToUpper(),
        //    Lower = w.ToLower()
        //});

        //foreach (var word in transforming)
        //{
        //    Console.WriteLine($"{word.Upper} => {word.Lower}");
        //} 
        #endregion

        #region Q3
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var res = Arr.Select((value, index) => new {
        //    Number = value,
        //    RightIndeced = value == index
        //});

        //foreach (var item in res)
        //{
        //    Console.WriteLine($"{item.Number}: {item.RightIndeced}");
        //} 
        #endregion

    }

}


















