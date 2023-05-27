CREATE PROCEDURE AtualizarEstoque
	@prd_id INT,
	@nro_venda INT
AS
	UPDATE Produto
	SET
	numero_unidade = numero_unidade - @nro_venda,
	numero_venda = numero_venda + @nro_venda
WHERE 
	id = @prd_id;

EXEC AtualizarEstoque @prd_id = 1, @nro_venda = 10

SELECT * FROM Produto WHERE id = 1
