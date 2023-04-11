namespace M01S10Ex1ao10.Dtos
{
    public class StudentDto
    {
        public class CreateStudentDto
        {
            public int UserId { get; set; }
            public int Period { get; set; }
            public int RA { get; set; }
        }

       
        public class AlterStudentDto
        {
            public int UserId { get; set; }
            public int Period { get; set; }
            public int RA { get; set; }
        }
    }
}