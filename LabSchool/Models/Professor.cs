using LabSchool.Enum;
namespace LabSchool.Models;

public class Professor : Pessoa

{
    public EEstado Estado { get; set; }
    public EExperiencia Experiencia { get; set; }
    public EFormacao Formacao { get; set; }
}