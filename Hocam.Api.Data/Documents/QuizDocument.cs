using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Data
{
    [BsonCollection("quiz")]
    public class QuizDocument : Document
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Topic { get; set; }
        public List<QuestionDocument> Questions { get; set; }
        public bool IsDeleted { get; set; }
        public string TeacherName { get; set; }


    }
}
