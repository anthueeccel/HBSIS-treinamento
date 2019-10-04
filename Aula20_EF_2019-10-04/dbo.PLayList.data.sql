---- Listagem dos dados da tabela PlayList
--SET IDENTITY_INSERT [dbo].[PLayList] ON
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (1,  N'Bohemian Rapsody',			N'Queen',				2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (2,  N'Radio Ga Ga',				N'Queen',				2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (3,  N'November Rain',				N'Guns N´ Roses',		2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (4,  N'Born to Be Wild',			N'Steppenwolf',			2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (5,  N'Diamons',					N'Rihanna',				1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (6,  N'Beat it',					N'Michael Jackson',		1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (7,  N'Girls like You',				N'Maroon 5',			1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (8,  N'Nona Sinfonia',				N'Ludwig van Bethoven', 3)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (9,  N'Quatro Estações',			N'Vivaldi',				3)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (10, N'Marcha Fúnebre',				N'Frédéric Chopin',		3)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (11, N'We Will Rock You',			N'Queen',				2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (12, N'We Are The Champions',		N'Queen',				2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (13, N'Another Bick in The	Wall',	N'Pink Floid',			2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (14, N'Seven Nation Army',			N'The White Stripes',	2)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (15, N'Für Elise',					N'Ludwig van Bethoven', 3)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (16, N'Delicate',					N'Taylor Swift',		1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (17, N'Take It Off',				N'Taylor Swift',		1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (18, N'La Isla Bonita',				N'Madona',				1)
--INSERT INTO [dbo].[PLayList] ([Id], [Nome], [Artista], [Genero]) VALUES (19, N'Like a Prayer',				N'Madona',				1)
--SET IDENTITY_INSERT [dbo].[PLayList] OFF

-- Cria a tabela Artistas com Id, GeneroId e Nome
CREATE TABLE [dbo].[Artistas] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [GeneroId] INT           NOT NULL,
    [Nome]     NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Artistas_ToTable] FOREIGN KEY ([GeneroId]) REFERENCES [dbo].[Generos] ([Id])
);


-- Insere os dados na tabela Generos
INSERT INTO Generos(Nome) VALUES
('Pop'), ('Rock'), ('Classic')

-- Insere os dados na tabela Artistas
INSERT INTO Artistas(Nome, GeneroId) Values
('Queen',				2),
('Guns N´ Roses',		2),
('Steppenwolf',			2),
('Rihanna',				1),
('Michael Jackson',		1),
('Maroon 5',			1),
('Ludwig van Bethoven', 3),
('Vivaldi',				3),
('Frédéric Chopin',		3),
('Pink Floid',			2),
('The White Stripes',	2),
('Taylor Swift',		1),
('Madona',				1)
Go

-- Insere os dados na tabela Cancoes
INSERT INTO Cancoes(ArtistaId, Nome) VALUES
(1, 'Bohemian Rapsody'          ),
(1, 'Radio Ga Ga'				),
(2, 'November Rain'				),
(3, 'Born to Be Wild'			),
(4, 'Diamons'					),
(5, 'Beat it'					),
(6, 'Girls like You'			),	
(7, 'Nona Sinfonia'				),
(8, 'Quatro Estações'			),
(9,'Marcha Fúnebre'				),
(1,'We Will Rock You'			),
(1,'We Are The Champions'		),
(10,'Another Bick in The Wall'	),
(11,'Seven Nation Army'			),
(7,'Für Elise'					),
(12,'Delicate'					),
(12,'Take It Off'				),
(13,'La Isla Bonita'			),	
(13,'Like a Prayer'				)
Go

