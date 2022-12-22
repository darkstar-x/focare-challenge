create database Crud_focare;
use Crud_Focare;

create table Tbl_Employees(
Id int auto_increment not null primary key,
Nome nvarchar (50),
Genero varchar (1),
Idade int (2),
Cargo nvarchar (30),
Stado nvarchar (20),
Modalidade nvarchar (15),
Salario nvarchar (10),
Nivel int (1)
);

insert into Tbl_Employees (Nome, Genero, Idade, Cargo, Stado, Modalidade, Salario, Nivel)
values
('Leonardi', 'M', 19, 'Programmer', 'Piauí', 'Modalidade', 'Salario', 5);

select * from Tbl_Employees;