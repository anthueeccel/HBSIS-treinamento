--Realizar um update das inf que contem usuário de ciração 0 pra Id do usuário Felipe
update Marcas set UsuInc = (Select Id from Usuarios where Usuario like 'Felipe%')
	where UsuInc = 0
Go
--Trazer somente as marcas que Felipe cadastrou
select Nome as 'Marcas' from Marcas
	where UsuInc = (Select Id from Usuarios where Usuario like 'Felipe')
Go
--Trazer somente as marcas que Giomar cadastrou
select Nome as 'Marcas' from Marcas
	where UsuInc = (Select Id from Usuarios where Usuario like 'Giomar')
Go
--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select Count(Id) as 'Marcas cadastradas' from Marcas
	where UsuInc = (Select Id from Usuarios where Usuario like 'Felipe') 
	order by Count(Id) desc
Go
--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select Count(Id) as 'Marcas cadastradas' from Marcas
	where UsuInc = (Select Id from Usuarios where Usuario like 'Giomar') 
	order by Count(Id) asc
Go
--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select Count(Id) as 'Marcas cadastradas' from Marcas
	where UsuInc in(1,2 )
Go
--Trazer somente os carros que Felipe cadastrou
select Count(Id) as 'Marcas cadastradas' from Carros
	where UsuInc = (Select Id from Usuarios where Usuario like 'Felipe') 
Go

--Trazer somente os carros que Giomar cadastrou
select Count(Id) as 'Marcas cadastradas' from Carros
	where UsuInc = (Select Id from Usuarios where Usuario like 'Giomar') 
Go
--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select Count(Id) as 'Marcas cadastradas' from Carros
	where UsuInc = (Select Id from Usuarios where Usuario like 'Felipe') 
	order by Count(Id) desc
Go
--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select Count(Id) as 'Marcas cadastradas' from Carros
	where UsuInc = (Select Id from Usuarios where Usuario like 'Giomar') 
	order by Count(Id) asc
Go
--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select Count(Id) as 'Marcas cadastradas' from Carros
	where UsuInc in(1, 2)
	order by Count(Id) asc
Go
--Trazer somente os carros das marcas que Felipe cadastrou
select c.Modelo, m.Nome as 'Marca', IIF(c.Ativo = 1, 'Sim','Não') as 'Ativo' from Carros c
	inner join Marcas m on m.Id = c.Marca
	inner join Usuarios u on u.Usuario like 'Felipe'
where c.UsuInc = u.Id and m.UsuInc = u.Id
Go

--Trazer somente os carros das marcas que Giomar cadastrou
select c.Modelo, m.Nome as 'Marca', IIF(c.Ativo = 1, 'Sim','Não') as 'Ativo' from Carros c
	inner join Marcas m on m.Id = c.Marca
	inner join Usuarios u on u.Usuario like 'Giomar'
where c.UsuInc = u.Id and m.UsuInc = u.Id
Go

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select count(c.Id) from Carros c
	inner join Marcas m on m.Id = c.Marca
	inner join Usuarios u on u.Usuario like 'Felipe'
where c.UsuInc = u.Id and m.UsuInc = u.Id
order by count(c.Id) desc

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select count(c.Id) from Carros c
	inner join Marcas m on m.Id = c.Marca
	inner join Usuarios u on u.Usuario like 'Giomar'
where c.UsuInc = u.Id and m.UsuInc = u.Id
order by count(c.Id) asc

--Trazer o valor total de vendas 2019 isolado
select sum(valor) as 'Valor total de vendas (2019)' from Vendas
	where DatInc between '01/01/2019' and '12/01/2019'
	and DatAlt between '01/01/2019' and '12/01/2019'

--Trazer a quantidade total de vendas 2019 isolado
select count(Id) as 'Qtde Unidades Vendidas (2019)' from Vendas
	where DatInc between '01/01/2019' and '12/01/2019'
	and DatAlt between '01/01/2019' and '12/01/2019'

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor
select  sum(Valor*Quantidade) as 'Total Vendas', YEAR(DatInc) as 'Ano'
	from Vendas
	where 
		YEAR(DatInc) = '2018' or 
		YEAR(DatInc) = '2019' or 
		YEAR(DatInc) = '2020'
	group by YEAR(DatInc)
	order by sum(Valor*Quantidade) desc
Go
--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select  count(Id) as 'Total Vendas', YEAR(DatInc) as 'Ano'
	from Vendas
	where 
		YEAR(DatInc) = '2018' or 
		YEAR(DatInc) = '2019' or 
		YEAR(DatInc) = '2020'
	group by YEAR(DatInc)
	order by SUM(Valor) desc
Go
--Trazer o mês de cada ano que retornou a maior quantidade de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
--select   Count(Id) as 'Total Vendas', MONTH(DatInc) as 'Mês', YEAR(DatInc) as 'Ano'	
--	from Vendas
--	where 
--		YEAR(DatInc) = '2018' or
--		YEAR(DatInc) = '2019' or 
--		YEAR(DatInc) = '2020'
--	group by  MONTH(DatInc), YEAR(DatInc)
--	order by Count(Id) desc, Month(DatInc)	
--Go
---- com subSelect
--select top 1
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2018'	group by MONTH(DatInc) order by count(Id) desc) as '2018',
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2019'	group by MONTH(DatInc) order by count(Id) desc) as '2019',
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2020'	group by MONTH(DatInc) order by count(Id) desc) as '2020'
--from Vendas
--Go

-- Felipe
SELECT YEAR(ven1.DatInc),
(	SELECT TOP 1 MONTH(ven.DatInc)
        FROM Vendas ven
        WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
  GROUP BY MONTH(ven.DatInc)
  ORDER BY SUM(ven.Quantidade) DESC)
FROM Vendas ven1
GROUP BY YEAR(ven1.DatInc)
GO

--Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
--select top 1
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2018'	group by MONTH(DatInc) order by sum(Valor) desc) as '2018',
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2019'	group by MONTH(DatInc) order by sum(Valor) desc) as '2019',
--(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2020'	group by MONTH(DatInc) order by sum(Valor) desc) as '2020'
--from Vendas
--Go

SELECT YEAR(ven1.DatInc),
(	SELECT TOP 1 MONTH(ven.DatInc)
        FROM Vendas ven
        WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
  GROUP BY MONTH(ven.DatInc)
  ORDER BY SUM(ven.Valor) DESC)
FROM Vendas ven1
GROUP BY YEAR(ven1.DatInc)
GO


--Trazer o valor total de vendas que Felipe realizou
select sum(v.Valor) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario = 'Felipe'
	where v.UsuInc =  u.Id
	group by u.Usuario
Go

--Trazer o valor total de vendas que Giomar realizou
select sum(v.Valor * v.Quantidade) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario like 'Giomar'
	where v.UsuInc =  u.Id
	group by u.Usuario
Go
--Trazer a quantidade total de vendas que Felipe realizou
select sum(v.Quantidade) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario like 'Felipe'
	where v.UsuInc =  u.Id
	group by u.Usuario
Go

--Trazer a quantidade de vendas que Giomar realizou
select sum(v.Quantidade) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario like 'Giomar'
	where v.UsuInc =  u.Id
	group by u.Usuario
Go

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select sum(v.Quantidade) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario like 'Giomar' or u.Usuario like 'Felipe'
	where v.UsuInc =  u.Id
	group by u.Usuario
	order by sum(v.Quantidade) desc
Go
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select sum(v.Quantidade) as 'Total Vendas', u.Usuario as 'Usuário' from Vendas v
	inner join Usuarios u on u.Usuario like 'Giomar' or u.Usuario like 'Felipe'
	where v.UsuInc =  u.Id
	group by u.Usuario
	order by sum(v.Quantidade) desc
Go

--Trazer  a marca mais vendida de todos os anos
--		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
Select top 1 m.Nome as 'Marca', count(m.Id) as 'Qtde Vendida' from Carros c 
	inner join Marcas m on m.Id = c.Marca
	inner join Vendas v on v.Carro = c.Id
	group by m.Nome, c.Marca
	order by count(m.Id) desc
Go
--Trazer o valor total da marca mais vendida de todos os anos	
select top 1 sum(v.Valor*v.Quantidade) as 'Vendas Total $', m.Nome as 'Marca +Vendida'
	from Carros c
	inner join Marcas m on m.Id = c.Marca
	inner join Vendas v on v.Carro = c.Id
	group by m.Nome
	order by sum(v.Valor) desc 

--Trazer a quantidade do carro mais vendido de todos os anos
select top 2 sum(v.Quantidade) as 'Vendas Total (Unid)', c.Modelo as 'Carro +Vendido', c.Id as 'Codigo'
	from Carros c	
	inner join Vendas v on v.Carro = c.Id
	group by c.Modelo, c.Id
	order by sum(v.Quantidade*v.Valor) desc 

--Trazer o valor do carro mais vendido de todos os anos
select avg(v.Valor), sum(v.Quantidade) as 'Vendas Total (Unid)', c.Modelo as 'Carro +Vendido', c.Id as 'Codigo'
	from Carros c	
	inner join Vendas v on v.Carro = c.Id
	group by c.Modelo, c.Id
	order by sum(v.Quantidade) desc 




--Estudo //incompleto
--declare @MarcaTop int;
--set @MarcaTop = (Select top 1 count(m.Id) as veicId from Carros c 
--	inner join Marcas m on m.Id = c.Marca
--	inner join Vendas v on v.Carro = c.Id
--	group by c.Marca
--	order by count(m.Id) desc) 
--Select @MarcaTop from Vendas