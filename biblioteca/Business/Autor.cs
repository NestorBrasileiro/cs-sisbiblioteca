
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
    public class Autor
    {
       
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        private string codAutor;
        private string nomeAutor;
        private string infoAutor;
        private DataGridView dgv;

        public string CodAutor
        {
            get { return codAutor; }
            set { codAutor = value; }
        }
        public string NomeAutor
        {
            get { return nomeAutor; }
            set { nomeAutor = value; }
        }
        public string InfoAutor
        {
            get { return infoAutor; }
            set { infoAutor = value; }
        }
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }



        public String mensagem = "";

        //constructor
        public void CadastroAutor()
        {
            

            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "INSERT INTO MvtBIBAutor (nome, descricao) VALUES (@nome, @descricao)";

            // Parâmetros
            cmd.Parameters.AddWithValue("@nome", NomeAutor);
            cmd.Parameters.AddWithValue("@descricao", InfoAutor);


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
        public void EditarAutor()
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = (
                "UPDATE MvtBIBAutor SET nome = @nomeAutor, descricao = @infoAutor WHERE codAutor = @codAutor"
                );

            cmd.Parameters.AddWithValue("@codAutor", int.Parse(CodAutor));
            cmd.Parameters.AddWithValue("@nomeAutor", NomeAutor);
            cmd.Parameters.AddWithValue("@infoAutor", InfoAutor);

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
        public void ExcluirAutor(string txtCod)
        {
            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "DELETE FROM MvtBIBAutor WHERE codAutor = @codAutor";

            // Parâmetros
            cmd.Parameters.AddWithValue("@codAutor", int.Parse(txtCod));

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
                this.mensagem = "Erro de Conexão com o DB." + e;
                conexao.desconectar();
            }finally
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
                
                da = new SqlDataAdapter("SELECT codAutor, nome, descricao FROM MvtBIBAutor", conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;
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
                da = new SqlDataAdapter(String.Format("SELECT codAutor,nome,descricao FROM MvtBIBAutor where nome LIKE '%{0}%'", nome), conexao.conectar());
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








        
    
