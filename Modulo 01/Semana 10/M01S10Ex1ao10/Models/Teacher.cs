using System.IO;

namespace M01S10Ex1ao10.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }


        public virtual User User { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}