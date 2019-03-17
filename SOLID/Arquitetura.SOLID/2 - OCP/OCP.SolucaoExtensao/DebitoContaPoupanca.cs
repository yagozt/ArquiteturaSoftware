namespace Arquitetura.SOLID.OCP.OCP.SolucaoExtensao
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta) => debitoConta.FormatarTransacao();
    }
}
