using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

// GRUPO DE ENDPOINTS
RouteGroupBuilder userGroup = app.MapGroup("user").WithTags("User");
userGroup.MapUserEndponts();

RouteGroupBuilder clientGroup = app.MapGroup("client").WithTags("Client");
clientGroup.MapClientEndpoins();

RouteGroupBuilder autorGroup = app.MapGroup("autor").WithTags("Autor");
autorGroup.MapAutorEndpoins();

app.Run();

