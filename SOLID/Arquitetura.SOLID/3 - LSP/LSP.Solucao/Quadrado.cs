using System;

namespace Arquitetura.SOLID.LSP.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (altura != largura)
                throw new ArgumentException("Os dois lados do quadrado devem ser iguais.");
        }

    }
}
