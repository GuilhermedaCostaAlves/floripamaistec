namespace M01S10Ex1ao10.Dtos
{
    public class QuizDto
    {
        public class CreateQuizDto
        {
            public int DisciplineId { get; set; }
            public string Title { get; set; }
            public string Observation { get; set; }
        }

       
        public class AlterQuizDto
        {
            public int DisciplineId { get; set; }
            public string Title{ get; set; }
            public string Observation { get; set; }
        }
    }
}