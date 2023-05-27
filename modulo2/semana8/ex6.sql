SELECT Cliente.nome, COUNT(Avaliacao.id) AS 'Avaliações'
FROM Cliente
LEFT JOIN Avaliacao
ON Cliente.id = Avaliacao.id_cliente
GROUP BY (Cliente.nome) 
ORDER BY 'Avaliações' DESC
