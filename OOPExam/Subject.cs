
using OOPExam.Models;

namespace OOPExam
{

    public class Subject : Exam
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam exam { get; set; }

        int TypeOfExam, TimeOfExam, NumberOfQuestions, typeOfQuestion;


        List<Question> questions = new List<Question>();
        List<int> answeruser = new List<int>();
        DateTime startTime;
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam()
        {
            startTime = DateTime.Now;
            do
            {
                Console.WriteLine("Please Enter The Type Of Exam (1 for Practical | 2 for Final) ");

            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam));
            do
            {
                Console.WriteLine("Please Enter The Time For Exam From (30 min to 180 min))");
            } while (!int.TryParse(Console.ReadLine(), out TimeOfExam));

            do
            {
                Console.WriteLine("Please Enter The Number Of Questions");

            } while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions));



            Console.Clear();


            if (TypeOfExam == 2)
            {

                for (int i = 0; i < NumberOfQuestions; i++)
                {

                    do
                    {
                        Console.WriteLine($"Please Enter The Type Of Question (1 for MCQ | 2 For True | False ) ");
                    } while (!int.TryParse(Console.ReadLine(), out typeOfQuestion));


                    Console.Clear();

                    if (typeOfQuestion == 2)
                    {
                        TFQuestion tfQuestion = new TFQuestion();

                        Console.WriteLine("True | False Qusetion");
                        tfQuestion.Header = "True | False Qusetion";

                        do
                        {
                            Console.WriteLine("Please Enter Question Body");
                            tfQuestion.Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(tfQuestion.Body));


                        int mark;
                        do
                        {
                            Console.WriteLine("Please Enter Question Mark");

                        } while (!int.TryParse(Console.ReadLine(), out mark));

                        tfQuestion.Mark = mark;

                        int ans;
                        do
                        {

                            Console.WriteLine("Please Enter the right answer id (1 for true | 2 for false)");
                        } while (!int.TryParse(Console.ReadLine(), out ans));

                        tfQuestion.RightAnswer = ans;



                        questions.Add(tfQuestion);
                        Console.Clear();
                    }
                    else
                    {
                        MCQAndChoices mCQAndChoices = new MCQAndChoices();

                        Console.WriteLine("MCQ Question");
                        mCQAndChoices.Header = "MCQ Question";
                        Console.WriteLine("Please Enter Question Body");
                        mCQAndChoices.Body = Console.ReadLine();

                        int mark;
                        do
                        {
                            Console.WriteLine("Please Enter Question Mark");
                        } while (!int.TryParse(Console.ReadLine(), out mark));

                        mCQAndChoices.Mark = mark;

                        Console.WriteLine("Choices Of Question:");

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Please Enter The Choice Number {j + 1}");
                            string answer = Console.ReadLine();
                            mCQAndChoices.AnswerList[j].AnswerText = answer;
                        }

                        int rightChoice;
                        do
                        {
                            Console.WriteLine("Please Enter The right answer id ");
                        } while (!int.TryParse(Console.ReadLine(), out rightChoice) || rightChoice < 1 || rightChoice > 3);
                        mCQAndChoices.RightAnswer = rightChoice;

                        questions.Add(mCQAndChoices);
                        Console.Clear();
                    }
                }

            }
            else
            {
                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    MCQAndChoices mCQAndChoices = new MCQAndChoices();

                    Console.WriteLine("Choose One Answer Question");
                    mCQAndChoices.Header = "Choose One Answer Question";
                    Console.WriteLine("Please Enter Question Body");
                    mCQAndChoices.Body = Console.ReadLine();

                    int mark;
                    do
                    {
                        Console.WriteLine("Please Enter Question Mark");
                    } while (!int.TryParse(Console.ReadLine(), out mark));

                    mCQAndChoices.Mark = mark;

                    Console.WriteLine("Choices Of Question:");

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Please Enter The Choice Number {j + 1}:");
                        string answer = Console.ReadLine();
                        mCQAndChoices.AnswerList[j].AnswerText = answer;
                    }

                    int rightChoice;
                    do
                    {
                        Console.WriteLine("Please Enter The Right Choice of Question");
                    } while (!int.TryParse(Console.ReadLine(), out rightChoice) || rightChoice < 1 || rightChoice > 3);
                    mCQAndChoices.RightAnswer = rightChoice;

                    questions.Add(mCQAndChoices);
                    Console.Clear();
                }
            }
        }

        public override void ShowExam()
        {

            foreach (Question question in questions)
            {
                Console.WriteLine(question.Body);
                Console.WriteLine("                                                ");
                if (question.Header == "True | False Qusetion")
                {
                    Console.WriteLine("1-True"); Console.WriteLine("2-False");

                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"{i + 1}.{question.AnswerList[i].AnswerText}            ");
                    }
                }
                Console.WriteLine("Please Enter The answer Id");
                int answer = Convert.ToInt32(Console.ReadLine());
                answeruser.Add(answer);

            }

            Console.Clear();

            int grade = 0;
            int totalgrade = 0;

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1} {questions[i].Body}");

                string userAnswerText = questions[i] is TFQuestion
                    ? (answeruser[i] == 1 ? "True" : "False")
                    : questions[i].AnswerList[answeruser[i] - 1].AnswerText;

                string rightAnswerText = questions[i] is TFQuestion
                    ? (questions[i].RightAnswer == 1 ? "True" : "False")
                    : questions[i].AnswerList[questions[i].RightAnswer - 1].AnswerText;

                Console.WriteLine($"Your Answer => {userAnswerText}");
                Console.WriteLine($"Your Answer => {rightAnswerText}");

                if (questions[i].RightAnswer == answeruser[i])
                {
                    grade += questions[i].Mark;
                }

                totalgrade += questions[i].Mark;
            }


            Console.WriteLine($"Your Grade is {grade} from {totalgrade} ");
            DateTime endTime = DateTime.Now;
            TimeSpan elapsedTime = endTime - startTime;
            Console.WriteLine($"Time = {elapsedTime.TotalSeconds}");
            Console.WriteLine("Thank you");
        }
    }

}
