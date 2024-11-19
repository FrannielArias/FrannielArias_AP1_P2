using FrannielArias_AP1_P2.DAL;
using FrannielArias_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrannielArias_AP1_P2.Services
{
    public class ArticulosService(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> Criterio)
        {
            await using var _contexto = await DbFactory.CreateDbContextAsync();

            return await _contexto.Articulo
                .AsNoTracking()
                .Where(Criterio)
                .ToListAsync();
        }
    }
}
