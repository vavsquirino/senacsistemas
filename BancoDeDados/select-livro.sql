SELECT 
    *
FROM
    livro,
    genero,
    editora,
    autor
WHERE
    livro.id_genero = genero.id
        AND livro.id_editora = editora.id
        AND livro.id_autor = autor.id;