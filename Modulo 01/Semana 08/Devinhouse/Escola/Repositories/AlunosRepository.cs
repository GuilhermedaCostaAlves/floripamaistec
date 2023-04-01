using Escola.Models;

namespace Escola.Repositories;

public class AlunosRepository
{
private static List<AlunoModel>lista = new List<AlunoModel>()
    {
        new AlunoModel {Nome = "Ana"},
        new AlunoModel {Nome = "Pedro"},
        new AlunoModel {Nome = "Paulo"},
        new AlunoModel {Nome = "Paola"}
    }; 
    public List<AlunoModel> ListarAlunos(string filtroNome)
    {

        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(z => z.Nome.ToLower().Contains(filtroNome.ToLower()))
            .OrderBy(x => x.Nome)
            .ToList();
    }
}