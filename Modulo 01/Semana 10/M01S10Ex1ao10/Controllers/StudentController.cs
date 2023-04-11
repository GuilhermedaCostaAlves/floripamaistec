using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static M01S10Ex1ao10.Dtos.StudentDto;
using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;


    public StudentController(IStudentRepository StudentRepository)
    {
        _studentRepository = StudentRepository;
    }


    [HttpPost]
    public ActionResult<Student> Create(Student student)
    {
        _studentRepository.Create(student);

        return CreatedAtAction(nameof(StudentController), new { id = student.Id }, student);
    }


    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterStudentDto StudentDto)
    {
        var student = _studentRepository.GetById(id);

        if (student == null)
            return NotFound();

        student.UserId = StudentDto.UserId;
        student.Period = StudentDto.Period;
        student.RA = StudentDto.RA;

        return CreatedAtAction(nameof(StudentController.Get), new { id = student.Id }, student);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var student = _studentRepository.List();
        return Ok(student);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var student = _studentRepository.GetById(id);

        if (student == null)
            return NotFound();

        return Ok(student);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var student = _studentRepository.GetById(id);
        if (student == null)
        {
            return NotFound();
        }

        _studentRepository.Delete(id);

        return NoContent();
    }
}