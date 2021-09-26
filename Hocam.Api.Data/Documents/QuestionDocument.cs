using System.Collections.Generic;

namespace Hocam.Core.Data
{
    public class QuestionDocument
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public FileDocument QuestionSolution { get; set; }
        public List<QuestionOptionDocument> QuestionOptions { get; set; }
        public QuestionHintDocument QuestionHint { get; set; }
    }
}