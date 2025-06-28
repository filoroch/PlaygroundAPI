using System.Collections.Generic;
using PlaygroundAPI.Models;

public class LivroDTO
{
    public int id { get; init; } // provavelmente vou precisar apagar este campo quando usar o EF
    public string Titulo { get; init; }
    public string Description { get; init; }
    public List<AutorModel> Autores { get; init; }
    /// <summary>
    /// Converte <c>LivroModel</c> em um <c>LivroDTO<c>
    /// </summary>
    /// <param name="livroModel"></param>
    /// <returns></returns>
    public static LivroDTO FromLivroModel(LivroModel livroModel) => new()
    {
        id = livroModel.id,
        Titulo = livroModel.Titulo,
        Description = livroModel.Description,
        Autores = livroModel.Autores
    };
}   