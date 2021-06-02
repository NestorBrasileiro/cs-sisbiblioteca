using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public class Editora
    {
        readonly Conexao conexao = new Conexao();
        readonly SqlCommand cmd = new SqlCommand();

        public String mensagem = "";
        private string codEditora;
        private string nomeEditora;
        private DataGridView dgv;

        public string CodEditora
        {
            get { return codEditora; }
            set { codEditora = value; }
        }
        public string NomeEditora
        {
            get { return nomeEditora; }
            set { nomeEditora = value; }
        }
        
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }
        //constructor
        public void CadastroEditora()
        {

            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "INSERT INTO MvtBIBEditora (nome) VALUES (@nome)";

            // Parâmetros
            
                cmd.Parameters.AddWithValue("@nome", NomeEditora);
            
           

            try
            {
                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro de Conexão com o DB. \n" + _e;
            }
            finally
            {
                conexao.desconectar();
            }
        }public void ExcluirEditora()
        {
            cmd.CommandText = "DELETE FROM MvtBIBEditora WHERE codEditora = @codEditora";
            cmd.Parameters.AddWithValue("@codEditora", int.Parse(CodEditora));
            try {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Exluido com sucesso!";
            }
            catch (SqlException e)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados" + e);
            }
            finally
            {
                conexao.desconectar();
            }
            
        }
        public void EditarEditora()
        {

            cmd.CommandText = (
                "UPDATE MvtBIBEditora SET nome = @nomeEditora WHERE codEditora = @codEditora"
                );

            cmd.Parameters.AddWithValue("@codEditora", int.Parse(CodEditora));
            cmd.Parameters.AddWithValue("@nomeEditora", NomeEditora);
            

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Alteração feita com sucesso.";
            }
            catch (SqlException e)
            {
                MessageBox.Show(this.mensagem = "Erro ao se conectar com o banco de dados" + e);
            }
            finally
            {
                conexao.desconectar();
            }

        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dataTable;


        public void AtualizarDataGrid()
        {
            try
            {

                da = new SqlDataAdapter("SELECT codEditora, nome FROM MvtBIBEditora", conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro ao se conectar como banco de dados" + _e;
            }

        }
        public void BuscaDataGrid(string nome)
        {
            try
            {
                da = new SqlDataAdapter(String.Format("SELECT codEditora, nome FROM MvtBIBEditora where nome LIKE '%{0}%'", nome), conexao.conectar());
                dataTable = new DataTable();
                da.Fill(dataTable);
                dgv.DataSource = dataTable;

            }
            catch (SqlException _e)
            {
                MessageBox.Show("Sem conexão, busca mal sucedida!" + _e);
            }

        }
    }
}
