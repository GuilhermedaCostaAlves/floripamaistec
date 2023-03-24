using Aula02.Models;
namespace Aula02.Repositorios;

public class DisciplinaRepositorio
{
    private static List<Disciplina> lista = new List<Disciplina>(){
        new Disciplina { Id = 1, CargaHoraria = 20, Nome = "História"}
    };
    
    public List<Disciplina> ListarDisciplinas()
    {
        return lista;
    }
}