using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.RazaoSocial).IsRequired();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Ativo).IsRequired();
            builder.Property(p => p.CpfCnpj).IsRequired();
            builder.Property(p => p.CriadoEm);

            builder.ToTable("Fornecedor");
        }
    }
}
