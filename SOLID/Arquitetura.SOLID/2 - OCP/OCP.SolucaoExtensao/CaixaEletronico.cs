using System;

namespace Arquitetura.SOLID.OCP.OCP.SolucaoExtensao
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {
            MenuOperacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            DebitoConta debitoConta = DadosDebito();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Conta Corrente");
                    retorno = debitoConta.DebitarContaCorrente();
                    break;
                case '2':
                    Console.WriteLine("Conta Poupanca");
                    retorno = debitoConta.DebitarContaPoupanca();
                    break;
                case '3':
                    break;

            }
        }

        private static void MenuOperacoes()
        {
            throw new NotImplementedException();
        }

        private static DebitoConta DadosDebito()
        {
            throw new NotImplementedException();
        }
    }
}
