using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IAnswerRepository
    {
        void Create(Answer Answer);
        List<Answer> List();
        Answer? GetById(int id);
        void Update(Answer Answer);
        void Delete(int id);
    }
}