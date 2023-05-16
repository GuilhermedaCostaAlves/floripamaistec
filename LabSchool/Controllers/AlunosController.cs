using LabSchool.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LabSchool.Context;
using LabSchool.Dtos;
using LabSchool.Models;

namespace LabSchool.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly LabSchoolContext _context;


    public AlunoController(LabSchoolContext context)
    {
        _context = context;
    }


    [HttpPost]
    public ActionResult Create([FromBody] EntradaAlunoDto alunoDto)
    {
       var alunoEntrada = new Aluno();
       alunoEntrada.Nome = alunoDto.Nome;

        _context.Alunos.Add(alunoEntrada);
        _context .SaveChanges();

        var alunoSaida = new SaidaAlunoDto();
        alunoSaida.Codigo = alunoEntrada.Codigo;
        /*
         * .
         * .
         * .*/

        return Ok(alunoSaida);
        
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