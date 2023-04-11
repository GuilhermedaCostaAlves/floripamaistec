namespace M01S10Ex1ao10.Dtos
{
    public class TeacherDto
    {
        public class CreateTeacherDto
        {
            public int UserId { get; set; }
            public string Department { get; set; }
        }
        

        public class AlterTeacherDto
        {
            public int UserId { get; set; }
            public string Department { get; set; }
        }
    }
}