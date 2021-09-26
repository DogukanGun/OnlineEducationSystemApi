using Hocam.Core.Service.Models;
using Hocam.Core.Service.Modules.Lesson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        readonly ILessonService _lessonService;
        
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        [HttpGet]
        public List<LessonModel> GetLessons()
        {
            return _lessonService.GetLessons();
        }

        [HttpGet("{id}")]
        public LessonModel GetLesson(string id)
        {
            return _lessonService.GetLesson(id);
        }

        [HttpDelete("{id}")]
        public void DeleteLesson(string id)
        {
            _lessonService.DeleteLesson(id);
        }

        [HttpPost]
        public void AddLesson([FromBody] LessonModel lessonModel)
        {
            _lessonService.AddLesson(lessonModel);
        }

        [HttpPost("update")]
        public void UpdateLesson([FromBody] LessonModel lessonModel)
        {
            _lessonService.UpdateLesson(lessonModel);
        }
    }
}
