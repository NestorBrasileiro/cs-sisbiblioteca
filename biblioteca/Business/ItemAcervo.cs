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
    class ItemAcervo
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        
       public string mensagem;


        public DataGridView Dgv { get; set; }
        
        public string CodItem { get; set; }
        public string NomeItem { get; set; }

        public string CodAutor { get; set; }
        
        public string CodEditora { get; set; }
        
        public string CodSecao { get; set; }
        
        public string CodLocal { get; set; }
        
        public string TipoItem { get; set; }
        public string Volume { get; set; }
        public string AnoEdicao { get; set; }
        public string NumExemplar { get; set; }
        public string Idioma { get; set; }
        public string Colecao { get; set; }
        public string Situacao { get; set; }
        


        public void CadastrarItem()
        {
            cmd.CommandText = "INSERT INTO MvtBIBItemAcervo (nome, codLocal, codAutor, codEditora, codSecao, volume, anoEdicao, numExemplar, tipoItem, idioma, colecao, situacao)" +
                "VALUES (@nome, @codLocal, @codAutor, @codEditora, @codSecao, @volume, @anoEdicao, @numExemplar, @tipoItem, @idioma, @colecao, @situacao)";
            try
            {

                cmd.Parameters.AddWithValue("@nome", NomeItem);
                cmd.Parameters.AddWithValue("@codLocal", int.Parse(CodLocal));
                cmd.Parameters.AddWithValue("@codAutor", int.Parse(CodAutor));
                cmd.Parameters.AddWithValue("@codEditora", int.Parse(CodEditora));
                cmd.Parameters.AddWithValue("@codSecao", int.Parse(CodSecao));
                cmd.Parameters.AddWithValue("@volume", int.Parse(Volume));
                cmd.Parameters.AddWithValue("@anoEdicao", int.Parse(AnoEdicao));
                cmd.Parameters.AddWithValue("@numExemplar", int.Parse(NumExemplar));
                cmd.Parameters.AddWithValue("@tipoItem", TipoItem);
                cmd.Parameters.AddWithValue("@idioma", Idioma);
                cmd.Parameters.AddWithValue("@colecao", Colecao);
                cmd.Parameters.AddWithValue("@situacao", Situacao);            

                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de Conexão com o DB." + e;
            }
            finally
            {
                conexao.desconectar();
            }


        }public void EditarItem()
        {
            cmd.CommandText = "UPDATE MvtBIBItemAcervo SET  " +
                "nome = @nome, codLocal = @codLocal, codAutor = @codAutor, codEditora = @codEditora, codSecao = @codSecao, volume = @volume, anoEdicao = @anoEdicao, numExemplar = @numExemplar, tipoItem = @tipoItem, idioma = @idioma, colecao = @colecao, situacao = @situacao " +
                "WHERE codItem = @codItem";

            try
            {
                cmd.Parameters.AddWithValue("@codItem", int.Parse(CodItem));
                cmd.Parameters.AddWithValue("@nome", NomeItem);
                cmd.Parameters.AddWithValue("@codLocal", int.Parse(CodLocal));
                cmd.Parameters.AddWithValue("@codAutor", int.Parse(CodAutor));
                cmd.Parameters.AddWithValue("@codEditora", int.Parse(CodEditora));
                cmd.Parameters.AddWithValue("@codSecao", int.Parse(CodSecao));
                cmd.Parameters.AddWithValue("@volume", int.Parse(Volume));
                cmd.Parameters.AddWithValue("@anoEdicao", int.Parse(AnoEdicao));
                cmd.Parameters.AddWithValue("@numExemplar", int.Parse(NumExemplar));
                cmd.Parameters.AddWithValue("@tipoItem", TipoItem);
                cmd.Parameters.AddWithValue("@idioma", Idioma);
                cmd.Parameters.AddWithValue("@colecao", Colecao);
                cmd.Parameters.AddWithValue("@situacao", Situacao);

                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Editado com Sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de Conexão com o DB." + e;
            }
            finally
            {
                conexao.desconectar();
            }
        }
        
        
        
        
        
        
        public void ExcluirItem()
        {
            cmd.CommandText = "DELETE FROM " +
                "MvtBIBItemAcervo where codItem = @codItem";

            try
            {
                cmd.Parameters.AddWithValue("@codItem", CodItem);

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
            //COMANDOS A SEREM MUDADOS!!!!!
            try
            {
                cmd.CommandText = "SELECT Item.codItem, Item.nome, Item.numExemplar, Item.tipoItem, Item.situacao, Autor.codAutor, Autor.nome, Editora.codEditora, Editora.nome, Localizacao.codLocal, Localizacao.descricaoLocal, Secao.codSecao, Secao.descricaoSecao, Item.colecao, Item.volume, Item.idioma, Item.anoEdicao FROM MvtBIBItemAcervo AS Item INNER JOIN MvtBIBLocal AS Localizacao ON Localizacao.codLocal = Item.codLocal INNER JOIN MvtBIBAutor AS Autor ON Autor.codAutor = Item.codAutor INNER JOIN MvtBIBEditora AS Editora On Editora.codEditora = Item.codEditora INNER JOIN MvtBIBSecao AS Secao ON Secao.codSecao = Item.codSecao;";


                da = new SqlDataAdapter(cmd.CommandText, conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro ao se conectar como banco de dados" + _e;
            }

        }
    }
}
  