using FrannielArias_AP1_P2.DAL;
using FrannielArias_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrannielArias_AP1_P2.Services;

public class ComboService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Guardar(Combos combo)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        if (!await Existe(combo.ComboId))
        {
            return await Insertar(combo);
        }
        else
        {
            return await Modificar(combo);
        }
    }

    private async Task<bool> Modificar(Combos combo)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        _contexto.Update(combo);
        return await _contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Insertar(Combos combo)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        _contexto.Add(combo);
        return await _contexto.SaveChangesAsync() > 0;
    }


    private async Task<bool> Existe(int comboId)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        return await _contexto.Combo
            .AnyAsync(c=> c.ComboId == comboId);
    }

    public async Task<Combos?> Buscar(Combos combo)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        return await _contexto.Combo
            .Where(c => c.ComboId == combo.ComboId)
            .FirstOrDefaultAsync();
    }

    public async Task<bool> Eliminar(int combo)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();
        return await _contexto.Combo
            .AsNoTracking()
            .Where(c=> c.ComboId == combo)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> Criterio)
    {
        await using var _contexto = await DbFactory.CreateDbContextAsync();

        return await _contexto.Combo
            .AsNoTracking()
            .Where(Criterio)
            .ToListAsync();
    }
}
