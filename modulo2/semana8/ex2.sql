CREATE TABLE Avaliacao (
	id INT PRIMARY KEY IDENTITY(1,1),	
	comentario VARCHAR(200),
	numero_estrelas INT,
	data_publicacao VARCHAR(100)
);

CREATE TABLE Metodo_Pagamento (
	id INT PRIMARY KEY IDENTITY(1,1),
	numero_cartao VARCHAR(100),
	validade VARCHAR(50),
	codigo_seguranca INT
);

CREATE TABLE Cliente (
	id INT PRIMARY KEY IDENTITY(1,1),
	id_avaliacao INT,
	nome VARCHAR(100),
	data_nascimento VARCHAR(100),
	email VARCHAR(100),
	cpf VARCHAR(100),
	senha VARCHAR(100),
	FOREIGN KEY (id_avaliacao) REFERENCES Avaliacao(id)
);

CREATE TABLE Produto (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	preco INT,
	nota INT,
	numero_unidade INT,
	numero_venda INT
);

CREATE TABLE Pedido (
	id INT PRIMARY KEY IDENTITY(1,1),
	id_cliente INT,
	id_metodo_pagamento INT,
	valor_total INT,
	status VARCHAR(50),
	foi_entregue VARCHAR(50),
	FOREIGN KEY (id_cliente) REFERENCES Cliente(id),
	FOREIGN KEY (id_metodo_pagamento) REFERENCES Metodo_Pagamento(id)
);

CREATE TABLE Produto_Pedido(
	id INT PRIMARY KEY IDENTITY(1,1),
	id_produto INT,
	id_pedido INT,
	FOREIGN KEY (id_produto) REFERENCES Produto(id),
	FOREIGN KEY (id_pedido) REFERENCES Pedido(id)
);
