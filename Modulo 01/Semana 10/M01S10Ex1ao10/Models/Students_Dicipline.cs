using System.IO;

namespace M01S10Ex1ao10.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public int StudentId { get; set; }


        public virtual Discipline Discipline { get; set; }
        public virtual Student Student { get; set; }
    }
}