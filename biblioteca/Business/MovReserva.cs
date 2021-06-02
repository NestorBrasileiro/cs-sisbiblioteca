using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca.Business
{
    class MovReserva
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public DataGridView Dgv { get; set; }
        
        public string CodItem {get;set;}
        
        public string CodLeitor {get;set;}
        
        public DateTime DataReserva {get;set;}
        public DateTime PrazoReserva {get;set;}

        private string Situacao {get;set;}

        public void Reservar()
        {
            Situacao = "Emprestado";

            cmd.CommandText = "INSERT INTO MvtBIBReserva (codItem, codLeitor, dataReserva, prazoReserva)" +
                "VALUES (@codItem, @codLeitor ,@dataReserva ,@prazoReserva)";
            try
            {
                cmd.Parameters.AddWithValue("@codItem", int.Parse(CodItem));
                            
                cmd.Parameters.AddWithValue("@codLeitor", int.Parse(CodLeitor));
                
                cmd.Parameters.AddWithValue("@dataReserva", DataReserva);
                cmd.Parameters.AddWithValue("@prazoReserva", PrazoReserva);
                
                
                // Conectar com o banco de dados

                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Reservado com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de Conexão com o DB." + e;
            }
            finally
            {
                conexao.desconectar();
            }
            cmd.CommandText = "UPDATE MvtBIBItemAcervo SET situacao = @Situacao WHERE codItem = @codItem";
            cmd.Parameters.AddWithValue("@situacao", Situacao);
            try { 
            cmd.Connection = conexao.conectar();
            // Executar o comando
            cmd.ExecuteNonQuery();
            // Desconectar
            conexao.desconectar();
            // Mostrar mensagem de erro ou sucesso
            this.mensagem = "Reservado com Sucesso";
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
        public void Devolver()
        {

            Situacao = "Disponível";
            cmd.CommandText = "UPDATE MvtBIBItemAcervo SET situacao = @Situacao where codItem = @codItem; DELETE FROM MvtBIBReserva Where codItem = @codItem;"; 
            
            cmd.Parameters.AddWithValue("@codItem", int.Parse(CodItem));
            cmd.Parameters.AddWithValue("@situacao", Situacao);

            try
            {
                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Devolvido com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Update da Item acervo" + e;
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


            // COMANDO SELECT TEM QUE SER ALTERADO
            
            try
            {
                cmd.CommandText = "SELECT Reserva.codItem, Item.nome [Item], Autor.codAutor, Autor.nome [Autor], Item.numExemplar, Item.situacao, Item.tipoItem, Leitor.codLeitor, Leitor.leitor[Leitor], Reserva.dataReserva, Reserva.prazoReserva, Localizacao.codLocal, Localizacao.descricaoLocal FROM MvtBIBReserva AS Reserva INNER JOIN MvtBIBItemAcervo AS Item ON Reserva.codItem = Item.codItem INNER JOIN MvtBIBAutor AS Autor ON Autor.codAutor = Item.codAutor INNER JOIN MvtBIBLeitor AS Leitor ON Leitor.codLeitor = Reserva.codLeitor INNER JOIN MvtBIBLocal AS Localizacao ON Localizacao.codLocal = Item.codLocal;";

                da = new SqlDataAdapter(cmd.CommandText, conexao.conectar()); // não usar o select *
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;
            }
            catch (SqlException _e)
            {
                this.mensagem = "Erro ao se conectar como banco de dados" + _e;
            }
            finally
            {
                conexao.desconectar();
            }

        }



    }
}
