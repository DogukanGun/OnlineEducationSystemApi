using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Data.Documents
{
    [BsonCollection("lesson")]
    public class LessonDocument:Document
    {
        public string LessonName { get; set; }
        public string Tag { get; set; }
        public string LessonDescription { get; set; }
        public List<QuestionDocument> ExampleQuestions { get; set; }
        public FileDocument LessonVideo { get; set; }
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
        public string TeacherName { get; set; }


    }
}
