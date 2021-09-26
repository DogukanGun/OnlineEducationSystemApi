using AutoMapper;
using Hocam.Core.Data;
using Hocam.Core.Data.Documents;
using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Configurations
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<FileModel, FileDocument>();
            CreateMap<FileDocument, FileModel>();

            CreateMap<QuestionHintDocument, QuestionHintModel>();
            CreateMap<QuestionHintModel, QuestionHintDocument>();

            CreateMap<QuestionModel, QuestionDocument>();
            CreateMap<QuestionDocument, QuestionModel>();

            CreateMap<QuestionOptionModel, QuestionOptionDocument>();
            CreateMap<QuestionOptionDocument, QuestionOptionModel>();

            CreateMap<QuizDocument, QuizModel>();
            CreateMap<QuizModel, QuizDocument>();

            CreateMap<UserDocument, UserModel>();
            CreateMap<UserModel, UserDocument>();

            CreateMap<LessonDocument, LessonModel>();
            CreateMap<LessonModel, LessonDocument>();
        }
    }
}
