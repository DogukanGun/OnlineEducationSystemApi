using Hocam.Core.Service.Modules.Quiz;
using Hocam.Core.Service.Models;
 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hocam.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        readonly IQuizService _quizService;
        readonly IMapper _mapper;

        public QuizController(IQuizService quizService,IMapper mapper)
        {
            _quizService = quizService;
            _mapper = mapper;
        }


        // GET api/<QuizController>/all
        [HttpGet("all")]
        public List<QuizModel> GetAllQuizes()
        {
            return _quizService.GetAll();
        }

        // POST api/<QuizController>
        [HttpPost]
        public void SaveQuiz([FromBody] QuizModel quizModel)
        {
            _quizService.AddQuiz(quizModel);
        }

        // GET api/<QuizController>/teacher/id
        [HttpGet("teacher/{id}")]
        public List<QuizModel> GetTeacherQuizes(string id)
        {
            return _quizService.GetTeacherQuizes(id);
        }

        [HttpGet("{id}")]
        public QuizModel GetQuiz(string id)
        {
            return _quizService.GetQuiz(id);
        }
        [HttpGet("subject/{id}")]
        public List<QuizModel> GetSubjectQuiz(string id)
        {
            return _quizService.GetSubjectQuizes(id);
        }

        // DELETE api/<QuizController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _quizService.DeleteQuiz(id);
        }

        [HttpPost("update")]
        public void Update([FromBody]QuizModel quizModel)
        {
            _quizService.UpdateQuiz(quizModel);
        }
    }
}
