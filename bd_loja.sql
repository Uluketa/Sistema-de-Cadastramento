create database bd_loja;

use bd_loja;

create table tb_fornecedores

(

tb_fornecedores_id integer auto_increment primary key,

tb_fornecedores_nome varchar(100),

tb_fornecedores_cnpj varchar(100),

tb_fornecedores_email varchar(200),

tb_fornecedores_telefone varchar(30),

tb_fornecedores_celular varchar(30),

tb_fornecedores_cep varchar(100),

tb_fornecedores_endereco varchar(255),

tb_fornecedores_numero integer,

tb_fornecedores_complemento varchar(200),

tb_fornecedores_bairro varchar(100),

tb_fornecedores_cidade varchar(100),

tb_fornecedores_estado varchar(2)

);

create table tb_funcionarios

(

tb_funcionarios_id integer auto_increment primary key,

tb_funcionarios_nome varchar(100),

tb_funcionarios_rg varchar(30),

tb_funcionarios_cpf varchar(20),

tb_funcionarios_email varchar(200),

tb_funcionarios_senha varchar(10),

tb_funcionarios_cargo varchar(100),

tb_funcionarios_nivel_acesso varchar(50),

tb_funcionarios_telefone varchar(30),

tb_funcionarios_celular varchar(30),

tb_funcionarios_cep varchar(100),

tb_funcionarios_endereco varchar(255),

tb_funcionarios_numero integer,

tb_funcionarios_complemento varchar(200),

tb_funcionarios_bairro varchar(100),

tb_funcionarios_cidade varchar(100),

tb_funcionarios_estado varchar(2)

);

create table tb_usuarios

(

id integer not null primary key auto_increment,

nome varchar(100),

email varchar(100),

senha varchar(20)

);
