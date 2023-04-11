using FluentValidation;
using System.Reflection.Metadata;
using M01S10Ex1ao10.Context;
using M01S10Ex1ao10.Models;
using M01S10Ex1ao10.Repositories;
using M01S10Ex1ao10.Interfaces;
using M01S10Ex1ao10.Dtos;
using M01S10Ex1ao10Context = M01S10Ex1ao10.Context.SchoolContext;

namespace M01S10Ex1ao10.Repositories;

public class AnswerRepository : IAnswerRepository
{
    private readonly SchoolContext _context;

    public AnswerRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Answer Answer)
    {
        _context.Answers.Add(Answer);
        _context.SaveChanges();
    }


    public List<Answer> List()
    {
        return _context.Answers.ToList();
    }


    public Answer? GetById(int id)
    {
        return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Answer Answer)
    {
        _context.Answers.Update(Answer);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var answer = GetById(id);
        _context.Answers.Remove(answer);
        _context.SaveChanges();

    }

}