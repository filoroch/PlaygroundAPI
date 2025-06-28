using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

public static class UserEndpoints
{
    public static RouteGroupBuilder MapUserEndponts(this RouteGroupBuilder group)
    {
        group.MapPost("signin", (HttpContext context) =>
            Results.Created("user/signin", null))
                .WithName("UserSignIn")
                .WithSummary("Cadastrar usuário");

        group.MapPost("login", (HttpContext context) =>
            Results.Ok("Logar usuario"))
                .WithName("UserLogin")
                .WithSummary("Login do usuário");

        return group;
    }
}