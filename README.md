# Funcionalidades del código
En este codigo se podra ingresar datos de alumnos y asignaturas las cuales seran guardadas en una base de datos que tendran crear ustedes mismos


## Para crear la base de datos
Para que pueda crear la base de datos en su computador tendra que utilizar las siguientes lineas de código las cuales podran ayudar para almacenar los datos

`CREATE DATABASE BaseDeDatosEscuela;`

`USE BaseDeDatosEscuela;`

`CREATE TABLE Alumnos (
    IDAlumno INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    ApellidoPat NVARCHAR(100),
    ApellidoMat NVARCHAR(100),
    Email NVARCHAR(100),
    NumeroMatricula NVARCHAR(20)
);`

`CREATE TABLE Asignaturas (
    CodigoAsignatura INT PRIMARY KEY IDENTITY(1,1),
    NombreAsignatura NVARCHAR(100),
    Creditos INT
);`
