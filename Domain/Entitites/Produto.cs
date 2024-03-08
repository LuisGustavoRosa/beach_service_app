namespace Beach_Service_API.Domain.Entitites
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = new Categoria();

        public List<ProdutosUser> ProdutosUsuarios { get; set; } = new List<ProdutosUser>();

    }
}
