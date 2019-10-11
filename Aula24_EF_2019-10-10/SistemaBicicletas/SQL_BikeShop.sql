create table Marcas(
Id int primary key identity(1,1),
Descricao nvarchar(20),
Ativo bit default ((1)),
userInclusao int default ((0)),
userAlteracao int default ((0)),
dataInclusao DATETIME  default (getdate()),
dataAlteracao DATETIME  default (getdate())

);

create table Modelos(
Id int primary key identity(1,1),
Descricao nvarchar(30),
MarcaId int,
Ativo bit default ((1)),
userInclusao int default ((0)),
userAlteracao int default ((0)),
dataInclusao DATETIME  default (getdate()),
dataAlteracao DATETIME  default (getdate())

constraint FK_Modelo_to_Marca Foreign Key (MarcaId) REFERENCES Marcas(Id)
);

create table Bicicletas(
Id int primary key identity(1,1),
Descricao nvarchar(50),
ModeloId int,
Ativo bit default ((1)),
userInclusao int default ((0)),
userAlteracao int default ((0)),
dataInclusao DATETIME  default (getdate()),
dataAlteracao DATETIME  default (getdate())

constraint FK_Bibicleta_to_Modelo Foreign Key (ModeloId) REFERENCES Modelos(Id)
);



