using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bibliotecaPositivo.model;



namespace bibliotecaPositivo;
public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        var livros = new List<Livro>
        {
            new Livro { Id = 1, Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", AnoPublicacao = 1997 },
            new Livro { Id = 2, Titulo = "Harry Potter e a Câmara Secreta", Autor = "J.K. Rowling", AnoPublicacao = 1998 },
            new Livro { Id = 3, Titulo = "Harry Potter e o Prisioneiro de Azkaban", Autor = "J.K. Rowling", AnoPublicacao = 1999 },
            new Livro { Id = 4, Titulo = "Harry Potter e o Cálice de Fogo", Autor = "J.K. Rowling", AnoPublicacao = 2000 },
            new Livro { Id = 5, Titulo = "Harry Potter e a Ordem da Fênix", Autor = "J.K. Rowling", AnoPublicacao = 2003 },
            new Livro { Id = 6, Titulo = "Harry Potter e o Enigma do Príncipe", Autor = "J.K. Rowling", AnoPublicacao = 2005 },
            new Livro { Id = 7, Titulo = "Harry Potter e as Relíquias da Morte", Autor = "J.K. Rowling", AnoPublicacao = 2007 },
         
        };

    {
        app.MapGet("/livros", () =>
        {
            return livros;
        });

        app.MapGet("/livros/{id}", (int id) =>
        {
            var livro = livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(livro);
        });
    }
    
}
}
        