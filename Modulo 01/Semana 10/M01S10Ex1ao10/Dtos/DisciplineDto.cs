namespace M01S10Ex1ao10.Dtos
{
    public class DisciplineDto
    {

        public class CreateDisciplineDto
        {
            public int TeacherId { get; set; }
            public string NameDiscipline { get; set; }
        }


        public class AlterDisciplineDto
        {
            public int TeacherId { get; set; }
            public string NameDiscipline { get; set; }
        }
    }
}