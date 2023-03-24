using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers;

[Route("Aluno")]
[ApiController]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("ObterAluno")]
    public IActionResult ObterAlunos()
    {
        var aluno = new Aluno();
        aluno.Id = 1;
        aluno.nome = "João";
        aluno.DataDeNascimento = new DateTime(2001,01,07);

        return Ok(aluno);
    }
}