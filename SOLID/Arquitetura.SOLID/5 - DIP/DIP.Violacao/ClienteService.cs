namespace Arquitetura.SOLID.DIP.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo", "Bem vindo");

            return "Cliente cadastrado com sucesso";
        }
    }
}
