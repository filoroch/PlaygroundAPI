using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

public static class AutorEndpoints
{
    public static RouteGroupBuilder MapAutorEndpoins(this RouteGroupBuilder group)
    {
        group.MapGet("/", (HttpContext context) =>
            Results.Ok("Buscar autor"))
                .WithName("GetAutor")
                .WithSummary("Buscar todos os autores");

        group.MapPost("/", (HttpContext context) =>
            Results.Created("autor", null))
                .WithName("CreateAutor")
                .WithSummary("Cria um novo autor");

        group.MapPut("{id:int}", (HttpContext context, int id) =>
            Results.Ok($"Atualizar autor com ID {id}"))
                .WithName("UpdateAutor")
                .WithSummary("Atualiza um autor com base em iD");

        group.MapDelete("{id:int}", (HttpContext context, int id) =>
            Results.Ok($"Deletar autor com ID {id}"))
                .WithName("DeleteAutor")
                .WithSummary("Deleta um autor");

        return group;
    }
}