using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IStudent_DisciplineRepository
    {
        void Create(Student_Discipline Student_Discipline);
        List<Student_Discipline> List();
        Student_Discipline? GetById(int id);
        void Update(Student_Discipline Student_Discipline);
        void Delete(int id);
    }
}