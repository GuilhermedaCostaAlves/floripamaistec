using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IDisciplineRepository
    {
        void Create(Discipline discipline);
        List<Discipline> List();
        Discipline? GetById(int id);
        void Update(Discipline discipline);
        void Delete(int id);
    }
}