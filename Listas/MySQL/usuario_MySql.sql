CREATE TABLE usuario (
id INT PRIMARY KEY AUTO_INCREMENT,
email VARCHAR(50) NOT NULL UNIQUE,
senha VARCHAR(50) not null
);

INSERT INTO usuario (email, senha)
VALUES
('neymar.jr@gmail.com', 'Brun@123'),
('pablo.vittar@gmail.com', '12345Abc!'),
('sukuna.silva@gmail.com', 'Sete7Sete!');

SELECT
*
FROM usuario;