﻿--create table Usuarios(
--Id int not null primary key identity(1,1),
--Nome nchar(100),
--Login nchar(50),
--Senha nchar(50),
--Ativo bit default 1, 
--UsuarioCriacao int default 0,
--UsuarioAlteracao int default 0,
--DataCriacao datetime default GETDATE(), 
--DataAlteracao datetime default GETDATE()
--)
--go

--create table Carros(
--Id int not null primary key identity(1,1),
--Modelo nchar(50),
--Marca nchar(50),
--Placa nchar(7),
--Ano int,
--Ativo bit default 1, 
--UsuarioCriacao int default 0,
--UsuarioAlteracao int default 0,
--DataCriacao datetime default GETDATE(), 
--DataAlteracao datetime default GETDATE()
--)
--go

--create table Locacoes(
--Id int not null primary key identity(1,1),
--UsuarioId int,
--CarroId int,
--Valor money,
--DataInicial datetime default getdate(),
--DataDevolucao datetime default getdate(),
--Ativo bit default 1, 
--UsuarioCriacao int default 0,
--UsuarioAlteracao int default 0,
--DataCriacao datetime default GETDATE(), 
--DataAlteracao datetime default GETDATE()
--)
--go

--BONUS teste
--insert into Locacoes(UsuarioId, CarroId, Valor) values
--(0, 0, 100)
--go
--update Locacoes set Ativo = 0 where id = 1
--go
select * from Locacoes;
