using Microsoft.AspNetCore.Mvc;
using Aula02.Repositorios;
namespace Aula02.Controllers;

[ApiController]
[Route ("[controller]")]

public class DisciplinaController : Controller
{
    [HttpGet]
    [Route("(listar)")]
   public IActionResult Listar(string nome)
   {
    var Repositorios = new DisciplinaRepositorio();
    var Disciplina = Repositorios.ListarDisciplinas();
    return Ok($"nome informado = {nome}");
   }
   
    [HttpGet]
    [Route("(id)")]
   public IActionResult Obter(int Id)
   {
    if(Id<= 0)
    return BadRequest("id informado deve ser maior que zero");
    return Ok($"id informado = {Id}");
   }
    [HttpPut]
    [Route("{id}")]
    public IActionResult Atualizar(int id, [FromBody] object objeto)
    {

        return Ok($"id informado = {id}");
    }
}