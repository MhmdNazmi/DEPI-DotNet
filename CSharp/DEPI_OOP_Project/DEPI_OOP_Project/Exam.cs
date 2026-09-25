using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    /// <summary>
    /// Represents the base class for all exams.
    /// </summary>
    public abstract class Exam : ICloneable
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        protected Exam() { }

        protected Exam(int time, int numberOfQuestions)
        {
            TimeOfExam = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();
        public abstract object Clone();
        public override string ToString()
            => $"Time: {TimeOfExam} Minutes, Questions: {NumberOfQuestions}";
    }
}
