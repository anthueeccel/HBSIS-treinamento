USE SeasonFinaleDb
CREATE TABLE Usuario(
Id INT Primary Key Identity(1,1),
Nome nvarchar(50),
[Login] nvarchar(50),
Senha nvarchar(50),
Email nvarchar(50),
);

