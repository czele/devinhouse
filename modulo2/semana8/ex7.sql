SELECT 
	Cliente.nome AS 'Nome Cliente',
	Produto.nome AS 'Produto',
	Pedido.valor_total AS 'Valor Total'
FROM Cliente 
INNER JOIN Pedido
ON Cliente.id = Pedido.id_cliente
INNER JOIN Produto_Pedido
ON Produto_Pedido.id_pedido = Pedido.id
INNER JOIN Produto
ON Produto_Pedido.id_produto = Produto.id
WHERE Pedido.valor_total >= 150;
