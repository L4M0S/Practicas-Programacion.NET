CREATE DATABASE hotel;

CREATE TABLE habitaciones(
	clave int PRIMARY KEY AUTO_INCREMENT,
	nombre varchar(20),
	descripcion varchar(100),
	tarifa int,
	status varchar(15)
);

select * from habitaciones;

insert into habitaciones (nombre,descripcion,tarifa,status) values("H1","Simple",100,"Libre");
insert into habitaciones (nombre,descripcion,tarifa,status) values("H2","Simple",100,"Libre");
insert into habitaciones (nombre,descripcion,tarifa,status) values("H3","Simple",100,"Libre");
insert into habitaciones (nombre,descripcion,tarifa,status) values("H4","Doble",150,"Libre");
insert into habitaciones (nombre,descripcion,tarifa,status) values("H5","Doble",150,"Libre");
insert into habitaciones (nombre,descripcion,tarifa,status) values("H6","Lujo",250,"Libre");

update habitaciones set status="Ocupado" where clave=5;

delete from habitaciones where nombre='H1';

CREATE TABLE reservaciones(
	clave int PRIMARY KEY AUTO_INCREMENT,
	habitacion varchar(20),
	entrada date,
	salida date
);

insert into reservaciones (habitacion,entrada,salida) values('H1','2019-10-20','2019-10-25');

delete from reservaciones where nombre='H1';

UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;