-- Mostra a soma dos pedidos por cliente, sendo soma maior que 1.000, ordem crescente
SELECT c.Id, c.Nome as Cliente, SUM(p.Valor) as TotalPedidos FROM Pedidos p
	INNER JOIN Clientes c ON p.ClienteId = c.Id	
GROUP BY c.Nome, c.Id
HAVING SUM(p.Valor) > 1000
ORDER BY c.Id ASC

-- Mostra os pedidos do Cliente.Id = 1 e em Ordem Ascendente
SELECT c.Id, c.Nome as Cliente, p.Numero, p.Valor FROM Pedidos p
	INNER JOIN Clientes c ON p.ClienteId = c.Id	
WHERE c.Id = 1
ORDER BY p.Numero ASC

-- Mostra os valores por clientes e classifica-os se compra maior que 2000
SELECT c.Id, c.Nome as Cliente, SUM(p.Valor) as 'Total de Compras',IIF(SUM(p.Valor) >2000, 'DIAMOND', 'SILVER') as 'Status' FROM Pedidos p
	INNER JOIN Clientes c ON p.ClienteId = c.Id	
GROUP BY c.Nome, c.Id
ORDER BY c.Id ASC
