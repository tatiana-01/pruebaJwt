using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class PruebaJwtContext : DbContext
{
    public PruebaJwtContext(DbContextOptions<PruebaJwtContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios {get;set;}
    public DbSet<UsuariosRoles> UsuariosRoles {get;set;}
    public DbSet<Rol> Roles {get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
