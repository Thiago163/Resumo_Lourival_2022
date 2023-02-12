drop database teste;

create database teste;
use teste;


create table dados(
id int auto_increment primary key,
nome varchar(255) not null,
email varchar(255) not null);

insert into dados(nome, email)values
("Thiago", "luiz@gmail.com");

select * from dados;
