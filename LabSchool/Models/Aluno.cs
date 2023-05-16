using LabSchool.Enum;
    
namespace LabSchool.Models;

public class Aluno : Pessoa
{
    public ESituacaoMatricula Situacao { get; set; }
    public float Nota { get; set; }
    public int QtdAtendimentos { get; set; }
}