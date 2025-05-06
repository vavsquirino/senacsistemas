CREATE TABLE IF NOT EXISTS produto (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
    dataproduto DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS estoque (
	id INT PRIMARY KEY AUTO_INCREMENT,
	quantidade INT NOT NULL,
    id_produto INT NOT NULL,
    dataestoque DATE NOT NULL,
    
	FOREIGN KEY (id_produto) REFERENCES produto(id)
);

CREATE TABLE IF NOT EXISTS venda (
	id INT PRIMARY KEY AUTO_INCREMENT,
    id_produto INT NOT NULL,
    id_estoque INT NOT NULL,
    datavenda DATE NOT NULL
);

