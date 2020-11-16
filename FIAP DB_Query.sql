
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'FIAP')
BEGIN
CREATE DATABASE [FIAP]


END
GO

USE FIAP --DATABASE NAME
GO

CREATE TABLE Usuarios (
	
	ID INT PRIMARY KEY not null,
	NOME VARCHAR(50),
	EMAIL VARCHAR(50)
)

GO

CREATE TABLE Login (
	
	ID INT PRIMARY KEY not null,
	USERNAME VARCHAR(50),
	PASSWORD VARCHAR(50),
	SALT VARCHAR(50),
	ADMIN BIT NOT NULL DEFAULT 0
)
