using AppGames.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Dados.Mapping
{
    public class GameMap : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Game");

            builder.HasKey(g => g.IdGame);

            builder.Property(g => g.IdGame)
                .HasColumnName("IdGame")
                .IsRequired();

            builder.Property(g => g.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(g => g.IdPlataforma)
                .HasColumnName("IdPlataforma")
                .IsRequired();

            builder.HasOne(g => g.Plataforma)
                .WithMany(p => p.Games)
                .HasForeignKey(g => g.IdPlataforma);
        }
    }
}
