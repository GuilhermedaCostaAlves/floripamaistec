using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.TeacherDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherRepository _teacherRepository;


    public TeacherController(ITeacherRepository TeacherRepository)
    {
        _teacherRepository = TeacherRepository;
    }


    [HttpPost]
    public ActionResult<Teacher> Create(Teacher teacher)
    {
        _teacherRepository.Create(teacher);

        return CreatedAtAction(nameof(TeacherController), new { id = teacher.Id }, teacher);
    }


    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterTeacherDto TeacherDto)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        teacher.UserId = TeacherDto.UserId;
        teacher.Department = TeacherDto.Department;

        return CreatedAtAction(nameof(TeacherController.Get), new { id = teacher.Id }, teacher);
    }


    [HttpGet]
    public IActionResult Get()
    {
        var teacher = _teacherRepository.List();
        return Ok(teacher);
    }


    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        return Ok(teacher);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteATeacher(int id)
    {
        var teacher = _teacherRepository.GetById(id);
        if (teacher == null)
        {
            return NotFound();
        }

        _teacherRepository.Delete(id);

        return NoContent();
    }
}