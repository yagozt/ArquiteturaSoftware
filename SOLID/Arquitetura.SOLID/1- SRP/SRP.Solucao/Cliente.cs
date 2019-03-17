using System;

namespace Arquitetura.SOLID.SRP.SRP.Solucao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.IsValid(Cpf);
        }
    }
}
