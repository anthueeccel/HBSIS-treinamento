create table PLayList(
Id int identity(1,1) primary key,
Nome nvarchar(50),
Artista nvarchar(50),
Genero nvarchar(20)
);

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
('Marcha Fúnibre','Frédéric Choppin','Classic')
