using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DDD).IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();
            builder.Property(p => p.Ativo).IsRequired();

            builder.ToTable("Telefone");
        }
    }
}
