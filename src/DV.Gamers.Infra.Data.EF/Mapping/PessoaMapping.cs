using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Sobrenome);
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();
            
            builder.ToTable("Pessoa");

        }
    }
}
