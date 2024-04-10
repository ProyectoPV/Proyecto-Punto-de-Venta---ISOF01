USE Legana_Database

GO
insert into TIPO_PERSONA(IdTipoPersona, Descripcion) values
(1,'Administrador'),
(2,'Empleado')

go


insert into PERSONA(Codigo,nombre,clave,IdTipoPersona) values
('1010','Admin','123',1),
('2020','Empleado','456',2)

GO

insert into PRODUCTO(Categoria) values
	('Alimentos Secos'),
	('Productos Enlatados'),
	('Productos Lacteos'),
	('Carnes y Embutidos'),
	('Panaderia y Pasteleria'),
	('Limpieza del Hogar'),
	('Higiene Personal'),
	('Bebidas'),
	('Aperitivos'),
	('Papeleria'),
	('Ferreteria'),
	('Farmacia'),
	('Miselaneos')
	
go

