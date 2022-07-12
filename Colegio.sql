----------------------------------------------------------------------
-- BASE DE DATOS : Colegio
----------------------------------------------------------------------
Use Master
GO

DROP DATABASE IF EXISTS Colegio
go
create database Colegio
GO
USE Colegio
GO
create table Alumnos
(Id int primary key identity(1,1),
p_nombre varchar (25),
s_nombre varchar (25),
p_apellido varchar (25),
s_apellido varchar (25),
telefono int,
celular int,
direccion varchar (25),
email varchar (25),
fec_nac date,
observ varchar (25))
go
insert Alumnos values ('Jorge','Almiron','Morey','Diaz',4598457,995487548,'Av. 28 de Julio','jorgee@hotmail.com','1990/04/05','estudioso')
insert Alumnos values ('Luis','Juan','Chavez','Verde',4587541,995842514,'Jr. Ucayali','luis99645@hotmail.com','1998/09/06','no hace tarea')
insert Alumnos values ('Valeria','Lisa','Vargas','Diaz',4512565,995225256,'Jr. Callao','valeri@hotmail.com','2000/10/08','puntual')
go
--SELECT * FROM Alumnos

/*Procedimiento*/

create proc MostrarAlumnos
as
SELECT * FROM Alumnos
go

create proc InsertarAlumnos
@p_nombre varchar (25),
@s_nombre varchar (25),
@p_apellido varchar (25),
@s_apellido varchar (25),
@telefono int,
@celular int,
@direccion varchar (25),
@email varchar (25),
@fec_nac date,
@observ varchar (25)
as
insert Alumnos values (@p_nombre,@s_nombre,@p_apellido,@s_apellido,@telefono,@celular,@direccion,@email,@fec_nac,@observ)
go


create proc EditarAlumnos
@p_nombre varchar (25),
@s_nombre varchar (25),
@p_apellido varchar (25),
@s_apellido varchar (25),
@telefono int,
@celular int,
@direccion varchar (25),
@email varchar (25),
@fec_nac date,
@observ varchar (25),
@id int
as
update Alumnos set p_nombre=@p_nombre,s_nombre=@s_nombre,p_apellido=@p_apellido,s_apellido=@s_apellido,telefono=@telefono,celular=@celular,direccion=@direccion,email=@email,fec_nac=@fec_nac,observ=@observ
where Id=@id
go

create proc EliminarAlumnos
@idalumno int
as
delete from Alumnos where Id=@idalumno
go

--exec MostrarAlumnos
--exec InsertarAlumnos 'simon','pablo','lara','beltr',4538493,998845434,'urb. mangomarca','simon@hotmail.com','1997/03/12','buenisimo'
--exec EditarAlumnos 'NOSIMON','NOPABLO','NON','SI',4587458,998565425,'urb. TEMPLO','nosimon@hotmail.com','1999/03/12','MALISIMO',4
--exec EliminarAlumnos 5