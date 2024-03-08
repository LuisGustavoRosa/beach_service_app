using Beach_Service_API.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beach_Service_API.Infrastructure.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(300);
            builder.Property(c => c.Empresa).HasMaxLength(100);
            builder.Property(c => c.Cep).HasMaxLength(100);
            builder.Property(c => c.Telefone).HasMaxLength(100);
            builder.Property(c => c.Data_de_Nascimento).IsRequired();
            builder.Property(c => c.Tipo_Usuario).IsRequired();
            builder.Property(c => c.Longitude).IsRequired().HasPrecision(14, 2);
            builder.Property(c => c.Latitude).IsRequired().HasPrecision(14, 2);
            builder.Property(c => c.Distancia).IsRequired();
            builder.Property(c => c.Online).HasPrecision(14, 2);


            builder
            .HasMany(u => u.ProdutosUsuarios)
            .WithOne(pu => pu.User)
            .HasForeignKey(pu => pu.UserId);
        }
    }
}
