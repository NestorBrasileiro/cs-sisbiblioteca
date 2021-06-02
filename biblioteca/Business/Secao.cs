using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    class Secao

    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        private string codSecao;
        private string infoSecao;
        private DataGridView dgv;

        public string CodSecao
        {
            get { return codSecao; }
            set { codSecao = value; }
        }
        
        public string InfoSecao
        {
            get { return infoSecao; }
            set { infoSecao = value; }
        }
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }



        public String mensagem = "";

        //constructor
        public void CadastrarSecao()
        {


            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "INSERT INTO MvtBIBSecao (descricaoSecao) VALUES (@descricao)";

            // Parâmetros
            
            cmd.Parameters.AddWithValue("@descricao", InfoSecao);


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
            catch (SqlException e)
            {
                this.mensagem = "Erro de Conexão com o DB." + e;
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void EditarSecao()
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = (
                "UPDATE MvtBIBSecao SET descricaoSecao = @infoSecao WHERE codSecao = @codSecao"
                );

            cmd.Parameters.AddWithValue("@codSecao", int.Parse(CodSecao));
            
            cmd.Parameters.AddWithValue("@infoSecao", InfoSecao);

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
        public void ExcluirSecao(string txtCod)
        {
            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "DELETE FROM MvtBIBSecao WHERE codSecao = @codSecao";

            // Parâmetros
            cmd.Parameters.AddWithValue("@codSecao", int.Parse(txtCod));

            try
            {
                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Excluído com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de Conexão com o DB." +e;
                conexao.desconectar();
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

                da = new SqlDataAdapter("SELECT codSecao, descricaoSecao FROM MvtBIBSecao", conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro ao se conectar como banco de dados" + _e;
            }

        }
        public void BuscaDataGrid(string descricao)
        {
            try
            {
                da = new SqlDataAdapter(String.Format("SELECT codSecao,descricaoSecao FROM MvtBIBSecao where descricaoSecao LIKE '%{0}%'", descricao), conexao.conectar());
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;

            }
            catch (SqlException _e)
            {
                MessageBox.Show("Sem conexão, busca mal sucedida!" + _e);
            }

        }


    }
}
