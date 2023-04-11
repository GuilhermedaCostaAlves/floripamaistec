using M01S10Ex1ao10.Models;

namespace M01S10Ex1ao10.Interfaces
{
    public interface IQuestionRepository
    {
        void Create(Question Question);
        List<Question> List();
        Question? GetById(int id);
        void Update(Question Question);
        void Delete(int id);
    }
}