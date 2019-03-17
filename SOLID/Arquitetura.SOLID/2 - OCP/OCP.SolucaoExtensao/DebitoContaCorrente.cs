namespace Arquitetura.SOLID.OCP.OCP.SolucaoExtensao
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta) => debitoConta.FormatarTransacao();
    }
}
