using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Models
{
    public class QuizModel
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Topic { get; set; }
        public List<QuestionModel> Questions { get; set; }
        public bool IsDeleted { get; set; }
        public string TeacherName { get; set; }

    }
}
