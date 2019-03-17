using System;
using Arquitetura.SOLID.DIP.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.DIP.Solucao
{
    public class Cliente
    {
        private readonly IEmailServices _emailServices;
        private readonly ICPFServices _cpfServices;

        public Cliente(IEmailServices emailServices, ICPFServices cpfServices)
        {
            _emailServices = emailServices;
            _cpfServices = cpfServices;
        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cpfServices.IsValid(Cpf);
        }
    }
}
