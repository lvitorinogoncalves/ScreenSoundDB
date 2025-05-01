dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update

    
CREATE DATABASE Screen_Sound;
GO

USE Screen_Sound;
GO

create table Artistas(
        Id INT PRIMARY KEY IDENTITY(1,1),
        Nome NVARCHAR(255) NOT NULL,
        Bio NVARCHAR(255) NOT NULL,
        FotoPerfil NVARCHAR(255) NOT NULL
);

create table Musicas(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL
);