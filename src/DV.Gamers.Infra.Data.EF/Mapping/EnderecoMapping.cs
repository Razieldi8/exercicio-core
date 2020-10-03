using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Logradouro).IsRequired();
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.Cidade).IsRequired();
            builder.Property(p => p.Estado).IsRequired();
            builder.Property(p => p.Ativo).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();

            builder.HasOne(e => e.Pessoa)
                   .WithMany(p => p.Enderecos).HasForeignKey(p1 => p1.PessoaId);


            builder.ToTable("Endereco");
        }
    }
}
