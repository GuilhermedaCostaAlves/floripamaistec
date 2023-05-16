using LabSchool.Models;

namespace LabSchool.Interfaces
{
    public interface IAlunoRepository
    {
        void Create(Aluno aluno);
        List<Aluno> List();
        Aluno? GetById(int Codigo);
        void Update(Aluno aluno);
        void Delete(int Codigo);
    }
}