CREATE TABLE IF NOT EXISTS atividade (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    situacao INT NOT NULL DEFAULT 0
);

INSERT INTO atividade (titulo)
VALUES (@titulo);


UPDATE atividade 
SET 
    situação = @situacao
WHERE
    id = @id;


SELECT 
    *
FROM
    atividade
WHERE
    situacao = 1;