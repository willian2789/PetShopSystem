drop database db_animalcity
create database db_animalcity

use db_animalcity


create table tbl_funcionario
(
 cd_Funcionario int primary key identity,
 nm_Funcionario varchar (80) not null,
 ds_Login varchar (30) not null,
 ds_Senha char(6) not null
)

insert into tbl_funcionario
  (nm_Funcionario,ds_Login,ds_Senha)
values
  ('Wellignton Cidade','Well@animalcity','city21')

insert into tbl_funcionario 
(nm_Funcionario,ds_Login,ds_Senha)
  values
('Mario Luigi', 'Mario@animalcity','city21')

select * from tbl_funcionario

create table tbl_Cliente 
(
	cd_Cliente int primary key identity,
	nm_Cliente Varchar (80) not null,
	email_Cliente Varchar (50),
	cpf_Cliente Varchar (20) not null,
	no_FoneCel  Varchar(20) not null,
	no_FoneRes Varchar (20),
	sg_SexoCli char (1) not null,
	sg_StatusCli bit not null,

)


select * from tbl_Cliente
drop table tbl_Cliente
select cd_Cliente, nm_Cliente from tbl_Cliente



create table tbl_Pet
(
	cd_Pet int primary key identity(1000,1),
    cd_Cliente int,
	cpf_Cliente varchar (20),
	sg_Pet char(1) not null,
	r�_Pet varchar (50),
	porte_Pet char (1) not null,
	nm_Pet varchar (30)not null,
	sg_Status bit not null,
	ds_Especie varchar (50) not null
	foreign key (cd_Cliente) references tbl_Cliente(cd_Cliente)
)

   select * from tbl_Pet
   drop table tbl_Pet

    create table tbl_Pagamento (
	cd_Pagamento int primary key identity,
	ds_Pagamento varchar (50) not null,
	cd_Servi�os int,
	vl_Total decimal(10,2),
	)
	
	select * from tbl_Pagamento
	drop table tbl_Pagamento

create table tbl_Servi�os
(
	cd_Servi�os int primary key,
	cd_Cliente int,
	cd_Funcionario int,
	dt_Servi�o date not null,
	vl_Servi�o decimal (10,2) not null,
	foreign key (cd_Cliente) references tbl_Cliente (cd_Cliente),
	foreign key (cd_Funcionario) references tbl_Funcionario (cd_Funcionario),
	
)
	select * from tbl_Servi�os
	drop table tbl_Servi�os
	delete from tbl_Servi�os where cd_Servi�os = 1


	create table tbl_Itens_Servi�os
	(
	cd_Servi�o int ,
	ds_Especialidade varchar(15),
	qt_Servico int,
	vl_Servi�o decimal (10,2),
	primary key (cd_Servi�o, ds_Especialidade),
	foreign key (cd_Servi�o) references tbl_Servi�os(cd_Servi�os)
	)

	select * from tbl_Itens_Servi�os
	drop table tbl_Itens_Servi�os
	delete from tbl_Itens_Servi�os where cd_Servi�o = 1

	create table tbl_Delivery(
	cd_Delivery int primary key identity,
	cpf_Cliente Varchar (20) not null,
	cd_Servi�o int,
	nm_Retirada varchar(80) not null,
	nm_Logradouro varchar(80) not null,
	no_Logradouro int,
	nm_Bairro varchar(50) not null,
	ds_Complemento varchar (50),
	no_CEP varchar(20) not null,
	dt_Saida date not null,
	vl_Delivery decimal(10,2),
	foreign key (cd_Servi�o) references tbl_Servi�os (cd_Servi�os)
	)

	select * from tbl_Delivery
	drop table tbl_Delivery
