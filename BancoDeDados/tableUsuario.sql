CREATE TABLE IF NOT EXISTS youtubers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    canal VARCHAR(50) NOT NULL,
    area VARCHAR(16) NOT NULL,
	objtivo INT NOT NULL
);
SELECT 
    *
FROM
    estante;
    
insert into estante (livro, autor, editora)
values
('Bruno','Brino','React','Entretenimento'),
('Bruno Monteiro','Flow','Podcast','Conhecimento'),
('Lucas','LubaTV','Opnião','Entretenimento'),
('Senhor Wilson','Colonia Contra-ataca','Jogos Antigos','Entretenimento e Conhecimento'),
('Felipe','Felps','Jogos','Entretenimento'),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','',''),
('','','','');
