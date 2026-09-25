namespace DEPI_OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject =
                new Subject(1, "Object Oriented Programming");

            FinalExam finalExam = new FinalExam(60, 2);

            TrueFalseQuestion q1 =
                new TrueFalseQuestion(
                    "True / False",
                    "C# is an OOP language.",
                    5);

            q1.RightAnswer = q1.AnswerList[0];

            McqQuestions q2 =
                new McqQuestions(
                    "MCQ",
                    "Which keyword is used for inheritance?",
                    10);

            q2.AnswerList = new Answer[]
            {
                new Answer(1,"implement"),
                new Answer(2,"inherits"),
                new Answer(3,"base"),
                new Answer(4,":")
            };

            q2.RightAnswer = q2.AnswerList[3];

            finalExam.Questions[0] = q1;
            finalExam.Questions[1] = q2;

            subject.CreateExam(finalExam);

            Console.WriteLine($"Subject: {subject.SubjectName}");
            Console.WriteLine();

            subject.SubjectExam.ShowExam();
        }
    }
}
