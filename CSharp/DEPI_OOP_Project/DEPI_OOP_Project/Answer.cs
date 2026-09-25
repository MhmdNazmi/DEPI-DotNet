using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP_Project
{
    /// <summary>
    /// Represents an answer for a question.
    /// </summary>
    public class Answer : ICloneable
    {
        /// <summary>
        /// Gets or sets the answer identifier.
        /// </summary>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets the answer text.
        /// </summary>
        public string AnswerText { get; set; }

        /// <summary>
        /// Initializes a new Answer object with data.
        /// </summary>
        /// <param name="answerId">Answer identifier.</param>
        /// <param name="answerText">Answer text.</param>
        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text ?? throw new ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new Answer object.
        /// </summary>
        public Answer() : this(0, "no answer") { }

        public object Clone()
            => new Answer(AnswerId, AnswerText);

        public override string ToString()
            => $"{AnswerId}- {AnswerText}";
    }
}
