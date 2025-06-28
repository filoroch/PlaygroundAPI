# About
O projeto se refere a um grande playground de teste de api. Quero simular uma API completa em C# testando todos os meus conhecimentos e marcando os aqui. No fim, tudo se resume a um grande teste, onde a falha ou o sucesso vão me permitir identificar pontos de melhoria na minha forma de desenvolvimento

## Sobre o projeto
Inicialmente, quero desenvolver uma pequena API baseada em controllers para simular uma biblioteca online, com Livros, Clientes, Usuarios, Autores e etc.

## Tasks
- [ ] Criar os modelos 
- [x] Configurar o swagger
- [/] Criar as controllers
    - [x] Agrupas as controllers

# Changelog
## 2025-06-27
- Criar as controllers
    ---
    Results é um objeto que permite semanticamente retornar objetos com satus/codigos HTTP especifico.
    
    ```CSharp
    app.MapGet("/user/signin", (HttpContext context) => {
        return Results.Ok("Cadastrar Usuario");
    });
    ```

- Agrupar as controllers
    --- 
    No caso das Minimal APIs, para agrupar endpoints com uma mesma base, pode se usar classes que agrupam as finções e depois criar um objeto RouteGroupBuilder para mapea-las como Endpoins Semanticos da aplicação. Posteriormente essas classes seram separadas em outros arquivos

    ```CSharp
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

    RouteGroupBuilder userGroup = app.MapGroup("user").WithTags("User");
    userGroup.MapUserEndponts();

    RouteGroupBuilder clientGroup = app.MapGroup("client").WithTags("Client");
    clientGroup.MapClientEndpoins();

    RouteGroupBuilder autorGroup = app.MapGroup("autor").WithTags("Autor");
    autorGroup.MapAutorEndpoins();
    ```
- Configurar o Swagger
    ---
    Com ajuda do Claude no Modo Agente do Github Copilot, percebi que o Swagger só funciona na variavel de Desenvolvimento, provavelmente no futuro vou mudar isso para que sempre exista a interface, assim como usar a interface do Scalar.

    ```CSharp
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
        Version = "v1",
        Title = "Playground API",
        Description = "ASP.NET Core Web API para servir uma aplicação de biblioteca."
        });
    });

    ```

    Para rodar o codigo agora, basta usar:
    ``dotnet run --environment Development``
## Referencias
- [Microsoft | Como usar o Swashbuckle/Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio)