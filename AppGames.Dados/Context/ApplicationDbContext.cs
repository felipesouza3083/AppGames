using AppGames.Dados.Mapping;
using AppGames.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Dados.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlataformaMap());
            modelBuilder.ApplyConfiguration(new GameMap());
        }

        public DbSet<Plataforma> Plataforma { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
