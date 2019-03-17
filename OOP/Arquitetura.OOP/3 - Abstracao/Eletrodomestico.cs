namespace Arquitetura.OOP
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        public string Nome
        {
            get { return _nome; }
        }
        private readonly int _voltagem;

        protected Eletrodomestico (string nome, int voltagem)
        {
            this._nome = nome;
            this._voltagem = voltagem;
        }

        public int Voltagem
        {
            get { return _voltagem; }
        }

    }
}
