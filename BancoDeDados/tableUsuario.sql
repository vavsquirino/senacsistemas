CREATE TABLE IF NOT EXISTS youtubers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    canal VARCHAR(100) NOT NULL,
    area VARCHAR(100) NOT NULL,
	objetivo VARCHAR(100) NOT NULL
);

SELECT 
    *
FROM
    youtubers;
    
insert into youtubers (nome, canal, area, objetivo)
values
('Bruno','Brino','React','Entretenimento'),
('Bruno Monteiro','Flow','Podcast','Conhecimento'),
('Lucas','LubaTV','Opnião','Entretenimento'),
('Senhor Wilson','Colonia Contra-ataca','Jogos Antigos','Entretenimento e Conhecimento'),
('Felipe','Felps','Jogos','Entretenimento');