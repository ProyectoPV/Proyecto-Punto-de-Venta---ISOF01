USE Legana_Database

GO

--PROCEDIMIENTO PARA GUARDAR PERSONA
create PROC sp_RegistrarPersona(
@Codigo varchar(50),
@Nombre varchar(50),
@Contacto varchar(30),
@Comentarios varchar(50),
@Clave varchar(50),
@IdTipoPersona int,
@Resultado int output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM persona WHERE Codigo = @Codigo)
	begin
		insert into persona(Codigo,Nombre,Contacto,Comentarios,Clave,IdTipoPersona) values (
		@Codigo,@Nombre,@Contacto,@Comentarios,@Clave,@IdTipoPersona)

		set @Resultado = SCOPE_IDENTITY()
	end
	
end

go

--PROCEDIMIENTO PARA MODIFICAR PERSONA
create procedure sp_ModificarPersona(
@IdPersona int,
@Codigo varchar(50),
@Nombre varchar(50),
@Contacto varchar(30),
@Comentarios varchar(50),
@Clave varchar(50),
@IdTipoPersona int,
@Resultado bit output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM persona WHERE Codigo =@Codigo and IdPersona != @IdPersona)
		
		update PERSONA set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Contacto = @Contacto,
		Comentarios = @Comentarios,
		IdTipoPersona = @IdTipoPersona
		where IdPersona = @IdPersona
	ELSE
		SET @Resultado = 0

end


GO

--PROCEDIMIENTO PARA GUARDAR PROVEEDOR
create PROC sp_RegistrarProveedor(
@Codigo varchar(50),
@Nombre varchar(50),
@Contacto varchar(50),
@Comentarios varchar(50),
@Resultado int output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Codigo = @Codigo)
	begin
		insert into PROVEEDOR(Codigo,Nombre,Contacto,Comentarios) values (
		@Codigo,@Nombre,@Contacto,@Comentarios)

		set @Resultado = SCOPE_IDENTITY()
	end
	
end

go


--PROCEDIMIENTO PARA MODIFICAR PROVEEDOR
create procedure sp_ModificarProveedor(
@IdProveedor int,
@Codigo varchar(50),
@Nombre varchar(50),
@Contacto varchar(50),
@Comentarios varchar(50),
@Resultado bit output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Codigo =@Codigo and IdProveedor != @IdProveedor)
		
		update PROVEEDOR set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Contacto = @Contacto,
		Comentarios = @Comentarios
		where IdProveedor = @IdProveedor
	ELSE
		SET @Resultado = 0

end


GO


--PROCEDIMIENTO PARA GUARDAR PRODUCTO
create PROC sp_RegistrarProducto(
@Codigo varchar(20),
@Descripcion varchar(30),
@Categoria varchar(30),
@Resultado int output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
	begin
		insert into producto(Codigo,Descripcion,Categoria) values (@Codigo,@Descripcion,@Categoria)

		set @Resultado = SCOPE_IDENTITY()
	end
	
end

go

--PROCEDIMIENTO PARA MODIFICAR PRODUCTO
create procedure sp_ModificarProducto(
@IdProducto int,
@Codigo varchar(20),
@Descripcion varchar(30),
@Categoria varchar(30),
@Resultado bit output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo =@Codigo and IdProducto != @IdProducto)
		
		update PRODUCTO set
		codigo = @Codigo,
		Descripcion = @Descripcion,
		Categoria = @Categoria
		where IdProducto = @IdProducto
	ELSE
		SET @Resultado = 0

end

