using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

public static class ClientEndpoints
{
    public static RouteGroupBuilder MapClientEndpoins(this RouteGroupBuilder group)
    {
        group.MapGet("/", (HttpContext context) =>
            Results.Ok("Buscar cliente"))
                .WithName("GetClients")
                .WithSummary("Buscar todos os clientes");

        group.MapPost("/", (HttpContext context) =>
            Results.Created("client", null))
                .WithName("CreateClient")
                .WithSummary("Criar um novo usuário");

        group.MapPut("{id:int}", (HttpContext context, int id) =>
            Results.Ok($"Atualizar cliente com ID {id}"))
                .WithName("UpdateClient")
                .WithSummary("Atualiza um cliente com base no ID");

        group.MapDelete("{id:int}", (HttpContext context, int id) =>
            Results.Ok($"Deletar cliente com ID {id}"))
                .WithName("DeleteClient")
                .WithSummary("Deleta um cliente");

        return group;
    }
}