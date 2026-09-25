using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    public class McqQuestions : Question
    {
        public McqQuestions(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public McqQuestions(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override object Clone()
        {
            return new McqQuestions(Header, Body, Mark);
        }

        public override string ToString() 
            => $"{Header} - {Body} ({Mark} Marks)";
    }
}
