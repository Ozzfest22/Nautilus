create database GymNautilus
go

use GymNautilus	
go

create table Cliente(
IdCliente int primary key identity (1,1),
Nombre varchar (100),
Apellidos varchar(100),
Dni varchar(10) ,
Edad int ,
Sexo int ,
Distrito int ,
FechaNacimiento date,
Email varchar(50),
Contrasena varchar(20),
Telefono varchar(10) ,
Estado int default 17 ,
FechaRegistro date default GETDATE()
)
go

create table Trabajador(
IdTrabajador int primary key identity (1,1),
Nombre varchar (100),
Apellidos varchar(100),
Dni varchar(10) ,
Edad int ,
Sexo int ,
Distrito int ,
FechaNacimiento date,
Email varchar(50),
Contrasena varchar(20),
Telefono varchar(10) ,
Estado int default 1 ,
FechaRegistro date default GETDATE()
)
go

insert into Trabajador(Nombre,Apellidos,Dni,Edad,Sexo,Distrito,FechaNacimiento,Email,Contrasena,Telefono) values ('Toffie','Miranda','7893637'
,3,3,2,'08/30/2015','toffie@gmail.com','123456','2626775');

create table Clases(
IdClases int primary key identity (1,1),
NombreClase varchar(50),
Estado int default 1
)
go

insert into Clases(NombreClase) values ('Kickboxing');
insert into Clases(NombreClase) values ('Fullbody');
insert into Clases(NombreClase) values ('CrossFit');
insert into Clases(NombreClase) values ('Aerobox');
insert into Clases(NombreClase) values ('Zumba');
insert into Clases(NombreClase) values ('Spinning');
insert into Clases(NombreClase) values ('Musculacion');
insert into Clases(NombreClase) values ('Fitness');
insert into Clases(NombreClase) values ('Yoga');
insert into Clases(NombreClase) values ('Pilates');

create table Horarios(
IdHorario int primary key identity (1,1),
Instructor varchar(50) ,
Hora varchar(30),
Dia varchar(20),
Estado int default 27,
IdClases int FOREIGN KEY REFERENCES Clases(IdClases),
IdTrabajador int FOREIGN KEY REFERENCES Trabajador(IdTrabajador)
)
go

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Lunes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Lunes',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Lunes',4,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Lunes',7,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Lunes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Lunes',6,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Lunes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Lunes',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Lunes',2,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Martes',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Martes',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Martes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Martes',6,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Martes',4,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Martes',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Martes',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Martes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Martes',2,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Miercoles',4,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Miercoles',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Miercoles',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Miercoles',9,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Miercoles',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Miercoles',9,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Miercoles',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Miercoles',7,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Miercoles',1,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Jueves',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Jueves',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Jueves',8,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Jueves',7,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Jueves',4,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Jueves',8,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Jueves',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Jueves',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Jueves',6,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Viernes',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Viernes',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Viernes',4,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Viernes',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Viernes',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Viernes',9,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Viernes',3,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Viernes',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Viernes',8,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Sabado',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Sabado',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Sabado',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Sabado',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Sabado',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Sabado',8,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Sabado',9,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Sabado',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Sabado',5,1);

insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','8:00 am - 9:30 am','Domingo',8,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronald Leiva','10:00 am - 10:30 am','Domingo',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','11:00 am - 11:30 am','Domingo',9,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Sandra Puentes','12:00 pm - 1:30 pm','Domingo',10,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','2:00 pm - 3:30 pm','Domingo',2,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Bruno Sante','4:00 pm - 5:30 pm','Domingo',5,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Emile Moreyra','6:00 pm - 7:30 pm','Domingo',8,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Jorge Mateo','8:00 pm - 9:30 pm','Domingo',1,1);
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values ('Ronal Leiva','10:00 pm - 11:30 pm','Domingo',4,1);

create table Categoria(
IdCategoria int primary key identity(1,1),
Descripcion varchar(100),
)
go


insert into Categoria(Descripcion) values ('Planes');
insert into Categoria(Descripcion) values ('Articulos');

Create table Productos (
IdProducto int primary key identity(1,1),
NombreProducto varchar(50),
Precio money,
Descripcion text,
IdCategoria int FOREIGN KEY REFERENCES Categoria(IdCategoria),
FechaRegistro date default GETDATE(),
ImagenProducto varchar(60),
CantidadProducto int,
Estado int default 25)
go

--alter table Productos
--drop constraint DF__Productos__Estad__22AA2996

--alter table Productos
--add constraint DF__Productos__Estado default 25 for Estado

create table Pedidos(
IdPedidos int primary key identity (1,1),
MetodoPago int,
FechaRegistro date default GETDATE(),
Estado int default 20,
IdCliente int FOREIGN KEY REFERENCES Cliente(IdCliente),
IdTrabajador int FOREIGN KEY REFERENCES Trabajador(IdTrabajador))
go

Create table DetallePedido(
MontoTotal money,
Precio money,
Cantidad int,
IdPedidos int FOREIGN KEY REFERENCES Pedidos(IdPedidos),
IdProducto int FOREIGN KEY REFERENCES Productos(IdProducto),
primary key(IdPedidos,IdProducto))
go

----¿Cuál es el ranking de suplementos más vendidos?

--select d.IdProducto, p.NombreProducto , COUNT(*) as Suplemento from DetallePedido d inner join Productos p on p.IdProducto=d.IdProducto group by d.IdProducto, p.NombreProducto

----¿Cuál es el ranking de planes mas solicitados?
--select P.Planes, COUNT(*) as Cantidad from Planes P group by P.Planes order by Cantidad desc

--create proc prueba
--as
--begin
--	create table #temp(CodigoProducto int, Nombre varchar(15), Suplemento int);
--	insert into #temp select d.IdProducto as Codigo, p.NombreProducto as Nombre , COUNT(*) as Suplemento from DetallePedido d inner join Productos p on p.IdProducto=d.IdProducto group by d.IdProducto, p.NombreProducto;
--	select * from #temp;
--end
--go


/*=======PROCEDIMIENTOS ALMACENADOS=======*/

Create proc Sp_InsertarCliente
@Nombre  varchar(100),
@Apellidos varchar(100),
@Dni varchar(10),
@Edad  int,
@Sexo int,
@Distrito int,
@FechaNacimiento date,
@Email varchar(50),
@Contrasena varchar(20),
@Telefono varchar(10)
as
begin
insert into cliente(Nombre,Apellidos,Dni,Edad,Sexo,Distrito,FechaNacimiento,Email,Contrasena,Telefono) 
values(@Nombre,@Apellidos,@Dni,@Edad,@Sexo,@Distrito,@FechaNacimiento,@Email,@Contrasena,@Telefono);
end
go

create proc Sp_ActualizarCliente
@IdCliente int,
@Estado int
as
begin
update cliente set Estado=@Estado, FechaRegistro=GETDATE() where IdCliente=@IdCliente;
end
go

create proc Sp_ListarCliente
@Estado varchar(10)=''
as
begin
if @Estado=17
select IdCliente, Nombre, Apellidos, Dni, Email, (case Estado when '17' then 'Activo' end) as Estado from Cliente where Estado=17;
end
if @Estado=19
begin
select IdCliente, Nombre, Apellidos, Dni, Email, (case Estado when '19' then 'Eliminado' end) as Estado from Cliente where Estado=19;
end
go

create proc Sp_ValidarUsuarioCliente
@Email varchar(50)
as
begin
select Email from Cliente where Email=@Email;
end
go

create proc Sp_IngresoCliente
@Email varchar(50),
@Contrasena varchar(20)
as
begin
select Email, Contrasena, IdCliente from Cliente where Email=@Email and Contrasena=@Contrasena;
end


/*===TRABAJADOR===*/

Create proc Sp_InsertarTrabajador
@Nombre  varchar(100),
@Apellidos varchar(100),
@Dni varchar(10),
@Edad  int,
@Sexo int,
@Distrito int,
@FechaNacimiento date,
@Email varchar(50),
@Contrasena varchar(20),
@Telefono varchar(10)
as
begin
insert into trabajador(Nombre,Apellidos,Dni,Edad,Sexo,Distrito,FechaNacimiento,Email,Contrasena,Telefono) 
values(@Nombre,@Apellidos,@Dni,@Edad,@Sexo,@Distrito,@FechaNacimiento,@Email,@Contrasena,@Telefono);
end
go

create proc Sp_ActualizarEstadoTrabajador
@IdTrabajador int
as
begin
update Trabajador set Estado=0, FechaRegistro=GETDATE() where IdTrabajador=@IdTrabajador;
end
go

create proc Sp_ListarTrabajador
as
begin
select IdTrabajador, Nombre, Apellidos, Dni, Email from Trabajador;
end
go

create proc Sp_ValidarUsuarioTrabajador
@Email varchar(50)
as
begin
select Email from Trabajador where Email=@Email;
end
go

create proc Sp_IngresoTrabajador
@Email varchar(50),
@Contrasena varchar(20)
as
begin
select Email, Contrasena, IdTrabajador from Trabajador where Email=@Email and Contrasena=@Contrasena;
end

/*====CLASES====*/

create proc Sp_InsertarClase
@NombreClase varchar(50)
as
begin
insert into Clases(NombreClase) values (@NombreClase);
end
go

create proc Sp_ActualizarEstadoClase
@IdClases int,
@Estado int
as
begin
update Clases set Estado=@Estado where IdClases=@IdClases;
end
go

create proc Sp_ListarClase
as
begin
select * from Clases; 
end
go

create proc Sp_ActualizarClase
@IdClases int,
@NombreClase varchar(50)
as
begin
update Clases set NombreClase=@NombreClase where IdClases=@IdClases;
end;
go

/*====PRODUCTOS====*/

create proc Sp_InsertarProducto
@NombreProducto varchar(50),
@Precio money,
@Descripcion text,
@IdCategoria int,
@ImagenProducto varchar(255),
@CantidadProducto int
as
begin
insert into Productos(NombreProducto,Precio,Descripcion,IdCategoria,ImagenProducto,CantidadProducto) values (@NombreProducto,@Precio,@Descripcion,@IdCategoria,@ImagenProducto,@CantidadProducto);
end
go

create proc Sp_ActualizarProducto
@IdProducto int,
@NombreProducto varchar(50),
@Precio money,
@Descripcion text,
@ImagenProducto varchar(60),
@IdCategoria int,
@CantidadProductos int
as
begin
update Productos set NombreProducto=@NombreProducto, Precio=@Precio, Descripcion=@Descripcion, ImagenProducto=@ImagenProducto, IdCategoria=@IdCategoria, CantidadProducto=@CantidadProductos where
IdProducto=@IdProducto;
end
go

create proc Sp_ListarCategoriaProductoXEstado
@Categoria varchar(100),
@Estado varchar(5)=''
as
begin
if @Estado='25'
select P.IdProducto, P.NombreProducto, P.Precio, P.Descripcion, P.ImagenProducto, P.IdCategoria, P.CantidadProducto, (case P.Estado  when '25' then 'En Stock' end) as Estado from Productos P inner join Categoria C on P.IdCategoria
=C.IdCategoria where C.Descripcion=@Categoria and P.Estado=25;
end
if @Estado='26'
begin
select P.IdProducto, P.NombreProducto, P.Precio, P.Descripcion, P.ImagenProducto, P.IdCategoria, P.CantidadProducto, (case P.Estado  when '26' then 'Eliminado' end) as Estado from Productos P inner join Categoria C on P.IdCategoria
=C.IdCategoria where C.Descripcion=@Categoria and P.Estado=26;
end
go

create proc Sp_BuscarProducto
@IdProducto int
as
begin
select IdProducto, NombreProducto, Precio, Descripcion, ImagenProducto, IdCategoria, CantidadProducto from Productos where IdProducto=@IdProducto;
end
go

create proc Sp_ActualizarStock
@IdProducto int,
@Cantidad int
as
begin
update Productos set CantidadProducto=CantidadProducto-@Cantidad where IdProducto=@IdProducto;
end
go

  Create trigger Disminuir_Stock
   on DetallePedido
   for Insert
   as
   Update Productos set CantidadProducto =CantidadProducto-D.Cantidad
   from Productos as P inner join
   INSERTED as D on D.IdProducto=P.IdProducto

create proc Sp_ActualizarEstadoProducto
@Estado int,
@IdProducto int
as
begin
update Productos set Estado=@Estado where IdProducto=@IdProducto;
end
go

/*====CATEGORIA====*/

create proc Sp_InsertarCategoria
@Descripcion varchar(100)
as
begin
insert into Categoria values (@Descripcion);
end
go

create proc Sp_ActualizarCategoria
@IdCategoria int,
@Descripcion varchar(100)
as
begin
update Categoria set Descripcion=@Descripcion where IdCategoria=@IdCategoria;
end
go

create proc Sp_ListarCategoria
as
begin
select * from Categoria;
end
go

/*====PEDIDOS====*/

create proc Sp_InsertarPedido
@MetodoPago int,
@IdCliente int
as
begin
insert into Pedidos(MetodoPago,IdCliente,IdTrabajador) values (@MetodoPago,@IdCliente,1);
end
go

create proc Sp_ActualizarEstadoPedido
@IdPedidos int,
@Estado int,
@IdTrabajador int
as
begin
update Pedidos set Estado=@Estado, IdTrabajador=@IdTrabajador where IdPedidos=@IdPedidos;
end
go


create proc Sp_ListarPedidosPorEstados
@Estado varchar(10)=''
as
begin
-- PEDIDOS SIN CANCELAR
IF @Estado=20
select P.IdPedidos,(case P.MetodoPago when '1' then 'Tarjeta' when '2' then 'Efectivo' end) as MetodoPago,
 P.FechaRegistro, (case P.Estado when '20' then 'Sin Cancelar'end) as Estado, C.Nombre, C.Email from Pedidos P inner join Cliente C on P.IdCliente=C.IdCliente where P.Estado=20;
end
-- PEDIDOS CANCELADOS
IF @Estado=21
begin
select P.IdPedidos,(case P.MetodoPago when '1' then 'Tarjeta' when '2' then 'Efectivo' end) as MetodoPago,
 P.FechaRegistro, (case P.Estado when '21' then 'Cancelado'end) as Estado, C.Nombre, C.Email from Pedidos P inner join Cliente C on P.IdCliente=C.IdCliente where P.Estado=21;
end
-- PEDIDOS ELIMINADOS
IF @Estado=22
begin
select P.IdPedidos,(case P.MetodoPago when '1' then 'Tarjeta' when '2' then 'Efectivo' end) as MetodoPago,
 P.FechaRegistro, (case P.Estado when '22' then 'Eliminado'end) as Estado, C.Nombre, C.Email from Pedidos P inner join Cliente C on P.IdCliente=C.IdCliente where P.Estado=22;
end
go

create proc Sp_ListarMisPedidos
@IdCliente int
as
begin
select IdPedidos, (case MetodoPago when '1' then 'Tarjeta' when '2' then 'Efectivo' end) as MetodoPago, FechaRegistro, 
(case Estado when '20' then 'Sin Cancelar' when '21' then 'Cancelado' when '22' then 'Eliminado' end) as Estado from Pedidos where IdCliente=@IdCliente
end
go

/*====DETALLEPEDIDOS====*/

create proc Sp_InsertarDetallePedido
@MontoTotal money,
@Precio money,
@Cantidad int,
@IdPedidos int,
@IdProducto int
as
begin
insert into DetallePedido values (@MontoTotal,@Precio,@Cantidad,@IdPedidos,@IdProducto);
end
go

create proc Sp_VerDetalle
@IdPedidos int
as
begin
select P.NombreProducto, D.Precio, D.Cantidad, D.MontoTotal from DetallePedido D inner join Productos P on D.IdProducto=P.IdProducto where IdPedidos=@IdPedidos
end
go

/*===HORARIOS===*/

create proc Sp_InsertarHorarios
@Instructor varchar(50),
@Hora varchar(30),
@Dia varchar(20),
@IdClases int,
@IdTrabajador int
as
begin
insert into Horarios(Instructor,Hora,Dia,IdClases,IdTrabajador) values (@Instructor,@Hora,@Dia,@IdClases,@IdTrabajador);
end
go

create proc Sp_ModificarHorarios
@Instructor varchar(50),
@IdClases int,
@IdTrabajador int
as
begin
update Horarios set Instructor=@Instructor, IdClases=@IdClases, IdTrabajador=@IdTrabajador;
end
go

create proc Sp_ListarHorariosXDia
@Dia varchar(20),
@Estado varchar(10)=''
as
begin
if @Estado='27'
select H.IdHorario, H.Hora, H.Instructor, C.NombreClase, H.Dia, (case H.Estado when '27' then 'Disponible' end) as Estado  from Horarios H inner join Clases C on H.IdClases=C.IdClases where H.Dia=@Dia and H.Estado=27;
end
if @Estado='28'
begin
select H.IdHorario, H.Hora, H.Instructor, C.NombreClase, H.Dia, (case H.Estado when '28' then 'No Disponible' end) as Estado  from Horarios H inner join Clases C on H.IdClases=C.IdClases where H.Estado=28 order by H.Dia;
end
go

create proc Sp_ActualizarEstadoHorario
@Estado int,
@IdHorario int
as
begin
update Horarios set Estado=@Estado where IdHorario=@IdHorario;
end
go

create proc Sp_BuscarHorario
@IdHorario int
as
begin
select IdHorario,Hora,Instructor,IdClases from Horarios where IdHorario=@IdHorario;
end
go

/*====COMBOS====*/

CREATE TABLE T_TABLAS(
T_IDCAMPO INT primary key identity(1,1) NOT NULL,
T_IDTIPOTABLA INT ,
T_NOMBRE VARCHAR(50) ,
T_VER INT ,
T_VALOR INT )
go


insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(1,'Tarjeta');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(1,'Efectivo');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(2,'Masculino');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(2,'Femenino');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'La Victoria');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'SJ Lurigancho');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Lince');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Breña');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Cercado de Lima');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Villa el Salvador');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Rimac');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Surco');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'San Borja');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'San Isidro');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Miraflores');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(3,'Comas');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(4,'Activo');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(4,'Eliminado');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(5,'Sin Cancelar');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(5,'Cancelado');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values(5,'Eliminado');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (6,'Por Procesar');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (6,'Aceptada');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (6,'Rechazada');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (7,'En Stock');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (7,'Eliminado');

insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (8,'Disponible');
insert into T_TABLAS(T_IDTIPOTABLA,T_NOMBRE) values (8,'No Disponible');

CREATE procedure SP_Listar_Combos
@OP varchar(10)=''
as
begin
--METODO DE PAGO
IF @OP='1'
SELECT T_IDCAMPO,T_NOMBRE from T_TABLAS where T_IDTIPOTABLA=1
end
IF @OP= '2'
BEGIN
--SEXO--
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS where T_IDTIPOTABLA=2
end
IF @OP ='3'
BEGIN
--Distrito
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=3
END
--ESTADO CLIENTE
IF @OP='4'
BEGIN
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=4
end
--ESTADO PEDIDO
IF @OP='5'
BEGIN
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=5
END
--ESTADO SUSCRIPCION
IF @OP='6'
BEGIN
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=6
END
--ESTADO PRODUCTO
IF @OP='7'
BEGIN
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=7
END
--ESTADO HORARIO
IF @OP='8'
BEGIN
SELECT T_IDCAMPO,T_NOMBRE FROM T_TABLAS WHERE T_IDTIPOTABLA=8
END


CREATE TABLE T_TIPOTABLA(
ID INT identity(1,1) PRIMARY KEY NOT NULL,
TP_NOMBRE varchar(50) not null,
TP_DESCRIPCION varchar(50) not null)
go

insert into T_TIPOTABLA values('Metodo de Pago','USUARIOS');
insert into T_TIPOTABLA values('Sexo','USUARIOS');
insert into T_TIPOTABLA values('Distrito','USUARIOS');
insert into T_TIPOTABLA values('Estado Cliente','USUARIOS');
insert into T_TIPOTABLA values('Estado Pedido','USUARIOS');
insert into T_TIPOTABLA values ('Estado Suscripcion','USUARIOS');
insert into T_TIPOTABLA values ('Estado Producto','USUARIOS');
insert into T_TIPOTABLA values ('Estado Horario','USUARIOS');

--DBCC CHECKIDENT ('[Pedidos]', RESEED, 0);
--GO
--select * from DetallePedido
--select * from Pedidos;
--select * from Productos

--select P.IdPedidos, C.Nombre, C.Email, A.NombreProducto from Cliente C inner join Pedidos P on C.IdCliente=P.IdCliente inner join DetallePedido D on P.IdPedidos=D.IdPedidos inner join
--Productos A on D.IdProducto=A.IdProducto where a.IdCategoria=1;

--select P.IdPedidos,(case P.MetodoPago when '1' then 'Tarjeta' when '2' then 'Efectivo' end) as MetodoPago,
-- P.FechaRegistro, (case P.Estado when '1' then 'Sin Cancelar' when '0' then 'Cancelado' end) as Estado, C.Nombre, C.Email from Pedidos P inner join Cliente C on P.IdCliente=C.IdCliente;



 create table Planes(Codigo int identity(1,1) primary key,Nombre varchar(30),Email varchar(40),Telefono varchar(10),Planes varchar(30), FechaSuscripcion date default getdate(),Estado int default 23, Cod_Trabajador int default 1)

 --SUSCRIPCIONES--

 create proc Suscripcion
 @Nombre varchar(30),
 @Email varchar(40),
 @Telefono varchar(10),
 @Planes varchar(30)
 as
 begin
 insert into Planes(Nombre,Email,Telefono,Planes) values(@Nombre,@Email,@Telefono,@Planes);
 end
 go

 create proc ListarSusc_PorEstado
 @Estado varchar(10)=''
 as
 begin
 if @Estado='23'
 select Codigo,Nombre,Email,Telefono,Planes, (case Estado when '23' then 'Por Procesar' end) as Estado, FechaSuscripcion from Planes where Estado=23;
 end
 if @Estado='24'
 begin
 select Codigo,Nombre,Email,Telefono,Planes, (case Estado when '24' then 'Aceptada' end) as Estado, FechaSuscripcion from Planes where Estado=24;
 end
 if @Estado='25'
 begin
 select Codigo,Nombre,Email,Telefono,Planes, (case Estado when '25' then 'Rechazada' end) as Estado, FechaSuscripcion from Planes where Estado=25;
 end
 go

 create proc ActualizarEstadoSuscripcion
 @Codigo int,
 @Estado int,
 @Cod_Trabajador int
 as
 begin
 update Planes set Estado=@Estado, Cod_Trabajador=@Cod_Trabajador where Codigo=@Codigo;
 end
 go

 ----TUBERIA Y FILTRO----

 create proc PlanMasSolicitado
 as
 begin
 select P.Planes, COUNT(*) as Cantidad from Planes P group by P.Planes order by Cantidad desc
 end
 go

 create proc SuplementoMasVendido
 as
 begin
 select d.IdProducto, p.NombreProducto , COUNT(*) as Suplemento from DetallePedido d inner join Productos p on p.IdProducto=d.IdProducto group by d.IdProducto, p.NombreProducto order by Suplemento desc
 end
 go
 
 --select p.IdPedidos, P.MetodoPago, P.FechaRegistro, sum(D.MontoTotal) as MontoPedido from Pedidos P inner join DetallePedido D on P.IdPedidos=D.IdPedidos where P.Estado=21 group by P.IdPedidos, P.MetodoPago, P.FechaRegistro

 --select * from DetallePedido where IdPedidos=1
 --select SUM(MontoTotal) from DetallePedido where IdPedidos=1
 
 --select P.NombreProducto, P.Precio, D.Cantidad, D.MontoTotal from DetallePedido D inner join Productos P on D.IdProducto=P.IdProducto where IdPedidos=2

create proc Sp_ReporteXFecha
as
begin
 select P.IdPedidos,A.NombreProducto,D.Cantidad,D.Precio,P.FechaRegistro,D.MontoTotal from Pedidos P inner join DetallePedido D on P.IdPedidos=D.IdPedidos inner join Productos A on D.IdProducto=A.IdProducto where
 P.FechaRegistro=convert(varchar,getdate(),23) and P.Estado=21 order by P.IdPedidos
end
go

create proc Sp_ClientesMasPedidos
as
begin
select C.Nombre, COUNT(P.IdPedidos) as CantidadPedidos from Cliente C inner join Pedidos P on C.IdCliente=P.IdCliente where P.Estado=21 group by C.Nombre order by CantidadPedidos desc;
end
go

create proc Sp_ClasesPorInstructor
as
begin
select H.Instructor, count(H.IdClases) as Cantidad from Horarios H inner join Clases C on H.IdClases=C.IdClases group by H.Instructor order by 
 Cantidad desc
 end
 go

create proc Sp_SusAceptadasMes
as
begin
select P.Codigo, P.Nombre, P.Email, P.Telefono, P.Planes, P.FechaSuscripcion , (case P.Estado when '23' then 'Aceptada' end) as Estado from Planes P where P.Estado=23 and datepart(mm,P.FechaSuscripcion)=datepart(mm,GETDATE())
end
go






 

 







