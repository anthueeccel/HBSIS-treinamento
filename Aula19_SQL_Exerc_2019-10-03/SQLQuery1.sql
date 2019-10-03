select 
Nome, 
(select sum(Valor)
	from Salarios
	where Funcionario = Funcionarios.Id)
from Funcionarios;

select 
 f.Nome,
 avg(s.Valor) as 'Total (3 meses)',
 count(s.Valor) as 'Qtde Pagtos',
 SUM(s.Valor) / count(s.Valor) as 'Média mensal', 
 SUM(s.Valor) as 'Total'
From Funcionarios f
	inner join Salarios s ON s.Funcionario = f.Id
	--where s.DataCriacao > '07/01/2019' and s.DataCriacao < '07/30/2019'
	--where s.DataCriacao between '07/01/2019' and '07/30/2019'
group by f.Nome
	--having f.Nome = 'Tiburcio'
order by sum(s.Valor) desc


-- Primeiros 5 resultados
select top 5 * from Salarios

-- atualiza/alterar o status ativo para 0, data de saída e a data de alteração.
update Funcionarios
 set DataSaida = '10/03/2019', 
     DataAlteracao = GETDATE(), 
	 Ativo = 0 
 where Nome like 'joão%'
 
 -- Converte a data para pt-Br
 select 
 Nome, 
 CONVERT(VARCHAR(10), DataAlteracao, 103) as Início,
 CONVERT(VARCHAR(10), DataSaida, 103) as Saída
 from Funcionarios


