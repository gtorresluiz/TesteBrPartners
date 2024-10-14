using System.ComponentModel.DataAnnotations;

namespace TesteBrPartners.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public TipoEndereco TipoEndereco { get; set; }

        public int ClienteId { get; set; } 

        public Cliente? Cliente { get; set; }  
    }

    public enum TipoEndereco
    {
        Fiscal = 0,
        Cobranca = 1,
        Entrega = 2
    }
}