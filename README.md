# API-BD
🌟 EstoqueAPI: API REST CRUD com .NET e EF Core
Este projeto é uma API RESTful robusta, desenvolvida em C# / ASP.NET Core Web API (.NET 9), focada em implementar as operações completas de CRUD (Create, Read, Update, Delete) para a entidade Product.

A persistência de dados é gerenciada pelo Entity Framework Core 9, utilizando SQLite como banco de dados padrão (configurável para PostgreSQL ou SQL Server).

⚙️ Recursos Técnicos e Validações
CRUD Completo: Endpoints RESTful para todas as operações da entidade Product.

Persistência de Dados: Uso de EF Core Migrations para versionamento e gerenciamento do schema do banco de dados (estoque.db).

Validação de Dados: Implementação de DataAnnotations na camada de Models e DTOs, garantindo a integridade dos dados.

Tratamento de Erros: Retorno de status HTTP adequados (400 Bad Request, 404 Not Found, etc.) para falhas de validação ou recursos não encontrados.

Arquitetura: Utilização de Controllers e DTOs (Data Transfer Objects) para manter a separação de responsabilidades e a qualidade do código.

🚀 Endpoints (Rotas da API)
Utilizamos a rota base /api/products para acessar a entidade.
