﻿namespace TesteBrPartners.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
