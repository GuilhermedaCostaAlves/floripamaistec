using LabSchool.Models;

namespace LabSchool.Interfaces
{
    public interface IProfessorRepository
    {
        void Create(Professor professor);
        List<Professor> List();
        Professor? GetById(int Codigo);
        void Update(Professor professor);
        void Delete(int Codigo);
    }
}