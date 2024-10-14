namespace TesteBrPartners.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public TipoEndereco Tipo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }

    public enum TipoEndereco
    {
        Fiscal,
        Cobranca,
        Entrega
    }
}