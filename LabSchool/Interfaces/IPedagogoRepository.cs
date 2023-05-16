using LabSchool.Models;

namespace LabSchool.Interfaces
{
    public interface IPedagogoRepository
    {
        void Create(Pedagogo pedagogo);
        List<Pedagogo> List();
        Pedagogo? GetById(int Codigo);
        void Update(Pedagogo pedagogo);
        void Delete(int Codigo);
    }
}