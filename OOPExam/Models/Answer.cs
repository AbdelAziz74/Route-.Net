namespace OOPExam.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer()
        {
            AnswerId = 0;
            AnswerText = string.Empty;
        }
    }
}
