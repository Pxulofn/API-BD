# API-BD
Esta é uma API RESTful para realizar operações de CRUD (Criar, Ler, Atualizar, Deletar) em uma entidade Product, utilizando ASP.NET Core Web API e Entity Framework Core (SQLite).

# 1- [Entidades](https://docs.google.com/spreadsheets/d/15AtjKrUKuu8CwDN3k6jmihijqkXi3DVUvD0sPI-FiXg/edit?gid=2012604502#gid=2012604502)

# 2. Passos para Rodar
**1.Pré-requisitos: .NET SDK 9.0 (ou superior) instalado.**

**2.Clonar o Repositório:**

*Bash*

git clone [[MEU REPOSITORIO](https://github.com/Pxulofn/API-BD)]
cd EstoqueAPI

**3.Restaurar Pacotes:**

*Bash*

dotnet restore

**4.Executar Migrations (Criar o Banco):**

*Bash*

dotnet ef database update (Isso criará o arquivo estoque.db na raiz do projeto).

**5.Executar a API:**

*Bash*

dotnet run
A API estará acessível em http://localhost:5153 

# 3- Rotas e Exemplos de Requisições
A rota base é /api/products. O corpo das requisições POST e PUT deve ser um JSON.

[Endpoints CRUD (Produtos)](https://docs.google.com/spreadsheets/d/19Ag5glgXF1gYJxRmnpiBKnYvB4Rxc-3QNHqTkqJjXs4/edit?gid=1699039560#gid=1699039560)

**Exemplo de Requisição POST (Criação)**
(Exemplo de requisição no arquivo .http ou Postman)

*http ->*

POST http://localhost:5153/api/products

Content-Type: application/json

{
  "name": "Mouse Sem Fio Logitech",
  "price": 89.90,
  "category": "Eletrônico"
}

**Exemplo de Resposta de ERRO (Validação - 400 Bad Request)**
Se faltar o campo name (obrigatório) na requisição POST:

JSON

{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "errors": {
    "Name": [
      "O nome do produto é obrigatório."
    ]
  }
}

**Exemplo de Requisição PUT (Atualização)**
(Atualiza o produto com ID 1)

HTTP

PUT http://localhost:5153/api/products/1
Content-Type: application/json

{
  "name": "Mouse Sem Fio Logitech - NOVO PREÇO",
  "price": 99.99,
  "category": "Eletrônico"
}
