using Beach_Service_API.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beach_Service_API.Infrastructure.Data.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired();
            builder.HasOne(x => x.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(x => x.CategoriaId)
                .IsRequired();

            builder
                .HasMany(p => p.ProdutosUsuarios)
                .WithOne(pu => pu.Produto)
                .HasForeignKey(pu => pu.ProdutoId);
        }
    }
}
