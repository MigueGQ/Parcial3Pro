Create Database aeroParcial
Use aeroParcial

Create table vuelos
(
	id int primary key identity(1,1),
	avion varchar(25) not null,
	salida varchar(25)  not null,
	llegada varchar(25)  not null,
	numPasajeros int not null
)

insert into vuelos
values (
	'b-32', '2020-02-23 12:25:12', '2020-02-23 18:25:12', 300
)

select * from vuelos