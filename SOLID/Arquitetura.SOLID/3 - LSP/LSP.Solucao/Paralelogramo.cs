namespace Arquitetura.SOLID.LSP.LSP.Solucao
{
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
