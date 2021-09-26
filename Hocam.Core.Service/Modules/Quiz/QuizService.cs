using AutoMapper;
using Hocam.Core.Data;
using Hocam.Core.Data.Repositories;
using Hocam.Core.Service.Constants;
using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Modules.Quiz
{
    public class QuizService : IQuizService
    {
        readonly IQuizRepository _quizRepository;
        readonly IMapper _mapper;
        readonly IContextResolver _contextResolver;

        public QuizService(IQuizRepository quizRepository,IMapper mapper,IContextResolver contextResolver)
        {
            _quizRepository = quizRepository;
            _mapper = mapper;
            _contextResolver = contextResolver;
        }
        public void AddQuiz(QuizModel quizModel)
        {
            var quizDocument = _mapper.Map<QuizDocument>(quizModel);
            quizDocument.Tag = Guid.NewGuid().ToString();
            quizDocument.TeacherName = _contextResolver.GetUsername();
            _quizRepository.InsertOne(quizDocument);
        }

        public List<QuizModel> GetAll()
        {
            return _mapper.Map<List<QuizModel>>(_quizRepository.FilterBy(x => x.Status == QuizStatus.ACTIVE).ToList());
        }

        public List<QuizModel> GetTeacherQuizes(string teacherId)
        {
            return _mapper.Map<List<QuizModel>>(_quizRepository.FilterBy(x => x.CreatedBy == teacherId).ToList());

        }

        public List<QuizModel> GetSubjectQuizes(string subject)
        {
            if (subject.ToUpper().Contains(SubjectStatus.MATH))
            {
                return _mapper.Map<List<QuizModel>>(_quizRepository.FilterBy(x => x.Topic == SubjectStatus.MATH).ToList());

            }
            else if (subject.ToUpper().Contains(SubjectStatus.TURKISH))
            {
                return _mapper.Map<List<QuizModel>>(_quizRepository.FilterBy(x => x.Topic == SubjectStatus.TURKISH).ToList());
            }
            else
            {
                throw new ArgumentNullException("Bu tipde ders yok");
            }

        }

        public QuizModel GetQuiz(string id)
        {
            return _mapper.Map<QuizModel>(_quizRepository.FindOne(x => x.Tag == id));
        }

        public void DeleteQuiz(string id)
        {
            var quiz = _quizRepository.FindOne(x=>x.Tag==id);
            quiz.IsDeleted = true;
            _quizRepository.ReplaceOne(quiz);
        }

        public void UpdateQuiz(QuizModel quizModel)
        {
            _quizRepository.ReplaceOne(_mapper.Map<QuizDocument>(quizModel));
        }
    }
}
