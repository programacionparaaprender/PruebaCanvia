--use PruebaCanvia;

create procedure spMostrarNoticiasConAutor 
@idautor int
as
select
noticia.[noticiaId]
      ,noticia.[Titulo]
      ,noticia.[Descripcion]
      ,noticia.[Contenido]
      ,noticia.[Fecha]
      ,autor.Nombre + ' ' + autor.Apellido Autor
from
Noticia noticia
inner join Autor autor on autor.autorId = noticia.autorId
where autor.autorId = noticia.autorId