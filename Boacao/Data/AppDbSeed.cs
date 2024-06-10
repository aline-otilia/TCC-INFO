using Boacao.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Boacao.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populando os dados de Perfil de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@boacao.com.br",
                NormalizedEmail = "ADMIN@BOACAO.COM.BR",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            },
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "alinesantos@hotmail.com",
                NormalizedEmail = "ALINESANTOS@HOTMAIL.COM",
                UserName = "Aline",
                NormalizedUserName = "ALINE",
                LockoutEnabled = false,
                EmailConfirmed = true,
            },
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Doador> doadores = new(){
            new Doador(){
                DoadorId = users[0].Id,
                NomePessoa = "Administrador",
                DataCadastro = DateTime.Now,
            },
            new Doador(){
                DoadorId = users[1].Id,
                NomePessoa = "Aline Santos",
                DataCadastro = DateTime.Now,
            }
        };
        builder.Entity<Doador>().HasData(doadores);
        #endregion

        #region Popular Categorias
        List<Categoria> categorias = new(){
            new Categoria() {
                Id = 1,
                Nome = "Alimentos"
            },
            new Categoria() {
                Id = 2,
                Nome = "Sangue"
            },
            new Categoria() {
                Id = 3,
                Nome = "Ração"
            },
            new Categoria() {
                Id = 4,
                Nome = "Movéis"
            },
            new Categoria() {
                Id = 5,
                Nome = "Roupas"
            },
            new Categoria() {
                Id = 6,
                Nome = "Diversos"
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion


           #region Popular Produtos de Doações
List<Produto> produtosDoacoes = new(){
    new Produto() { 
        Id = 1,
        Nome = "Alimentos não perecíveis", 
        Descricao = "Itens como arroz, feijão, macarrão, etc.", 
        //CategoriaId = 1, 
        Foto = "alimentos.jpg" 
    },
    new Produto() { 
        Id = 2,
        Nome = "Roupas", 
        Descricao = "Roupas em bom estado para adultos e crianças", 
        //CategoriaId = 2, 
        Foto = "roupas.jpg" 
    },
    new Produto() { 
        Id = 3,
        Nome = "Brinquedos", 
        Descricao = "Brinquedos para crianças de todas as idades", 
        //CategoriaId = 3, 
        Foto = "brinquedos.jpg" 
    },
    new Produto() { 
        Id = 4,
        Nome = "Material Escolar", 
        Descricao = "Cadernos, lápis, borrachas, etc.", 
        //CategoriaId = 4, 
        Foto = "material-escolar.jpg" 
    }
};

builder.Entity<Produto>().HasData(produtosDoacoes);
#endregion
    }
}
