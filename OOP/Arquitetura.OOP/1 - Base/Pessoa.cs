using System;

namespace Arquitetura.OOP
{
    public class Pessoa
    {
        public Pessoa (string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;

        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
