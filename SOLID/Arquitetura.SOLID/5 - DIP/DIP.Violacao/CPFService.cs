namespace Arquitetura.SOLID.DIP.DIP.Violacao
{
    public static class CPFService
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
