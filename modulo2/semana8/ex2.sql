CREATE TABLE Avaliacao (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_cliente INT NOT NULL,
	id_produto INT NOT NULL,
	comentario VARCHAR(200) ,
	numero_estrelas INT NOT NULL,
	data_publicacao VARCHAR(100) NOT NULL,
	FOREIGN KEY (id_cliente) REFERENCES Cliente(id), 
	FOREIGN KEY (id_produto) REFERENCES Produto(id), 
);

CREATE TABLE Metodo_Pagamento (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	numero_cartao VARCHAR(100) NOT NULL,
	validade VARCHAR(50) NOT NULL,
	codigo_seguranca INT NOT NULL
);

CREATE TABLE Cliente (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nome VARCHAR(100) NOT NULL,
	data_nascimento VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	cpf VARCHAR(100) NOT NULL,
	senha VARCHAR(100) NOT NULL,
);

CREATE TABLE Produto (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_avalicao INT,
	nome VARCHAR(100) NOT NULL,
	preco INT NOT NULL,
	nota INT NOT NULL,
	numero_unidade INT NOT NULL,
	numero_venda INT NOT NULL,
	FOREIGN KEY (id_avaliacao) REFERENCES Avaliacao(id)
);

CREATE TABLE Pedido (
	id INT PRIMARY KEY IDENTITY(1,1),
	id_cliente INT NOT NULL,
	id_metodo_pagamento INT NOT NULL,
	valor_total NUMERIC(20, 2) NOT NULL,
	status VARCHAR(50) NOT NULL,
	foi_entregue VARCHAR(50) NOT NULL,
	FOREIGN KEY (id_cliente) REFERENCES Cliente(id),
	FOREIGN KEY (id_metodo_pagamento) REFERENCES Metodo_Pagamento(id)
);

CREATE TABLE Produto_Pedido(
	id INT PRIMARY KEY IDENTITY(1,1),
	id_produto INT NOT NULL,
	id_pedido INT NOT NULL,
	FOREIGN KEY (id_produto) REFERENCES Produto(id),
	FOREIGN KEY (id_pedido) REFERENCES Pedido(id)
);
