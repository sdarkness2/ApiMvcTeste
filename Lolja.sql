CREATE DATABASE Lolja

use Lolja

create table Clientes 
(
	Id int primary key identity,
	Nome varchar(50) not null,
)

create table Produtos
(
	Id int primary key identity,
	Nome varchar(30) not null
)

create table Pedidos
(
	Id int primary key identity,
	IdCliente int not null, --foreign key para Id na tabela Clientes
	Total smallmoney not null
)

create table PedidosItens
(
	IdPedido int not null, --foreign key para ID da tabela Pedido
	IdProduto int not null, --foreign key para ID da tabela produtos
	PrecoUnidade smallmoney not null,
)

--adicionando as foreign key em Pedidos
Alter table Pedidos add Constraint FK_PedidostoClientes Foreign key (IdCliente) References Clientes(Id)

--adicionando as foreign key em PedidosItens
Alter table PedidosItens add Constraint FK_IPtoPedidos Foreign key (IdPedido) References Pedidos (Id)
alter table PedidosItens add Constraint FK_IPtoProdutos Foreign key (IdProduto) References Produtos (Id)

--Adicionar Cliente
INSERT INTO Clientes (nome)
values ('José Carlos')