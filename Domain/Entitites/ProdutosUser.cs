namespace Beach_Service_API.Domain.Entitites
{
    public class ProdutosUser
    {
        public int UserId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Usuario User { get; set; } = new Usuario();
        public Produto Produto { get; set; } = new Produto();
    }
}
