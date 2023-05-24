-- Tabela Avaliacao
INSERT INTO Avaliacao (comentario, numero_estrelas, data_publicacao)
VALUES
  ('Ótimo serviço!', 5, '2023-05-01'),
  ('Excelente atendimento!', 4, '2023-05-02'),
  ('Recomendo a todos!', 4, '2023-05-03'),
  ('Poderia ser melhor.', 3, '2023-05-04'),
  ('Serviço rápido e eficiente.', 5, '2023-05-05');

-- Tabela Metodo_Pagamento
INSERT INTO Metodo_Pagamento (numero_cartao, validade, codigo_seguranca)
VALUES
  ('1234567890123456', '05/25', 123),
  ('9876543210987654', '07/24', 456),
  ('1111222233334444', '12/23', 789),
  ('5555666677778888', '09/26', 321),
  ('9999000011112222', '03/25', 654);

-- Tabela Cliente
INSERT INTO Cliente (id_avaliacao, nome, data_nascimento, email, cpf, senha)
VALUES
  (1, 'João Silva', '1990-03-15', 'joao.silva@example.com', '12345678901', 'senha123'),
  (2, 'Maria Santos', '1985-07-10', 'maria.santos@example.com', '98765432109', 'abcd456'),
  (3, 'Pedro Oliveira', '1995-11-20', 'pedro.oliveira@example.com', '11112222333', 'qwerty789'),
  (4, 'Ana Pereira', '1988-04-05', 'ana.pereira@example.com', '55556666777', 'senha321'),
  (5, 'Carla Souza', '1992-09-30', 'carla.souza@example.com', '99990000111', 'asdfgh654');

-- Tabela Produto
INSERT INTO Produto (nome, preco, nota, numero_unidade, numero_venda)
VALUES
  ('Camiseta', 25, 4, 50, 100),
  ('Calça Jeans', 50, 5, 30, 80),
  ('Tênis', 100, 4, 20, 60),
  ('Bolsa', 80, 3, 15, 40),
  ('Relógio', 150, 5, 10, 30);

-- Tabela Pedido
INSERT INTO Pedido (id_cliente, id_metodo_pagamento, valor_total, status, foi_entregue)
VALUES
  (1, 1, 75, 'Em andamento', 'Não'),
  (2, 2, 100, 'Concluído', 'Sim'),
  (3, 3, 200, 'Em andamento', 'Não'),
  (4, 1, 160, 'Concluído', 'Sim'),
  (5, 4, 300, 'Em andamento', 'Não');

-- Tabela Produto_Pedido
INSERT INTO Produto_Pedido (id_produto, id_pedido)
VALUES
  (1, 1),
  (2, 1),
  (3, 2),
  (4, 3),
  (5, 3);
