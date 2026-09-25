using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        /// <summary>
        /// Gets or sets the question header.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the question body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the question mark.
        /// </summary>
        public int Mark {  get; set; }

        /// <summary>
        /// Gets or sets the available answers.
        /// </summary>
        public Answer[] AnswerList { get; set; }

        /// <summary>
        /// Gets or sets the correct answer.
        /// </summary>
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        protected Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
            : this (header, body, mark)
        {
            AnswerList = answerList;
            RightAnswer = rightAnswer;  
        }

        public virtual void Display()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            if (AnswerList != null)
            {
                foreach (Answer answer in AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }
        }

        public int CompareTo(Question q)
        {
            if (q == null) return 1;
            return Mark.CompareTo(q.Mark);
        }

        public abstract object Clone();

        public override string ToString() 
            => $"{Header} - {Body} ({Mark} Marks)";
    }
}
