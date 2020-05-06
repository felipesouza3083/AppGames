using AppGames.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Dados.Mapping
{
    public class PlataformaMap : IEntityTypeConfiguration<Plataforma>
    {
        public void Configure(EntityTypeBuilder<Plataforma> builder)
        {
            builder.HasKey(p => p.IdPlataforma);

            builder.Property(p => p.IdPlataforma)
                .HasColumnName("IdPlataforma")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
