--2 - Criar uma base de dados chamada MercadoTechDB
create database MercadoTechDB
--	2.1 - A base deve conter as seguintes tabelas e seus campos	
--		2.1.1 - Funcionarios
--			2.1.1.1 - Id,Nome e informações de controle
create table Funcionarios(
Id int primary key identity(1,1),
Nome nvarchar(50) not null,
Ativo bit, 
UsuInclusao int, 
UsuAlteracao int, 
DataInclusao datetime, 
DataAlteracao datetime
)
GO

--		2.1.1 - Produtos
--			2.1.1.1 - Id,Nome,Valor e informações de controle
create table Produtos(
Id int primary key identity(1,1),
Nome nvarchar(50) not null,
Valor money,
Ativo bit, 
UsuInclusao int, 
UsuAlteracao int, 
DataInclusao datetime, 
DataAlteracao datetime
)
GO

--		2.1.2 - Pedidos
--			2.1.2.1 - Id,FuncionarioId,ProdutoId,Quantidade, e informações de controle
create table Pedidos(
Id int primary key identity(1,1),
FuncionarioId int,
ProdutoId int,
Quantidade int,
Ativo bit, 
UsuInclusao int, 
UsuAlteracao int, 
DataInclusao datetime, 
DataAlteracao datetime
)
GO



--	2.2  - Agora devemos inseir 2 funcionarios diferentes
Insert Into Funcionarios(Nome) values
('Anthue'),
('Felipe')
GO

--	2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
INSERT INTO Produtos(Nome, Valor) VALUES
('Corona 350ml', 2.85),
('Brahma 355ml', 1.45),
('Skol 355ml', 1.65),
('Wals 600ml', 6.85),
('Patagônia 600ml', 3.10)
GO


--	2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo
--	lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5
INSERT INTO Pedidos(FuncionarioId, ProdutoId, Quantidade) VALUES
(1, 2, 3),
(1, 5, 2),
(2, 1, 4)
GO

--	2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
SELECT Id, Nome FROM Funcionarios
order by Nome asc
GO

--	2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
SELECT Nome, Valor FROM Produtos
order by Valor desc
GO

--	2.7  - Vamos listar em uma selação de nossos pedidos por funcionario trazendo o nome do funcionario
SELECT p.Id AS 'ID Pedido', f.Nome AS 'Nome Funcionário'  FROM Pedidos p
	INNER JOIN Funcionarios f ON f.Id = p.FuncionarioId
GO

--	2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
SELECT count(p.Id) AS 'Qtde Pedidos', sum(p.Quantidade) AS 'Qtde Itens', f.Nome FROM PEDIDOS p
	INNER JOIN Funcionarios f ON f.Id = p.FuncionarioId
	group by f.Nome
GO

--	2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total
--	lembrando que o valor total e a a "quantidade * valor"
SELECT count(ped.Id) AS 'Qtde Pedidos', sum(pro.Valor * ped.Quantidade) AS 'Valor total', fun.Nome 
	FROM PEDIDOS ped
	INNER JOIN Funcionarios fun ON fun.Id = ped.FuncionarioId
	INNER JOIN Produtos pro ON pro.Id = ped.ProdutoId
	group by fun.Nome
GO

--	2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
SELECT TOP 1 sum(ped.Quantidade) 'Qtde Produto', pro.Nome
	FROM Pedidos ped
	INNER JOIN Produtos pro ON pro.Id = ped.ProdutoId
	GROUP BY pro.Nome
	ORDER BY sum(ped.Quantidade) DESC
GO

--	2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
SELECT TOP 1 sum(pro.Valor*ped.Quantidade) 'Valor total', pro.Nome
	FROM Pedidos ped
	INNER JOIN Produtos pro on pro.Id = ped.ProdutoId
	GROUP BY pro.Nome
	ORDER BY sum(pro.Valor*ped.Quantidade) DESC
GO

--	2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou 
--de nosso mercado
SELECT * FROM Produtos WHERE Id NOT IN 
	(SELECT ped.ProdutoId FROM Funcionarios fun
		INNER JOIN  Pedidos ped ON fun.Id = ped.FuncionarioId
		WHERE fun.Nome like 'Anthue')


--	2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado

SELECT count(ped.Quantidade) 'Qtde Total', pro.Nome
	FROM Pedidos ped
	INNER JOIN Produtos pro ON pro.Id = ped.ProdutoId
	GROUP BY pro.Id, pro.Nome
	ORDER BY count(ped.Quantidade) DESC
GO
