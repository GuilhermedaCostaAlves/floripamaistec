using FluentValidation;
using System.Reflection.Metadata;
using M01S10Ex1ao10.Context;
using M01S10Ex1ao10.Models;
using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using M01S10Ex1ao10.Dtos;
using M01S10Ex1ao10Context = M01S10Ex1ao10.Context.SchoolContext;

namespace M01S10Ex1ao10.Repositories;

public class Student_DisciplineRepository : IStudent_DisciplineRepository
{
    private readonly SchoolContext _context;

    public Student_DisciplineRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Student_Discipline Student_Discipline)
    {
        _context.Students_Disciplines.Add(Student_Discipline);
        _context.SaveChanges();
    }


    public List<Student_Discipline> List()
    {
        return _context.Students_Disciplines.ToList();
    }


    public Student_Discipline? GetById(int id)
    {
        return _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Student_Discipline Student_Discipline)
    {
        _context.Students_Disciplines.Update(Student_Discipline);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Student_Discipline = GetById(id);
        _context.Students_Disciplines.Remove(Student_Discipline);
        _context.SaveChanges();

    }
}