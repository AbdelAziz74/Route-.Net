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
            string s = "74zoz";
            try
            {
                int res = Convert.ToInt32(s);
                Console.WriteLine(res);

            }
            catch(FormatException)
            {

            }

            #endregion
        }
    }
}