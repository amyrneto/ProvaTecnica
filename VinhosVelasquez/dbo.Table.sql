CREATE TABLE [dbo].Clientes
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] NCHAR(50) NOT NULL, 
    [cpf] NCHAR(14) NULL
)
