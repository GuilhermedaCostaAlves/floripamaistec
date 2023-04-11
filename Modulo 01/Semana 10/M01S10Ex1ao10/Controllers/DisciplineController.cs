using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.DisciplineDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplineController : ControllerBase
{
    private readonly IDisciplineRepository _disciplineRepository;


    public DisciplineController(IDisciplineRepository DisciplineRepository)
    {
        _disciplineRepository = DisciplineRepository;
    }

    [HttpPost]
    public ActionResult<Discipline> Create(Discipline discipline)
    {
        _disciplineRepository.Create(discipline);

        return CreatedAtAction(nameof(DisciplineController), new { id = discipline.Id }, discipline);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterDisciplineDto DisciplineDto)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        discipline.TeacherId = DisciplineDto.TeacherId;
        discipline.NameDiscipline = DisciplineDto.NameDiscipline;

        return CreatedAtAction(nameof(DisciplineController.Get), new { id = discipline.Id }, discipline);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var discipline = _disciplineRepository.List();
        return Ok(discipline);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        return Ok(discipline);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _disciplineRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _disciplineRepository.Delete(id);

        return NoContent();
    }
}