using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Models
{
    public class QuestionModel
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public FileModel QuestionSolution { get; set; }
        public List<QuestionOptionModel> QuestionOptions { get; set; }
        public QuestionHintModel QuestionHint { get; set; }
    }
}
