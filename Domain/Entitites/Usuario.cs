using Beach_Service_API.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Beach_Service_API.Domain.Entitites
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime Data_de_Nascimento { get; set; }
        public E_TipoUsuario Tipo_Usuario { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Distancia { get; set; }
        public bool Online { get; set; }
        public List<ProdutosUser> ProdutosUsuarios { get; set; } = new List<ProdutosUser>();
    }
}
