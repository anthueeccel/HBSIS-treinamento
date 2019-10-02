CREATE TABLE Clientes (
Id INT PRIMARY KEY IDENTITY(1,1),
Nome NVARCHAR(50) NOT NULL,
Genero INT NOT NULL,
Idade INT, 
Ativo BIT DEFAULT 1,
UsuarioCriacao INT DEFAULT 0,
UsuarioAlteracao INT DEFAULT 0,
DataCriacao DATETIME DEFAULT getdate(),
DataAlteracao DATETIME DEFAULT getdate(),
)
GO
CREATE TABLE Pedidos (
Id INT  NOT NULL PRIMARY KEY IDENTITY(1,1),
Numero NVARCHAR(10),
ClienteId INT NOT NULL,
Valor MONEY,
Ativo BIT DEFAULT 1,
UsuarioCriacao INT DEFAULT 0,
UsuarioAlteracao INT DEFAULT 0,
DataCriacao DATETIME DEFAULT getdate(),
DataAlteracao DATETIME DEFAULT getdate(),
CONSTRAINT FK_Pedidos_to_Clientes 
	FOREIGN KEY  (ClienteId)
	REFERENCES Clientes(Id)
)
GO