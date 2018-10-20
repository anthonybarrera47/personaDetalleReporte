drop DataBase PersonaDetalleReporte
Create DataBase PersonaDetalleReporte
GO
USE PersonaDetalleReporte
GO
create table Persona(
	
	PersonaID int primary key identity,
	Nombre varchar(30),
	Direccion varchar(30),
	Cedula varchar(30),
	FechaNacimiento datetime
);

Create table TipoTelefono(

	TipoID int primary key identity,
	TipoTelefonos varchar(30)

);
create table Telefono(

	TelefonoID int primary key identity,
	PersonaID int,
	TipoID int,
	Telefono varchar(15),
	CONSTRAINT fk_Persona FOREIGN KEY(PersonaID) REFERENCES Persona(PersonaID),
	CONSTRAINT fk_TipoTelefono FOREIGN KEY(TipoID) REFERENCES TipoTelefono(TipoID)
);
