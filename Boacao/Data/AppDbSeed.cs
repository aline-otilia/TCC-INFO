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
                Nome = "Livros e papelaria"
            },
            new Categoria() {
                Id = 2,
                Nome = "Games e PC Gamer"
            },
            new Categoria() {
                Id = 3,
                Nome = "Informática"
            },
            new Categoria() {
                Id = 4,
                Nome = "Smartphones"
            },
            new Categoria() {
                Id = 5,
                Nome = "Eletrodomesticos e Casa"
            },
            new Categoria() {
                Id = 6,
                Nome = "Beleza e Perfumaria"
            },
            new Categoria() {
                Id = 7,
                Nome = "Móveis e Decoração"
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion
    }
}
