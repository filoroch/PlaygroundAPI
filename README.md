# About
O projeto se refere a um grande playground de teste de api. Quero simular uma API completa em C# testando todos os meus conhecimentos e marcando os aqui. No fim, tudo se resume a um grande teste, onde a falha ou o sucesso vão me permitir identificar pontos de melhoria na minha forma de desenvolvimento

## Sobre o projeto
Inicialmente, quero desenvolver uma pequena API baseada em controllers para simular uma biblioteca online, com Livros, Clientes, Usuarios, Autores e etc.

### Models
|Models|Descrição|Campos|
|---|---|---|
| Livros | Representa um objeto/tabela livros no banco de dados | - `ìd` <br> - `titulo` <br> - `autor FK`
- Livros
    - Todo livro tem pelo menos um autor e um autor pode ter muitos livros   
    - Todo livro tem Titulo
    - Todo livro tem ano de publicação
- Autores
    - Todo autor tem pelo menos um livro e pode ter varios livros
    - Todo autor tem Nome
- Clientes
- Usuarios

## Tasks
- [ ] Criar os modelos 
- [ ] Criar as controllers
-  