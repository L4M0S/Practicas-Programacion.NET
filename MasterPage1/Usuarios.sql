CREATE DATABASE carrito;

USE carrito;

CREATE TABLE usuarios(
	nombre varchar(10) PRIMARY KEY,
	pass varchar(20)
);

CREATE TABLE productos(
	codigo int PRIMARY KEY AUTO_INCREMENT,
	nombre varchar(20),
	precio float
);

CREATE TABLE venta(
	nombre varchar(20),
	cantidad int,
	precio float
);

insert into usuarios values("admin","admin");

update habitaciones set status="Ocupado" where clave=5;

delete from habitaciones where nombre='H1';



insert into reservaciones (habitacion,entrada,salida) values('H1','2019-10-20','2019-10-25');

delete from reservaciones where nombre='H1';

UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;