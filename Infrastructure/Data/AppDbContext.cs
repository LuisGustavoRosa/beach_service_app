using Beach_Service_API.Domain.Entitites;
using Beach_Service_API.Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Beach_Service_API.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<ProdutosUser> produto_usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutosUserConfiguration());
        }
    }
}
