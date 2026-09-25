using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    public class PracticalExam : Exam
    {
        public PracticalExam() { }

        public PracticalExam(int time, int numerOfQuestions)
            : base(time, numerOfQuestions) 
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine(" ---- Practical Exam ----");

            foreach (Question q in Questions)
            {
                q.Display();

                Console.WriteLine();
                Console.WriteLine("Right Answer: " +
                                  q.RightAnswer.AnswerText);

                Console.WriteLine("---------------------------");
            }
        }

        public override object Clone() 
            => new PracticalExam(TimeOfExam, NumberOfQuestions);
    }
}
