using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Service.Modules.Lesson
{
    public interface ILessonService
    {
        void AddLesson(LessonModel lessonModel);
        void DeleteLesson(string tag);
        LessonModel GetLesson(string tag);
        List<LessonModel> GetLessons();
        void UpdateLesson(LessonModel lessonModel);


    }
}
