using Beach_Service_API.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beach_Service_API.Infrastructure.Data.Config
{
    public class ProdutosUserConfiguration : IEntityTypeConfiguration<ProdutosUser>
    {
        public void Configure(EntityTypeBuilder<ProdutosUser> builder)
        {
            builder.HasKey(x => new { x.UserId, x.ProdutoId });
        }
    }
}
