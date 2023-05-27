CREATE VIEW vwDetalhesPedidosCliente
AS 
SELECT
	Pedido.id AS 'id pedido',
	Pedido.valor_total AS 'valor total',
	Pedido.status AS 'status pedido',
	Cliente.nome AS 'nome cliente',
	Cliente.email AS 'email cliente'
FROM Pedido
INNER JOIN Cliente
ON Pedido.id_cliente = Cliente.id;

SELECT * FROM vwDetalhesPedidosCliente;
