CREATE DATABASE BDMuebles
GO

USE BDMuebles

CREATE TABLE Clientes
(
	cedula CHAR(10) PRIMARY KEY,
	nombre	VARCHAR(50),
	apellido VARCHAR(50),
	ciudad VARCHAR(30),
	edad INT,
	fecha_nacimiento DATE,
	correo_electronico VARCHAR(50) UNIQUE,
	contrasenia VARCHAR(50),
	tipo_user VARCHAR(15) CHECK (tipo_user IN ('Cliente','Administrador'))
);

CREATE TABLE Muebles
(
	id_mueble INT  PRIMARY KEY,
	nombre VARCHAR(100),
	tipo VARCHAR(100),
	material VARCHAR(50),
	color VARCHAR(15),
	altura DECIMAL(10,2),
	ancho DECIMAL(10,2),
	profundidad DECIMAL(10,2),
	peso DECIMAL(10,2),
	estilo VARCHAR(100),
	precio_coste DECIMAL(10,2),
	precio_venta DECIMAL(10,2),
	cantidad_stock INT,
	foto varbinary(max),
	descripcion VARCHAR (200)
);

CREATE TABLE Compras
(
	id_compra INT IDENTITY PRIMARY KEY,
	fecha_compra DATE,
);

CREATE TABLE Compra_Clientes
(
	id_compra INT,
	cedula CHAR(10),
	CONSTRAINT FK_id_compra_cliente FOREIGN KEY (id_compra) REFERENCES Compras (id_compra) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_cedula FOREIGN KEY (cedula) REFERENCES Clientes (cedula) ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY (id_compra,cedula)
);

CREATE TABLE Compra_Muebles
(
	id_compra INT,
	id_mueble INT,
	CONSTRAINT FK_id_compra_mueble FOREIGN KEY (id_compra) REFERENCES Compras (id_compra) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_id_mueble FOREIGN KEY (id_mueble) REFERENCES Muebles (id_mueble) ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY (id_compra,id_mueble),
	cantidad INT,
	total DECIMAL (10,2)

);