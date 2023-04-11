using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.QuestionDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionRepository _questionRepository;


    public QuestionController(IQuestionRepository QuestionRepository)
    {
        _questionRepository = QuestionRepository;
    }

    [HttpPost]
    public ActionResult<Question> Create(Question question)
    {
        _questionRepository.Create(question);

        return CreatedAtAction(nameof(QuestionController), new { id = question.Id }, question);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterQuestionDto QuestionDto)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        question.QuizId = QuestionDto.QuizId;
        question.Enunciation = QuestionDto.Enunciation;
        question.Weight = QuestionDto.Weight;

        return CreatedAtAction(nameof(QuestionController.Get), new { id = question.Id }, question);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var question = _questionRepository.List();
        return Ok(question);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        return Ok(question);
    }


    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuestion(int id)
    {
        var question = _questionRepository.GetById(id);
        if (question == null)
        {
            return NotFound();
        }

        _questionRepository.Delete(id);

        return NoContent();
    }
}