using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[nome]")]

public class AlunoController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar(string? Nome)
    {
        var Repositories = new AlunosRepository();
        var alunoModel = Repositories.ListarAlunos(Nome);

        return Ok(alunoModel);
    }
    [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {

        if (id <= 0)
        return BadRequest("Id deve ser maior que zero");

        var repository = new AlunosRepository();
        var alunoModel = repository.ObterAluno(id);

        if (alunoModel == null)
            return NotFound();

        return Ok(alunoModel);
    }
     
    [HttpPost]
    public IActionResult Criar([FromBody] AlunoDto dto){
       
       var repository = new AlunosRepository();
       var alunoModel = repository.CriarAluno(dto);
       return CreatedAtAction(nameof(AlunoController.Obter),  new { id = alunoModel.Id }, alunoModel);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id){
       
       var repository = new AlunosRepository();
       repository.ExcluirAluno(id);

       return NoContent();
    }

}