namespace OOPExam.Models
{
    public class MCQAndChoices : Question
    {
        public MCQAndChoices()
        {
            AnswerList = new Answer[3]; 
            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i] = new Answer();
            }
        }
    }
}
