CREATE DATABASE BaseDeDatosEscuela;

USE BaseDeDatosEscuela;

CREATE TABLE Alumnos (
    IDAlumno INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    ApellidoPAt NVARCHAR(100),
    ApellidoMat NVARCHAR(100),
    Email NVARCHAR(100),
    NumeroMatricula NVARCHAR(20)
);

CREATE TABLE Asignaturas (
    CodigoAsignatura INT PRIMARY KEY IDENTITY(1,1),
    NombreAsignatura NVARCHAR(100),
    Creditos INT
);
