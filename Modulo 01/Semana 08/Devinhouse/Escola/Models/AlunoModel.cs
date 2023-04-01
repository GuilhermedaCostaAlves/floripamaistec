namespace Escola.Models;
public class AlunoModel : BaseModel 
{
    public int Id {get; set;}
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
}
    