using Escola.Models;

namespace Escola.Repositories;

public class AlunosRepository
{
private static List<AlunoModel>lista = new List<AlunoModel>()
    {
        new AlunoModel {Id = 1, Nome = "Ana"},
        new AlunoModel {Id = 2, Nome = "Pedro"},
        new AlunoModel {Id = 3, Nome = "Paulo"},
        new AlunoModel {Id = 4, Nome = "Paola"}
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
     public AlunoModel? ObterAluno(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

     public AlunoModel AtualizarAluno(int Id, AlunoDto dto)
    {
        var AlunoModel = ObterAluno(Id);
        lista.Remove(AlunoModel);

        AlunoModel.Nome = dto.Nome;
        lista.Add(AlunoModel);
        return AlunoModel;
    }
    public AlunoModel CriarAluno(AlunoDto dto)
    {

        var alunoModel= new AlunoModel();
        alunoModel.Nome = dto.Nome;
        lista.Add(alunoModel);

        return alunoModel;
    }
     public void ExcluirAluno(int id)
    {
        var alunoModel = lista.FirstOrDefault(a => a.Id == id);

        if (alunoModel != null)
        lista.Remove(alunoModel);
    }
     private int GerarId()
    {
        return lista.Last().Id + 1;
    }

}
