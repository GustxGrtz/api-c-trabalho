using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bibliotecaPositivo.model;
using Microsoft.VisualBasic;

namespace aula05-05-2025
{
    public static class ROTA_DELETE{
        public static async Task MapDeleteRoutes(this WebApplication app){

            app.MapDelete("/livros/(id)", async (int id, LivrosContext context) => 
            var livro = await context.Livros.FindAsync(id);
            if (Livro is null) return Results.NotFound();

            context.Livros.Remove(livro);
            await ContextBoundObject.SaveChangeAsync();
            return Results.Ok();
        )};
    }
}