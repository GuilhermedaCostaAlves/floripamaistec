namespace M01S10Ex1ao10.Dtos
{
    public class Student_DisciplineDto
    {
        public class CreateStudent_DisciplineDto
        {
            public int StudentId { get; set; }
            public int DisciplineId { get; set; }       
        }

        public class AlterStudent_DisciplineDto
        {
            public int StudentId { get; set; }
            public int DisciplineId { get; set; }
        }
    }
}