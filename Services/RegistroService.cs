using FrannielArias_AP1_P2.DAL;
using FrannielArias_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrannielArias_AP1_P2.Services;

public class RegistroService(IDbContextFactory<Contexto> DbFactory)
{
    //public async Task<bool> Guardar()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //private async Task<bool> Modificar()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //private async Task<bool> Insertar()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //private async Task<bool> Existe()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //public async Task<Registro?> Buscar()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //public async Task<bool> Eliminar()
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //    return true;
    //}

    //public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> Criterio)
    //{
    //    await using var _contexto = await DbFactory.CreateDbContextAsync();
    //}
}
