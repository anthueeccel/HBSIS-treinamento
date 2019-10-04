select	g.Nome 'Gênero',
		a.Nome 'Artista',
		c.Nome 'Canção'
	from Generos g
	inner join Artistas a on g.Id = a.GeneroId
	inner join Cancoes c on a.Id = c.ArtistaId

select	g.Nome as 'Genero', 
		count(a.Nome) as 'Qtde Artistas'
	from Generos g
	inner join Artistas a ON g.Id = a.GeneroId
	group by g.Nome

select	g.Nome as 'Genero', 
		count(c.Nome) as 'Qtde Músicas'
	from Generos g
	inner join Artistas a ON g.Id = a.GeneroId
	inner join Cancoes c ON a.Id = c.ArtistaId
	group by g.Nome

