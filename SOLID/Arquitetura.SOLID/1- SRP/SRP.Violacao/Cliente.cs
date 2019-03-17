using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Arquitetura.SOLID.SRP.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Email inválido";
            if (Cpf.Length != 11)
                return "Cpf inválido";

            using(var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert INTO Cliente ()";

                cmd.Parameters.AddWithValue("nome", Nome);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            return "Cliente adicionado com sucesso";
        }
    }

}
