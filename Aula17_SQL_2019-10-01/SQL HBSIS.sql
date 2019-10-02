IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='BaseDeDadosHbsis' and xtype='U')
CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis
GO
-- Tipo: [1] Moto [2] Carro
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Tipos' and xtype='U')
CREATE TABLE Tipos(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Codigo INT NOT NULL,
	Tipo NCHAR(20), 
	Ativo BIT DEFAULT 1,
	UsuarioCriacao NCHAR(50) DEFAULT 0,
	UsuarioAlteracao NCHAR(50) DEFAULT 0,
	DataCriacao DATETIME DEFAULT getdate(),
	DataAlteracao DATETIME DEFAULT getdate()
	
)
GO
-- Tabela de Marcas de veículos
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Marcas' and xtype='U')
CREATE TABLE Marcas(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Codigo INT, 
	CodigoTipo INT NOT NULL, -- 2
	Marca NCHAR(20), -- Audi
	Ativo BIT DEFAULT 1,
	UsuarioCriacao NCHAR(50) DEFAULT 0,
	UsuarioAlteracao NCHAR(50) DEFAULT 0,
	DataCriacao DATETIME DEFAULT getdate(),
	DataAlteracao DATETIME DEFAULT getdate()	
) 
GO
-- Tabela de Modelos de veículos
IF NOT EXISTS(SELECT * FROM sysobjects WHERE NAME='Modelos' and xtype='U')
CREATE TABLE Modelos(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Codigo INT, 
	CodigoMarca INT NOT NULL,
	Modelo NCHAR(30),
	Ativo BIT DEFAULT 1,
	UsuarioCriacao NCHAR(50) DEFAULT 0,
	UsuarioAlteracao NCHAR(50) DEFAULT 0,
	DataCriacao DATETIME DEFAULT getdate(),
	DataAlteracao DATETIME DEFAULT getdate()
)
GO
--Insere os dados na tabela Tipos se esta existir
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Tipos' and xtype='U')
INSERT INTO Tipos
(Codigo, Tipo) VALUES
(1, 'Moto'),
(2, 'Carro')
GO

-- Insere os dados na tabela Marcas se esta existir
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Marcas' and xtype='U')
INSERT INTO Marcas
(Codigo, CodigoTipo, Marca) VALUES
(1, 1, 'Dafra'),
(2, 1, 'Honda'),
(1, 2, 'Audi'),
(2, 2, 'BMW'),
(3, 2, 'Chevrolet')
GO

-- Insere os dados na tabela Modelos se esta existir
IF EXISTS(SELECT * FROM sysobjects WHERE NAME='Modelos' and xtype='U')
INSERT INTO Modelos
(Codigo, CodigoMarca, Modelo) VALUES
(1, 1, 'Apache'),
(2, 2, 'CBR 600'),
(3, 1, 'A5'),
(4, 2, 'Série 1 Coupé'),
(5, 3, 'Prisma')
GO


--Lista de Motos 'Kawasaki', se não existir inserir.
IF EXISTS(SELECT Id FROM Modelos WHERE CodigoMarca = 5)
	SELECT ti.Tipo, ma.Marca, mo.Modelo FROM Marcas  ma
		INNER JOIN Modelos mo ON mo.CodigoMarca = ma.Codigo
		INNER JOIN Tipos ti on ti.Codigo = ma.CodigoTipo
		WHERE ma.Codigo = 5 AND ti.Codigo = 1
ELSE
	IF NOT EXISTS(SELECT Id FROM Marcas WHERE Marca = 'Kawasaki')
		INSERT INTO MARCAS
		(Codigo, CodigoTipo, Marca) VALUES 
		(5, 1, 'Kawasaki')
		
		INSERT INTO Modelos(Codigo, CodigoMarca, Modelo) VALUES 
		(1,5,'Concours'),
        (2,5,'D tracker x'),
        (3,5,'ER 5'),
        (4,5,'ER 6n'),
        (5,5,'KLX'),
        (6,5,'KX'),
        (7,5,'KZ'),
        (8,5,'Maxi II'),
        (9,5,'Ninja'),
        (10,5,'Versys'),
        (11,5,'Voyager'),
        (12,5,'Vulcan'),
        (13,5,'Z 1000'),
        (14,5,'Z 300'),
        (15,5,'Z 650'),
        (16,5,'Z 750'),
        (17,5,'Z 800'),
        (18,5,'Z 900')	
Go

--Lista de Carros 'Kia', se não existir inserir.
IF EXISTS(SELECT Codigo FROM Marcas WHERE Marca ='Kia')
	SELECT ti.Tipo, ma.Marca, mo.Modelo FROM Marcas  ma
		INNER JOIN Modelos mo ON mo.CodigoMarca = ma.Codigo
		INNER JOIN Tipos ti on ti.Codigo = ma.CodigoTipo
		WHERE ma.Codigo = 10 AND ti.Codigo = 2
ELSE
	INSERT INTO Marcas(Codigo, CodigoTipo, Marca) VALUES
	(10, 2, 'Kia')
	INSERT INTO  Modelos(Codigo, CodigoMarca, Modelo) VALUES
    (1,10,'Besta  '),
    (2,10,'Bongo  '),
    (3,10,'Cadenza'),
    (4,10,'Carens '),
    (5,10,'Carnival'),
    (6,10,'Cerato '),
    (7,10,'Ceres  '),
    (8,10,'Clarus '),
    (9,10,'Grand Carnival'),
    (10,10,'Magentis'),
    (11,10,'Mohave '),
    (12,10,'Opirus '),
    (13,10,'Optima '),
    (14,10,'Picanto'),
    (15,10,'Quoris '),
    (16,10,'Rio	  '),
    (17,10,'Sephia '),
    (18,10,'Shuma  '),
    (19,10,'Sorento'),
    (20,10,'Soul	  '),
    (21,10,'Sportage'),
    (22,10,'Stinger')
Go
