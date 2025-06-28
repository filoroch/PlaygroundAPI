using System.Collections.Generic;
using PlaygroundAPI.Models;

public class AutorDTO
{
    public int Id { get; init; }
    public string Nome { get; init; }
    public List<LivroModel> Livros { get; init; }

    /// <summary>
    /// Convete m <c>AutorModel</c> em um <c>AutorDTO</c>
    /// </summary>
    /// <param name="autorModel"><c>AutorModel</c> que sera convertido</param>
    /// <returns>Um novo <c>AutorDTO</c> referente ao <c>AutorModel</c></returns>
    public static AutorDTO FromAutorModel(AutorModel autorModel) => new()
    {
        Id = autorModel.id,
        Nome = autorModel.Nome,
        Livros = autorModel.Livros
    };
}

