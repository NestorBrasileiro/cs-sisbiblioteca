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

    public class Leitor
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public string mensagem;

        private string codLeitor;
        private string nomeLeitor;
        private string sexoLeitor;
        
        private string cpfLeitor;
        private string rgLeitor;
        private string emailLeitor;
        private string telLeitor;
        private string telCelLeitor;
        private string endRuaLeitor;
        private string endBairroLeitor;
        private string endCidadeLeitor;
        private string endCepLeitor;
        private string endUfLeitor;
        private string endNumLeitor;
        


        public string Cod { get { return codLeitor; } set { codLeitor = value; } }
        public string Nome { get { return nomeLeitor; } set { nomeLeitor = value; } }
        public string Sexo { get { return sexoLeitor; } set { sexoLeitor = value; } }
        public DateTime DataNasc { get; set; }
        public string Cpf { get { return cpfLeitor; } set { cpfLeitor = value; } }
        public string Rg { get { return rgLeitor; } set { rgLeitor = value; } }
        public string Email { get { return emailLeitor; } set { emailLeitor = value; } }
        public string Tel { get { return telLeitor; } set { telLeitor = value; } }
        public string TelCel { get { return telCelLeitor; } set { telCelLeitor = value; } }
        public string EndRua { get { return endRuaLeitor; } set { endRuaLeitor = value; } }
        public string EndBairro { get { return endBairroLeitor; } set { endBairroLeitor = value; } }
        public string EndCidade { get { return endCidadeLeitor; } set { endCidadeLeitor = value; } }
        public string EndCep { get { return endCepLeitor; } set { endCepLeitor = value; } }
        public string EndUf { get { return endUfLeitor; } set { endUfLeitor = value; } }
        public string EndNum { get { return endNumLeitor; } set { endNumLeitor = value; } }
        public DataGridView Dgv { get;  set;  }


        public bool ValidaCPF(string Cpf)

        {
            string valor = Cpf;
            
            if (valor.Length != 11)
                return false;
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;
            if (igual || valor == "12345678909")
                return false;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;

        }




        //constructor
        public void CadastroLeitor()
        {
            Sexo = Sexo.Substring(0, 1);

            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "INSERT INTO MvtBIBLeitor (leitor,sexo,dataNascimento,cpf,rg,email,telefone,telefoneCelular,enderecoNome,enderecoBairro,enderecoCidade,enderecoCep,enderecoUF,enderecoNumero) " +
            "VALUES" +
            " (@nomeLeitor,@sexo,@dataNascimento,@cpf,@rg,@email,@telefone,@telefoneCelular,@endNome,@endBairro,@endCidade,@endCep,@estado,@endNumero)";

            // Parâmetros

            

            //Esses são parâmetros obrigatórios.

            cmd.Parameters.AddWithValue("@nomeLeitor", Nome);
            cmd.Parameters.AddWithValue("@sexo", Sexo);
            cmd.Parameters.AddWithValue("@dataNascimento", DataNasc);
            cmd.Parameters.AddWithValue("@endNome", EndRua);
            cmd.Parameters.AddWithValue("@endBairro", EndBairro);
            cmd.Parameters.AddWithValue("@endCidade", EndCidade);
            cmd.Parameters.AddWithValue("@estado", EndUf);
            cmd.Parameters.AddWithValue("@endNumero", EndNum);


            //Parâmetros não obrigatórios.
            cmd.Parameters.AddWithValue("@endCep", EndCep);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@rg", Rg);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone", Tel);
            cmd.Parameters.AddWithValue("@telefoneCelular", TelCel);

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
        public void EditarLeitor()
        {

            Sexo = Sexo.Substring(0, 1);

            cmd.CommandText = (
               "UPDATE MvtBIBLeitor SET leitor = @nomeLeitor, sexo = @sexo, dataNascimento = @dataNascimento," +
               "cpf = @cpf,rg = @rg,email = @email,telefone = @telefone,telefoneCelular = @telefoneCelular," +
               "enderecoNome = @endNome,enderecoBairro = @endBairro,enderecoCidade = @endCidade,enderecoCEP = @endCep," +
               "enderecoUF = @estado,enderecoNumero = @endNumero WHERE codLeitor = @codLeitor"
                );
            //Esses são parâmetros obrigatórios.
            cmd.Parameters.AddWithValue("@codLeitor", int.Parse(Cod));
            cmd.Parameters.AddWithValue("@nomeLeitor", Nome);
            cmd.Parameters.AddWithValue("@sexo", Sexo);
            cmd.Parameters.AddWithValue("@dataNascimento", DataNasc);
            cmd.Parameters.AddWithValue("@endNome", EndRua);
            cmd.Parameters.AddWithValue("@endBairro", EndBairro);
            cmd.Parameters.AddWithValue("@endCidade", EndCidade);
            cmd.Parameters.AddWithValue("@estado", EndUf);
            cmd.Parameters.AddWithValue("@endNumero", EndNum);


            //Parâmetros não obrigatórios.
            cmd.Parameters.AddWithValue("@endCep", EndCep);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@rg", Rg);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefone", Tel);
            cmd.Parameters.AddWithValue("@telefoneCelular", TelCel);


            try
            {
                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                //// Mostrar mensagem de erro ou sucesso
                this.mensagem = "Editado com Sucesso";
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
        public void ExcluirLeitor()
        {

            // Comando SQL == insert, update, delete. ----SqlComand
            cmd.CommandText = "DELETE FROM MvtBIBLeitor WHERE codLeitor = @codLeitor";


            //Esses são parâmetros obrigatórios.
            cmd.Parameters.AddWithValue("@codLeitor", int.Parse(Cod));



            //Parâmetros não obrigatórios.


            try
            {
                // Conectar com o banco de dados
                cmd.Connection = conexao.conectar();
                // Executar o comando
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mostrar mensagem de erro ou sucesso
                this.mensagem = "Excluído com sucesso";
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
        


        public void AtualizarDataGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dataTable;
            try
            {

                da = new SqlDataAdapter("SELECT codLeitor ,leitor,sexo,dataNascimento,cpf,rg,email,telefone,telefoneCelular,enderecoNome,enderecoBairro,enderecoCidade,enderecoCep,enderecoUF,enderecoNumero FROM MvtBIBLeitor", conexao.conectar()); // não usar o select *
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
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dataTable;
            try
            {
                da = new SqlDataAdapter(String.Format("SELECT codLeitor ,leitor,sexo,dataNascimento,cpf,rg,email,telefone,telefoneCelular,enderecoNome,enderecoBairro,enderecoCidade,enderecoCep,enderecoUF,enderecoNumero FROM MvtBIBLeitor where leitor LIKE '%{0}%'", nome), conexao.conectar());
                dataTable = new DataTable();
                da.Fill(dataTable);
                Dgv.DataSource = dataTable;

            }
            catch (Exception _e)
            {
                MessageBox.Show("Sem conexão, busca mal sucedida!" + _e);
            }

        }
    }
}  

