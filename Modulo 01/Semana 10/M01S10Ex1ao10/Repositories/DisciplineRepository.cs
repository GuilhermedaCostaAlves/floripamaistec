using FluentValidation;
using System.Reflection.Metadata;
using M01S10Ex1ao10.Context;
using M01S10Ex1ao10.Models;
using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using M01S10Ex1ao10.Dtos;
using M01S10Ex1ao10Context = M01S10Ex1ao10.Context.SchoolContext;

namespace M01S10Ex1ao10.Repositories;

public class DisciplineRepository : IDisciplineRepository
{
    private readonly SchoolContext _context;

    public DisciplineRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Discipline Discipline)
    {
        _context.Disciplines.Add(Discipline);
        _context.SaveChanges();
    }


    public List<Discipline> List()
    {
        return _context.Disciplines.ToList();
    }


    public Discipline? GetById(int id)
    {
        return _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Discipline Discipline)
    {
        _context.Disciplines.Update(Discipline);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var discipline = GetById(id);
        _context.Disciplines.Remove(discipline);
        _context.SaveChanges();

    }

}