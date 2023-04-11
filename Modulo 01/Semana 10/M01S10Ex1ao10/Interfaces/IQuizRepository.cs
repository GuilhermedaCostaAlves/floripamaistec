using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IQuizRepository
    {
        void Create(Quiz Quiz);
        List<Quiz> List();
        Quiz? GetById(int id);
        void Update(Quiz Quiz);
        void Delete(int id);
    }
}