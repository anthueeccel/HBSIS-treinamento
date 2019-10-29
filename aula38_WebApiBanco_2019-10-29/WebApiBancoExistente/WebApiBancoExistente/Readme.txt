*Criar WebAPI e criar Banco de Dados*
Create a new Wep API ADO w/ EF

Web App (.Net Framework)
----API Empty
Models > Add new Item > Data > ADO EF
Controller > Add Controller > Web Api 2 using EF

-------------------------------------------------
*Criar WebAPI com Banco de Dados existente*
New Solution > ASP.NET WebApp > WebAPI w/ EF
Models > Add new Item > ADO.NET > Model First
----Serve name: (localdb)\MSSQLLocalDB
----Test Connection > OK
----(v) Save on web.Config
----Next
Selecionar as tabelas
----(v) Plularize
----OK

Controlles > Add > Controller > WebAPI 2 w/ EF
----Seleciona a tabela e o Context

-------------------------------------------------
*Para adicionar uma DataBase a sua máquina.*
SQL Object Server;
Botão direito > Publish Data Tier (selecionar database)
