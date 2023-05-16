using LabSchool.Enum;

namespace LabSchool.Dtos
{
    public class EntradaAlunoDto
    {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public DateTime DataDeNascimento { get; set; }
            public string CPF { get; set; }
            public int Codigo { get; set; }
            public ESituacaoMatricula Situacao { get; set; }
            public float Nota { get; set; }
            public int QtdAtendimentos { get; set; }
    }


    public class SaidaAlunoDto
    {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public DateTime DataDeNascimento { get; set; }
            public string CPF { get; set; }
            public int Codigo { get; set; }
            public ESituacaoMatricula Situacao { get; set; }
            public float Nota { get; set; }
            public int QtdAtendimentos { get; set; }
    }
}