namespace OOPExam
{
     class Program
    {
        static void Main()
        {
            Subject subject = new Subject(12, "C#");

            subject.CreateExam();

            Console.WriteLine("Do you want to start Exam (Y/N)");
            string startExam = Console.ReadLine();

            if (startExam.ToUpper() == "Y")
            {
                subject.ShowExam();
            }
        }
    }
}
