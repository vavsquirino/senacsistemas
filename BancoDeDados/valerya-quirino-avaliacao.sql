CREATE TABLE IF NOT EXISTS produto (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(10, 2) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL
);

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id)
VALUES
('Celular X', 'Eletrônicos', 2500.00, 30, 1), 
('Notebook Y', 'Eletrônicos', 4800.00, 15, 2), 
('Mesa de Madeira', 'Móveis', 750.00, 10, 3),
('Cadeira Z', 'Móveis', 300.00, 25, 3),
('TV 50', 'Eletrônicos', '3500.00', 8, 1);

CREATE TABLE IF NOT EXISTS fornecedor (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);

INSERT INTO fornecedor (nome, cidade)
VALUES
('TechBrasil', 'São Paulo'), 
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

CREATE TABLE IF NOT EXISTS pedido (
	id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
	data_pedido DATE NOT NULL,
    cliente_id INT NOT NULL
);

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id)
VALUES
(1, 2, '2024-03-10', 1), 
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);

CREATE TABLE IF NOT EXISTS cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
	idade INT NOT NULL
);

INSERT INTO cliente (nome, cidade, idade)
VALUES
('João Silva', 'São Paulo', 35), 
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

SELECT * FROM produto WHERE categoria = 'eletrônicos' AND preco > 3000.00 ORDER BY preco DESC;
SELECT * FROM cliente WHERE NOT cidade = 'São Paulo' AND idade > 30;
SELECT * FROM pedido WHERE data_pedido BETWEEN '2024-03-10' AND '2024-03-15' ORDER BY data_pedido ASC;
SELECT * FROM produto WHERE estoque < 10 ORDER BY estoque ASC;
SELECT * FROM fornecedor WHERE NOT cidade = 'Rio de Janeiro' AND nome NOT LIKE 't%';

SELECT categoria, AVG(preco) AS preco_medio FROM produto GROUP BY categoria;
SELECT cliente_id, COUNT(*) AS total_pedidos FROM pedido GROUP BY cliente_id;
SELECT categoria, SUM(estoque) AS total_estoque FROM produto GROUP BY categoria;
SELECT id, produto_id, quantidade FROM pedido WHERE quantidade = (SELECT MAX(quantidade) FROM pedido);
SELECT cidade, COUNT(*) AS total_clientes FROM cliente GROUP BY cidade ORDER BY total_clientes DESC;

SELECT produto.nome AS NomeProduto, fornecedor.nome AS NomeFornecedor FROM produto INNER JOIN fornecedor ON fornecedor.id = produto.fornecedor_id ORDER BY fornecedor.nome;
SELECT pedido.id AS Pedido, cliente.nome AS NomeCliente, produto.nome AS ProdutoComprado, data_pedido FROM pedido INNER JOIN cliente ON cliente.id = pedido.cliente_id INNER JOIN produto ON produto.id = pedido.produto_id ORDER BY data_pedido ASC;
SELECT pedido.id AS Pedido, cliente.nome AS NomeCliente, produto.nome AS ProdutoComprado, fornecedor.nome AS Empresa FROM pedido INNER JOIN cliente ON cliente.id = pedido.cliente_id INNER JOIN produto ON produto.id = pedido.produto_id INNER JOIN fornecedor ON produto.fornecedor_id = fornecedor.id;
SELECT SUM(quantidade) AS QuantidadeProdutos, cliente.nome AS NomeCliente FROM pedido INNER JOIN cliente ON cliente.id = pedido.cliente_id GROUP BY cliente_id ORDER BY SUM(quantidade) DESC;

SELECT 
    categoria, nome AS poduto, preco
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto)
ORDER BY categoria;

SELECT 
    *
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto pr
		WHERE
        p.categoria = pr.categoria)
ORDER BY p.categoria;

UPDATE produto SET preco = preco * 1.1 WHERE categoria = 'Eletrônicos';
DELETE FROM pedido WHERE cliente_id = (SELECT cliente.id FROM cliente WHERE cidade = 'Curitiba');

INSERT INTO cliente (nome, cidade, idade)
VALUES
('Ricardo Lopes', 'Porto Alegre', 38);

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id)
VALUES
(2, 2, '2024-03-25', 1);

SELECT 
    cliente.nome AS Cliente,
    pedido.id,
    produto.categoria AS Categoria
FROM
    pedido
        INNER JOIN
    cliente ON cliente.id = pedido.cliente_id
        INNER JOIN
    produto ON produto.id = pedido.produto_id
WHERE
    produto.id = ANY (SELECT 
            produto.id
        FROM
            produto
        WHERE
            categoria = 'Móveis');



