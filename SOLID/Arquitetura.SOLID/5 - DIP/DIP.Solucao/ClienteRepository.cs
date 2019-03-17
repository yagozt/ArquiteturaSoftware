using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using Arquitetura.SOLID.DIP.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.DIP.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using(var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert INTO Cliente ()";

                cmd.Parameters.AddWithValue("Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("Email", cliente.Email);
                cmd.Parameters.AddWithValue("Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("DataCadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
