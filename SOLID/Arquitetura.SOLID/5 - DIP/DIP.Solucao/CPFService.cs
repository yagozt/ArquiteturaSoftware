using Arquitetura.SOLID.DIP.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.DIP.Solucao
{
    public class CPFService : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
