-- Nome do  usuário, Marca e ordena por ano.
select u.Nome as Usuario, 
	   c.Modelo, 
	   m.Nome Marca, 
	   c.Placa, 
	   c.Ano 
from Carros as c
left join Marcas as m on c.MarcaCodigo = m.Codigo
inner join Usuarios as u on c.UsuarioAlteracao = u.Id
order by c.Ano asc


-- Quantidade de carros em cada marca
select m.Nome, count(m.Nome) Qtde 
from Carros as c
right join Marcas as m on c.MarcaCodigo = m.Codigo
group by m.Nome


INSERT INTO Carros (Modelo, MarcaCodigo, Placa, Ano, UsuarioCriacao) VALUES
('Fusca',1, 'MMS2321', 1987, 1)


