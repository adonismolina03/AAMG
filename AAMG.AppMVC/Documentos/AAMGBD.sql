CREATE DATABASE AAMGDB
USE AAMGDB
CREATE TABLE mascotas(
Id int identity(1,1) primary key,
Nombre varchar(50),
Tipo varchar(50),
Raza varchar(50),
Edad int,
Dueño varchar(50),
Antecedentes varchar(300)
)
