using Boacao.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Boacao.Data;

public class AppDbContext : IdentityDbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Doador> Doadores { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Depoimento> Depoimentos { get; set; }
    public DbSet<Galeria> Galerias { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);

    }

}
