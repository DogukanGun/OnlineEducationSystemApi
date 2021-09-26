using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Service.Models
{
    public class LessonModel
    {
        public string LessonName { get; set; }
        public string Tag { get; set; }
        public string LessonDescription { get; set; }
        public List<QuestionModel> ExampleQuestions { get; set; }
        public FileModel LessonVideo { get; set; }
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
        public string TeacherName { get; set; }


    }
}
