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
    class Local
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        

        public string mensagem = "";

        private string codLocal;
        private string descricaoLocal;
        private DataGridView dgv;

        public string Cod
        {
            get { return codLocal; }
            set { codLocal = value; }
        }
        public string Descricao
        {
            get { return descricaoLocal; }
            set { descricaoLocal = value; }
        }
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }
        
        public void CadastrarLocal()
        {
                // Comando SQL == insert, update, delete. ----SqlComand
                cmd.CommandText = "INSERT INTO MvtBIBLocal(descricaoLocal) VALUES (@descricao)";

                // Parâmetros
                cmd.Parameters.AddWithValue("@descricao", Descricao);


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
        public void ExcluirLocal()
        {
          
                cmd.CommandText = "DELETE FROM MvtBIBLocal WHERE codLocal = @codLocal";
                cmd.Parameters.AddWithValue("@codLocal", int.Parse(Cod));


            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Excluído com sucesso!";
            }
            catch(Exception _e)
            {
                this.mensagem = "Erro de conexão com o banco de dados \n" + _e;

            }
            finally
            {
                conexao.desconectar();
            }




        }
        public void EditarLocal()
        {
            try
            {
                cmd.CommandText = "UPDATE MvtBIBLocal SET descricaoLocal = @descricao Where codLocal = @codLocal";
                cmd.Parameters.AddWithValue("@codLocal", int.Parse(Cod));
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Editado com sucesso";
            }
            catch(Exception _e)
            {
                this.mensagem = "erro de conexão com o banco de dados \n" + _e;

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

                da = new SqlDataAdapter("SELECT codLocal, descricaoLocal FROM MvtBIBLocal", conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro ao se conectar como banco de dados" + _e;
            }
            finally { conexao.desconectar(); }

        }
        public void BuscaDataGrid(string nome)
        {
            try
            {
                da = new SqlDataAdapter(String.Format("SELECT codLocal, descricaoLocal FROM MvtBIBLocal where descricaoLocal LIKE '%{0}%'", nome), conexao.conectar());
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;

            }
            catch (SqlException _e)
            {
                MessageBox.Show("Sem conexão, busca mal sucedida!" + _e);
            }
            finally
            {
                conexao.desconectar();
            }

        }

    }


    }

