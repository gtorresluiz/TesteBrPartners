# Projeto de Teste - BR Partners

Este é um CRUD desenvolvido em **ASP.NET Core** com uso de **Razor Pages** e integração com o **DevExpress** para exibição de grids de cadastro.

## Sobre o Projeto

O projeto simula uma aplicação de cadastro de clientes com operações de listagem e criação. Os dados estão configurados para serem armazenados em um banco de dados local **SQL Server** rodando no meu PC.

## Tecnologias Utilizadas

- **ASP.NET Core 6**
- **Razor Pages**
- **Entity Framework Core** (para acesso ao banco de dados)
- **DevExpress** (para grids de cadastro)
- **SQL Server** (banco de dados local)

## Configuração do Banco de Dados

O projeto está configurado para se conectar a um banco de dados SQL Server local, que roda em meu PC. A string de conexão está definida no arquivo `appsettings.json` e usa a seguinte configuração:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=GAMER-PC;Database=brpartners;Trusted_Connection=True;Encrypt=False;"
}
```
Observação: A conexão está configurada para usar autenticação do Windows (Trusted_Connection=True), o que significa que ela funciona no ambiente local do meu computador. Para rodar o projeto em outro ambiente, será necessário alterar essa string de conexão e ajustar para um servidor de banco de dados acessível.
