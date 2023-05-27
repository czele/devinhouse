SELECT TOP 2 id_produto AS 'Produto Mais Vendido' FROM Produto_Pedido
GROUP BY id_produto 
ORDER BY COUNT(id_produto) DESC;
