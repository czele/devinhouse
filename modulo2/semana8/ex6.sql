SELECT Cliente.nome, COUNT(Avaliacao.id) AS 'Avalia��es'
FROM Cliente
LEFT JOIN Avaliacao
ON Cliente.id = Avaliacao.id_cliente
GROUP BY (Cliente.nome) 
ORDER BY 'Avalia��es' DESC
