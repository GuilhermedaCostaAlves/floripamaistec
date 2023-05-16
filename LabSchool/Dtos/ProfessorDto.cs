using LabSchool.Enum;

namespace LabSchool.Dtos
{
    public class EntradaProfessorDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public int Codigo { get; set; }
        public EEstado Estado { get; set; }
        public EExperiencia Experiencia { get; set; }
        public EFormacao Formacao { get; set; }
    }


    public class SaidaProfessorDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public int Codigo { get; set; }
        public EEstado Estado { get; set; }
        public EExperiencia Experiencia { get; set; }
        public EFormacao Formacao { get; set; }
    }
}