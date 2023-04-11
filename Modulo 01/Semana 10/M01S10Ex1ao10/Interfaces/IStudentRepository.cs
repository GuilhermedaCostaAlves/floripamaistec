using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student Student);
        List<Student> List();
        Student? GetById(int id);
        void Update(Student Student);
        void Delete(int id);
    }    
}