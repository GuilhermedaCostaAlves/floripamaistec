using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface ITeacherRepository
    {
        void Create(Teacher Teacher);
        List<Teacher> List();
        Teacher? GetById(int id);
        void Update(Teacher Teacher);
        void Delete(int id);
    }
}