
namespace OOPExam
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public abstract void ShowExam();
    }
}
