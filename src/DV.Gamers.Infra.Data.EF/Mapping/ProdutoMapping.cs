using DV.Gamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DV.Gamers.Infra.Data.EF.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descriacao).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();
            builder.Property(p => p.Ativo).IsRequired();
            builder.HasOne(p => p.Categoria).WithMany(c => c.Produtos).HasForeignKey(f => f.CategoriaId);

            builder.ToTable("Produto");
        }
    }
}
