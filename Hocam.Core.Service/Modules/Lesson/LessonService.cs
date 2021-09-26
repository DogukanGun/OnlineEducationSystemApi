using AutoMapper;
using Hocam.Core.Data.Documents;
using Hocam.Core.Data.Repositories;
using Hocam.Core.Service.Constants;
using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hocam.Core.Service.Modules.Lesson
{
    public class LessonService : ILessonService
    {
        readonly ILessonRepository _lessonRepository;
        readonly IMapper _mapper;
        readonly IContextResolver _contextResolver;

        public LessonService(ILessonRepository lessonRepository,IMapper mapper,IContextResolver contextResolver)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
            _contextResolver = contextResolver;
        }
        public void AddLesson(LessonModel lessonModel)
        {
            var lessonDocument = _mapper.Map<LessonDocument>(lessonModel);
            lessonDocument.Tag=Guid.NewGuid().ToString();
            lessonDocument.TeacherName = _contextResolver.GetUsername();
            _lessonRepository.InsertOne(lessonDocument);
        }

        public void DeleteLesson(string tag)
        {
            var lesson = _lessonRepository.FindOne(x=>x.Tag==tag);
            lesson.IsDeleted = true;
            _lessonRepository.ReplaceOne(lesson);
        }

        public LessonModel GetLesson(string tag)
        {
            return _mapper.Map<LessonModel>(_lessonRepository.FindOne(x => x.Tag == tag));
        }

        public List<LessonModel> GetLessons()
        {
            
            return _mapper.Map<List<LessonModel>>(_lessonRepository.FilterBy(x => x.Status == LessonStatus.ACTIVE).ToList());
        }

        public void UpdateLesson(LessonModel lessonModel)
        {
            _lessonRepository.ReplaceOne(_mapper.Map<LessonDocument>(lessonModel));
        }
    }
}
