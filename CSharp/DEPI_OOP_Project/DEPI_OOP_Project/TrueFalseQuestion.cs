using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            AnswerList = new Answer[]
            {
              new Answer(1, "True"),
              new Answer(2, "False")
            };
        }
        public TrueFalseQuestion(string header, string body, int mark, Answer rightAnswer)
            : base(header, body, mark)
        {
            AnswerList = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
            RightAnswer = rightAnswer;
        }

        public TrueFalseQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
            : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override object Clone()
            => new TrueFalseQuestion(Header, Body, Mark, RightAnswer);

        public override string ToString() 
            => $"{Header} - {Body} ({Mark} Marks)";
    }
}
