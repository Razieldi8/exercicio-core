using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class JogoMapping : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descriacao).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();
            builder.Property(p => p.Ativo).IsRequired();
            builder.Property(p => p.Genero);

            builder.ToTable("Jogo");
        }
    }
}
