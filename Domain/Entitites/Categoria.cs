namespace Beach_Service_API.Domain.Entitites
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
