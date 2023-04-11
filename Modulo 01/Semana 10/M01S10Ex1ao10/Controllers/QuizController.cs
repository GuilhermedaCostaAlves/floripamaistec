using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.QuizDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;


[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly IQuizRepository _quizRepository;


    public QuizController(IQuizRepository QuizRepository)
    {
        _quizRepository = QuizRepository;
    }

    [HttpPost]
    public ActionResult<Quiz> Create(Quiz quiz)
    {
        _quizRepository.Create(quiz);

        return CreatedAtAction(nameof(QuizController), new { id = quiz.Id }, quiz);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterQuizDto QuizDto)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        quiz.DisciplineId = QuizDto.DisciplineId;
        quiz.Title = QuizDto.Title;

        return CreatedAtAction(nameof(QuizController.Get), new { id = quiz.Id }, quiz);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var quiz = _quizRepository.List();
        return Ok(quiz);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        return Ok(quiz);
    }


    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuiz(int id)
    {
        var quiz = _quizRepository.GetById(id);
        if (quiz == null)
        {
            return NotFound();
        }

        _quizRepository.Delete(id);

        return NoContent();
    }
}