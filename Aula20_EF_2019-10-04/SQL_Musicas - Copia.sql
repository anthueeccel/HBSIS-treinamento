-- cria a tabela Playlist
IF NOT EXISTS(Select * from sys.objects where Name='PlayList' and type='U')
create table PLayList(
Id int identity(1,1) primary key,
Nome nvarchar(50),
Artista nvarchar(50),
Genero nvarchar(20)
);

-- Primeiro insert de músicas
IF EXISTS(Select * from sys.objects where Name='PlayList' and type='U')
insert into PlayList
(Nome, Artista, Genero) values
('Bohemian Rapsody','Queen','Rock'),
('Radio Ga Ga','Queen','Rock'),
('November Rain','Guns N´ Roses','Rock'),
('Born to Be Wild','Steppenwolf','Rock'),
('Diamons','Rihanna','Pop'),
('Beat it','Michael Jackson','Pop'),
('Girls like You','Maroon 5','Pop'),
('Nona Sinfonia','Ludwig van Bethoven','Classic'),
('Quatro Estações','Vivaldi','Classic'),
('Marcha Fúnebre','Frédéric Chopin','Classic')
Go

-- Atualiza um item da Playlist onde Artista é Frédéric Chopin
IF EXISTS(Select * from sys.objects where Name='PlayList' and type='U')
UPDATE PlayList set  Nome = 'Marcha Fúnebre',Artista = 'Frédéric Chopin',Genero = 'Classic'
where Artista = 'Frédéric Choppin'
Go

-- Mostra e agrupa por Genero
select distinct Genero from PlayList
Go

--Segundo insert de músicas 
IF EXISTS(Select * from sys.objects where Name='PlayList' and type='U')
insert into PlayList
(Nome, Artista, Genero) values
('We Will Rock You','Queen','Rock'),
('We Are The Champions','Queen','Rock'),
('Another Bick in The Wall','Pink Floid','Rock'),
('Seven Nation Army','The White Stripes','Rock'),
('Für Elise','Ludwig van Bethoven','Classic'),
('Delicate','Taylor Swift','Pop'),
('Take It Off','Taylor Swift','Pop'),
('La Isla Bonita','Madona','Pop'),
('Like a Prayer','Madona','Pop')
Go

Select Genero from PLayList
	group by Genero

