CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    sobrenome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
	REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, sobrenome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Eduarda', 'Martins', '1999-7-15', 'eduarda.martins@hotmail.com', '11987456548', 1, 4, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Rua Alfredo de Moraes')),
('Emilly', 'Carvalho', '1988-12-04', 'emilly.carvalho@hotmail.com', '11965851477', 1, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = 'Avenida Ipiranga'))