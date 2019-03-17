using System;

namespace Arquitetura.OOP
{
    public class Funcionario : Pessoa
    {
        public Funcionario (string nome, DateTime dataNascimento) : base (nome, dataNascimento)
        { }

        public DateTime DataAdmissao { get; set; }

    }
}
