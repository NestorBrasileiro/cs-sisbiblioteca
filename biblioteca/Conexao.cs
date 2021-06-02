using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Constructor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=treinamento;Integrated Security=True";
        }
        //Método de Conectar com banco de dados
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Método desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }


    }
}
