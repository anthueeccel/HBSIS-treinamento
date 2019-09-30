--insert into Livros (Nome) values
--('Livro 1'),
--('Use a Cabeça C#'),
--('SQL for Dummies'), 
--('Vida de Programador'),
--('Programador. O que come, onde vive?')
GO
select Ativo from Livros where Nome is not null  Group by Ativo
--GO
update Livros set Ativo = 0 where Id = 4;

--delete from Livros where 1 = 1

select Id, Nome from Livros where Id = (
select (Max(Id)-1) from Livros where 1 = 1) and Ativo = 0