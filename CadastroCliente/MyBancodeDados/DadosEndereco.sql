CREATE TABLE endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
);

INSERT INTO endereco
(logradouro, numero, bairro, cidade, estado, cep, complemento)
VALUES
('Rua Alfredo de Moraes', '456', 'Jardim Flores', 'Municipio', 'SP', '15695002', 'Casa B'),
('Avenida Ipiranga', '1009', 'Independencia', 'Ipiranga', 'SP', '486357053', NULL);