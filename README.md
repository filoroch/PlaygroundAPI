# PlaygroundAPI

Este projeto é um **playground de API** desenvolvido em C# para simular uma **biblioteca online**. O objetivo é aplicar e testar conhecimentos em desenvolvimento de APIs, servindo como um ambiente para experimentação e aprimoramento contínuo.

## Como Iniciar

Para rodar o projeto localmente, siga estas etapas:

### Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior.
- Um editor de código (Visual Studio, VS Code, etc.).

### Configuração

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/filoroch/PlaygroundAPI.git
    cd PlaygroundAPI
    ```

2.  **Configure os Segredos do Usuário (User Secrets):**
    Para dados sensíveis (ex: connection strings, chaves JWT) em ambiente de desenvolvimento, o projeto utiliza o sistema de User Secrets do .NET. Estes segredos são armazenados fora do diretório do projeto e não são versionados. Configure-os localmente com `dotnet user-secrets` (substitua os exemplos pelos seus segredos reais):

    ```bash
    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Sua_Connection_String_Aqui" --project "PlaygroundAPI.csproj"
    dotnet user-secrets set "Jwt:Key" "Sua_Chave_Super_Secreta_Aqui" --project "PlaygroundAPI.csproj"
    ```
    *Certifique-se de que o `UserSecretsId` esteja configurado no seu `.csproj`.*

### Execução

1.  **Inicie a aplicação:**
    ```bash
    dotnet run
    ```
    (O projeto iniciará em modo de desenvolvimento por padrão.)

2.  **Acesse a API:**
    A API estará disponível em:
    - **HTTP:** `http://localhost:5000`
    - **HTTPS:** `https://localhost:7000`

    A documentação do Swagger UI pode ser acessada em `/swagger` (ex: [http://localhost:5000/swagger](http://localhost:5000/swagger)).

## Próximos Passos

- [x] Criar os modelos 
    - [ ] Criar os modelos de transferência (DTOs)
- [x] Configurar o Swagger
- [ ] Criar as controllers
    - [x] Agrupar as controllers
- [ ] Configurar o banco de dados (EF Core e SQLite)

Para mais detalhes sobre o projeto, incluindo modelos de dados, diagramas e sequências de funcionamento, consulte a [Wiki do Projeto](https://github.com/filoroch/PlaygroundAPI/wiki).

# FAQ - Perguntas Frequentes

### O que é o PlaygroundAPI?
É um projeto de "playground" para testar e aplicar conhecimentos em desenvolvimento de APIs com C#, simulando uma biblioteca online.

### Quais tecnologias principais são utilizadas?
O projeto é desenvolvido em C# com .NET 8 SDK e utiliza Minimal APIs. A configuração do banco de dados será feita com EF Core e SQLite.

### Onde posso encontrar a documentação detalhada?
A documentação detalhada, incluindo modelos de dados, diagramas e sequências de funcionamento, está disponível na [Wiki do Projeto](https://github.com/filoroch/PlaygroundAPI/wiki).

### Como posso contribuir?
Sinta-se à vontade para abrir issues, sugerir melhorias ou enviar pull requests. Toda contribuição é bem-vinda!

# Changelog
Para ver o histórico completo de mudanças, consulte o [CHANGELOG.md](CHANGELOG.md).

# Referências

- [Microsoft | Como usar o Swashbuckle/Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio)
- [AllInOneAspNe - Guia de APIs Rest com C#](https://github.com/LuanRoger/AllInOneAspNe)
