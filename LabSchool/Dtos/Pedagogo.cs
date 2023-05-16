using LabSchool.Enum;

namespace LabSchool.Dtos
{
    public class EntradaPedagogoDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public int Codigo { get; set; }
        public int QtdAtendimentos { get; set; }
    }


    public class SaidaPedagogoDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public int Codigo { get; set; }
        public int QtdAtendimentos { get; set; }
    }
}