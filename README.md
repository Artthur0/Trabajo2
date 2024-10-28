# Funcionalidades del código
En este codigo se podra ingresar datos de alumnos y asignaturas las cuales seran guardadas en una base de datos que tendran crear ustedes mismos


## Para crear la base de datos (En caso de no querer ver el archivo .scrip)
Para que pueda crear la base de datos en su computador tendra que utilizar las siguientes lineas de código las cuales podran ayudar para almacenar los datos

- [Codigo para modificar](Trabajo2/DatabaseConnection.cs)

  - Aqui en debe poner su propia base de datos en la linea 11, donde debe poner su propio Data source, el cual se obtiene al conectarlo al SQL Server

- Codigo SQL

En esta parte es el codigo que debe poner en su base de datos para poder crear las tablas

`CREATE DATABASE BaseDeDatosEscuela;`

`USE BaseDeDatosEscuela;`

`CREATE TABLE Alumnos (
    IDAlumno INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    ApellidoPat NVARCHAR(100) NOT NULL,
    ApellidoMat NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    NumeroMatricula NVARCHAR(20) NOT NULL
);`

`CREATE TABLE Asignaturas (
    CodigoAsignatura INT PRIMARY KEY IDENTITY(1,1),
    NombreAsignatura NVARCHAR(100) NOT NULL,
    Creditos INT NOT NULL
);`
