using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[nome]")]

public class AlunoController
{
    [HttpGet]
    public IActionResult Listar(string? Nome)
    {
        var Repositories = new AlunosRepository();
        var AlunoModel = Repositories.ListarAlunos(Nome);

        return Ok(AlunoModel);
    }
    
}