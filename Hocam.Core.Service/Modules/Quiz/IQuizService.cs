using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Modules.Quiz
{
    public interface IQuizService
    {
        void AddQuiz(QuizModel quizModel);
        List<QuizModel> GetAll();
        List<QuizModel> GetTeacherQuizes(string teacherId);
        List<QuizModel> GetSubjectQuizes(string subject);
        QuizModel GetQuiz(string id);
        void DeleteQuiz(string id);
        void UpdateQuiz(QuizModel quizModel);
    }
}
