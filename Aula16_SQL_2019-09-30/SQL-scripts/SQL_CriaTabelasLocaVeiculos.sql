-- Cria a base de dados
CREATE DATABASE BaseSistemaLocacao
GO
-- Utiliza a base recém-criada.
USE BaseSistemaLocacao
GO
-- Verifica se a tabela já existe para evitar erro no script.
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Usuarios' and xtype='U')
CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nome NCHAR (100) NULL,
	[Login] NCHAR (50)  NULL,
	Senha NCHAR (50)  NULL,
	Ativo BIT DEFAULT ((1)) NULL,
	UsuarioCriacao INT DEFAULT ((0)) NULL,
	UsuarioAlteracao INT DEFAULT ((0)) NULL,
	DataCriacao DATETIME DEFAULT (getdate()) NULL,
	DataAlteracao DATETIME DEFAULT (getdate()) NULL,	
) 
GO
-- Verifica se a tabela já existe para evitar erro no script.
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Marcas' and xtype='U')
CREATE TABLE Marcas 
(
	Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    Codigo INT NULL,
    Nome NCHAR (20) NULL,
)
GO
-- Verifica se a tabela já existe para evitar erro no script.
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Carros' and xtype='U')
CREATE TABLE Carros
(
	Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    Modelo NCHAR (50) NULL,
    MarcaCodigo INT NULL,
    Placa NCHAR (7) NULL,
    Ano INT NULL,
    Ativo BIT DEFAULT ((1)) NULL,
    UsuarioCriacao INT DEFAULT ((0)) NULL,
    UsuarioAlteracao INT DEFAULT ((0)) NULL,
    DataCriacao DATETIME DEFAULT (getdate()) NULL,
    DataAlteracao DATETIME DEFAULT (getdate()) NULL,
	
)
GO
-- Verifica se a tabela já existe para evitar erro no script.
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Locacaoes' and xtype='U')
CREATE TABLE Locacoes (
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    UsuarioId INT NULL,
    CarroId INT NULL,
    Valor MONEY NULL,
    DataInicial DATETIME DEFAULT (getdate()) NULL,
    DataDevolucao DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    Ativo BIT DEFAULT ((1)) NULL,
    UsuarioCriacao INT DEFAULT ((0)) NULL,
    UsuarioAlteracao INT DEFAULT ((0)) NULL,
    DataCriacao DATETIME DEFAULT (getdate()) NULL,
    DataAlteracao DATETIME DEFAULT (getdate()) NULL,
);
GO

-- Inserção de dados na tabela Usuarios após verificação da existência da tabela
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Usuarios' and xtype='U')
IF NOT EXISTS(SELECT Nome from Usuarios Where Nome = 'Admin')
INSERT INTO Usuarios
	(Nome, [Login], Senha, Ativo, UsuarioCriacao) values
	('Admin', 'admin', 'admin', 1, 1)
ELSE 
UPDATE Usuarios set Nome = 'Admin', [Login] =  'admin', Senha = 'admin', Ativo = 1, UsuarioAlteracao = 2
	WHERE Nome = 'Admin'
GO

-- Inserção de dados na tabela Marcas após verificação da existência da tabela
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Marcas' and xtype='U')
INSERT INTO Marcas
	(Codigo, Nome) values
	(1, 'Chevrolet'),
	(2, 'Fiat'),
	(3, 'Ford'),
	(4, 'Renault')
GO

--Inserção de dados na tabela Carros após verificação da existência da tabela
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Carros' and xtype='U')
INSERT INTO Carros
	(Modelo, MarcaCodigo, Placa, Ano, Ativo, UsuarioCriacao) values
	('Cruze', 1, 'MMM1234', 2018, 1, 1),
	('Argo', 2, 'MLQ2233', 2017, 1, 1 ),
	('Fiesta', 3, 'ZZL4324', 2019, 1, 1),
	('Sandero', 4, 'ABC8989', 2016, 1, 1)
GO