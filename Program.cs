using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Playground API",
        Description = "ASP.NET Core Web API para servir uma aplicação de biblioteca."
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Swagger so roda em ambiente de desenvolvimento. Preciso estudar pra saber se tem algum problema ele ficar acessivel em ambiente de produção.
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comentado para evitar problemas de SSL em desenvolvimento
//app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World");

RouteGroupBuilder userGroup = app.MapGroup("user").WithTags("User");
userGroup.MapUserEndponts();

RouteGroupBuilder clientGroup = app.MapGroup("client").WithTags("Client");
clientGroup.MapClientEndpoins();

RouteGroupBuilder autorGroup = app.MapGroup("autor").WithTags("Autor");
autorGroup.MapAutorEndpoins();

app.Run();

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