using FluentValidation;
using System.Reflection.Metadata;
using M01S10Ex1ao10.Context;
using M01S10Ex1ao10.Models;
using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using M01S10Ex1ao10.Dtos;
using M01S10Ex1ao10Context = M01S10Ex1ao10.Context.SchoolContext;

namespace M01S10Ex1ao10.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _context;

    public StudentRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Student Student)
    {
        _context.Students.Add(Student);
        _context.SaveChanges();
    }


    public List<Student> List()
    {
        return _context.Students.ToList();
    }


    public Student? GetById(int id)
    {
        return _context.Students.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Student Student)
    {
        _context.Students.Update(Student);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Student = GetById(id);
        _context.Students.Remove(Student);
        _context.SaveChanges();

    }
}