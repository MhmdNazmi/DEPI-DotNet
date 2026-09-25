using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    public class FinalExam : Exam
    {

        /// <summary>
        /// Represents a final exam.
        /// </summary>
        public FinalExam() : this(0, 0) { }

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("---- Final Exam ----");

            int totalMarks = 0;

            foreach (Question q in Questions)
            {
                q.Display();

                Console.WriteLine($"Question Grade = {q.Mark}");

                totalMarks += q.Mark;

                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine($"Total Grade = {totalMarks}");
        }

        public override object Clone() 
            => new FinalExam(TimeOfExam, NumberOfQuestions);
    }
}
