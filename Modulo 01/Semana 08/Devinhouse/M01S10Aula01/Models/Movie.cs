using System.ComponentModel.DataAnnotations.Schema;

namespace M01S10Aula01.Models;


public class Movie {

    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public DateTime DataDeLancamento { get; set; }
}