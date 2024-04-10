create database Legana_Database
go

USE Legana_Database

GO

CREATE TABLE TIPO_PERSONA(
IdTipoPersona  int primary key,
Descripcion varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE PERSONA(
IdPersona int primary key identity,
Codigo varchar(15),
Nombre varchar(50),
Contacto varchar(30),
Comentarios varchar(50),
Clave varchar(50),
IdTipoPersona int references TIPO_PERSONA(IdTipoPersona),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE PROVEEDOR(
IdProveedor int primary key identity,
Codigo varchar(15),
Nombre varchar(50),
Contacto varchar(50),
Comentarios varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE PRODUCTO(
IdProducto int primary key identity,
Codigo varchar(20),
Descripcion varchar(30),
Categoria varchar(30),
Stock int default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit default 1,
FechaCreacion datetime default getdate()
)

GO 

create table COMPRA(
IdCompra int primary key identity(1,1),
IdProveedor int references PROVEEDOR(IdProveedor),
MontoTotal decimal(10,2) default 0,
Codigo varchar(50),
FechaRegistro datetime default getdate()
)

go

create table DETALLE_COMPRA(
IdDetalleCompra int primary key identity(1,1),
IdCompra int references COMPRA(IdCompra),
IdProducto int references Producto(IdProducto),
Cantidad int,
PrecioCompra decimal(10,2),
PrecioVenta decimal(10,2),
Total decimal(10,2),
FechaRegistro datetime default getdate()
)



go 


create table VENTA(
IdVenta int primary key identity(1,1),
Codigo varchar(100),
IdUsuario int references PERSONA(IdPersona),
CodigoCliente varchar(50),
NombreCliente varchar(50),
TotalPagar  decimal(10,2),
FechaRegistro datetime default getdate()
)

go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity(1,1),
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int,
PrecioVenta decimal(10,2),
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)

go


