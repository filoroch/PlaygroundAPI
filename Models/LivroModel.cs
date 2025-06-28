using System.Collections.Generic;
using PlaygroundAPI.Models;

public class LivroModel
{
    public int id { get; set; }
    public string Titulo { get; set; }
    public string Description { get; set; }
    public List<AutorModel> Autores { get; set; }
}