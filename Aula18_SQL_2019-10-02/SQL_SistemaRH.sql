--/*
--2 - Vamos criar com base da estrutura  mostrada logo a  baixo 
--em uma nova base com nome de "SistemaRH" essa base terá a seguinte estrutura

--Tabela de Salarios 
--    Id,Funcionario,Valor, informações de controle...
--Tabela de Funcionarios
--    Id,Nome,DataInicio,DataSaida, informações de controle...

--2.1 - Vamos cadastrar 3 funcionários dentro de nossa tabela de Funcionarios
--2.2 - Temos que inserir  para cada funcionário as folhas de pagamento dos 
--respectivos meses de trabalho deste ano 7,8,9  sabendo que os salarios 
--sempre são pagos no 5 dia util de cada  mês
--*/

--CREATE DATABASE SistemaRH
--GO
--CREATE TABLE Funcionarios(
--Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
--Nome NVARCHAR(50),
--DataInicio DATETIME DEFAULT GETDATE(),
--DataSaida DATETIME DEFAULT (MONTH, 3, GETDATE()), --Mínimo período de experiência
--Ativo BIT DEFAULT ((1)),
--UsuarioCriacao INT DEFAULT ((0)),
--UsuarioAlteracao INT DEFAULT ((0)),
--DataCriacao DATETIME DEFAULT (getdate()),
--DataAlteracao DATETIME DEFAULT (getdate())
--)
--GO
--CREATE TABLE Salarios(
--Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
--Funcionario INT NOT NULL,
--Valor MONEY,
--Ativo BIT DEFAULT ((1)),
--UsuarioCriacao INT DEFAULT ((0)),
--UsuarioAlteracao INT DEFAULT ((0)),
--DataCriacao DATETIME DEFAULT (getdate()),
--DataAlteracao DATETIME DEFAULT (getdate())
--CONSTRAINT FK_Salarios_to_Funcionarios FOREIGN KEY (Funcionario)
--	REFERENCES Funcionarios(Id)
--)
--GO

--INSERT INTO Funcionarios(Nome)
--VALUES ('Giomar'),('Tiburcio'),('João')
--GO

-- Insere os dados na Tabela Salário no 5º dia útil dos meses 7, 8, 9/2019.
INSERT INTO Salarios(Funcionario, Valor, DataCriacao) VALUES
(1, 2300,'07/05/2019'), (1, 2500,'08/07/2019'), (1, 2460,'09/06/2019'),
(2, 8350,'07/05/2019'), (1, 8500,'08/07/2019'), (2, 8130,'09/06/2019'),
(3, 3200,'07/05/2019'), (3, 3500,'08/07/2019'), (3, 3150,'09/06/2019')
GO

