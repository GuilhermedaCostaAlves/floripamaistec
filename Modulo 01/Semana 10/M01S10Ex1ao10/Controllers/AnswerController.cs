using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.AnswerDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;

[ApiController]
[Route("[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IAnswerRepository _answerRepository;


    public AnswerController(IAnswerRepository AnswerRepository)
    {
        _answerRepository = AnswerRepository;
    }

    [HttpPost]
    public ActionResult<Answer> Create(Answer answer)
    {
        _answerRepository.Create(answer);

        return CreatedAtAction(nameof(AnswerController), new { id = answer.Id }, answer);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterAnswerDto AnswerDto)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        answer.Answers = AnswerDto.Answers;
        answer.Score = AnswerDto.Score;
        answer.Observation = AnswerDto.Observation;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = answer.Id }, answer);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var answers = _answerRepository.List();
        return Ok(answers);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        return Ok(answer);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _answerRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _answerRepository.Delete(id);

        return NoContent();
    }
}