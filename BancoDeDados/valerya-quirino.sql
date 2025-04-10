CREATE TABLE IF NOT EXISTS cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    saldo DECIMAL(10, 2) NOT NULL
);

INSERT INTO cliente (nome, idade, cidade, saldo)
VALUES
('Carlos', 45, 'São Paulo', 2500.00), 
('Mariana', 32, 'Rio de Janeiro', 3200.50), 
('Pedro', 27, 'Belo Horizonte', 1500.75), 
('Fernanda', 38, 'Curitiba', 4200.00);

SELECT * FROM cliente WHERE cidade = 'Rio de Janeiro';
SELECT * FROM cliente WHERE saldo >= 2000 ORDER BY saldo DESC;
SELECT nome, idade FROM cliente WHERE idade > 30;

CREATE TABLE IF NOT EXISTS pedido (
	id INT PRIMARY KEY AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor DECIMAL(10, 2) NOT NULL,
	data_pedido DATE NOT NULL,
    
    foreign key (cliente_id) references cliente(id)
);

INSERT INTO pedido (cliente_id, valor, data_pedido)
VALUES
(1, 500.00, '2024-03-10'),
(2, 1200.00, '2024-03-12'),
(3, 300.50, '2024-03-15'),
(1, 800.00, '2024-03-18');

SELECT COUNT(*) FROM pedido;
SELECT AVG(valor) FROM pedido;
SELECT cliente_id, SUM(valor) FROM pedido GROUP BY cliente_id;
SELECT * FROM cliente INNER JOIN pedido ON cliente.id = pedido.cliente_id; 
SELECT * FROM cliente LEFT JOIN pedido ON cliente.id = pedido.cliente_id;
SELECT * FROM cliente INNER JOIN pedido ON cliente.id = pedido.cliente_id WHERE valor >= (SELECT AVG(valor) FROM pedido);
SELECT * FROM cliente INNER JOIN pedido ON cliente.id = pedido.cliente_id WHERE valor >= 1000;

INSERT INTO cliente (nome, idade, cidade, saldo)
VALUES
('Rafael', 27, 'Porto Alegre', 2100.00);

UPDATE cliente SET saldo = saldo + (saldo * 0.10);
SELECT * FROM pedido;
DELETE FROM pedido WHERE cidade = 'Curitiba';