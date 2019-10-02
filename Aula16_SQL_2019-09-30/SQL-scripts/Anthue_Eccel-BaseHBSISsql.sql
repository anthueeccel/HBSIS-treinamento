CREATE DATABASE BaseSistemaLocacao -- Criamos nossa base de dados 
Go
USE BaseSistemaLocacao -- indicamos que estamos utilizando ela para os comandos logo a baixo
Go
create table Usuarios
(
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (10)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

create table Marcas
(
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

create table Carros
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NULL,
    [MarcaCodigo]      INT        NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

create table Locacoes
(
	[Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NULL,
    [CarroId]          INT      NULL,
    [Valor]            MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
Go

insert into Usuarios ([Nome],[Login],[Senha])
values ('Administrador','Admin','Admin')
Go

SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (1, 1, N'Volkswagem          ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (2, 2, N'Fiat                ')
SET IDENTITY_INSERT [dbo].[Marcas] OFF


