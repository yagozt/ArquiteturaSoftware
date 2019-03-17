using Arquitetura.SOLID.DIP.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.DIP.Solucao
{
    public class ClienteService : IClienteServices
    {
        private readonly IEmailServices _emailServies;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(
            IEmailServices emailServices,
            IClienteRepository clienteRepository)
        {
            _emailServies = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServies.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo", "Bem vindo");

            return "Cliente cadastrado com sucesso";
        }
    }
}
