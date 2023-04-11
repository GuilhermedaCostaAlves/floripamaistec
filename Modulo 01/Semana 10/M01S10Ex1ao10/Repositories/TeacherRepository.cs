using FluentValidation;
using System.Reflection.Metadata;
using M01S10Ex1ao10.Context;
using M01S10Ex1ao10.Models;
using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using M01S10Ex1ao10.Dtos;
using M01S10Ex1ao10Context = M01S10Ex1ao10.Context.SchoolContext;

namespace M01S10Ex1ao10.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly SchoolContext _context;

    public TeacherRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Teacher Teacher)
    {
        _context.Teachers.Add(Teacher);
        _context.SaveChanges();
    }


    public List<Teacher> List()
    {
        return _context.Teachers.ToList();
    }


    public Teacher? GetById(int id)
    {
        return _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Teacher Teacher)
    {
        _context.Teachers.Update(Teacher);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Teacher = GetById(id);
        _context.Teachers.Remove(Teacher);
        _context.SaveChanges();

    }
}