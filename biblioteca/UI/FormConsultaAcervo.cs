using biblioteca.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca.UI
{
    public partial class FormConsultaAcervo : Form
    {
        public FormConsultaAcervo()
        {
            InitializeComponent();
        }


        private void FormConsultaAcervo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treinamentoDataSetTabelas.Item' table. You can move, or remove it, as needed.
           // this.item.Fill(this.treinamentoDataSetTabelas.Item);
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBItemAcervo'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBItemAcervoTableAdapter.Fill(this.treinamentoDataSet.MvtBIBItemAcervo);
            ItemAcervo buscar = new ItemAcervo();
            buscar.Dgv = gridItens;
            buscar.AtualizarDataGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dataTable;
            try
            {
                cmd.CommandText = "SELECT Item.codItem, Item.nome, Item.numExemplar, Item.tipoItem, Item.situacao, Autor.codAutor, Autor.nome, Editora.codEditora, Editora.nome, Localizacao.codLocal, Localizacao.descricaoLocal, Secao.codSecao, Secao.descricaoSecao, Item.colecao, Item.volume, Item.idioma, Item.anoEdicao FROM MvtBIBItemAcervo AS Item " +
                    "INNER JOIN MvtBIBLocal AS Localizacao ON Localizacao.codLocal = Item.codLocal " +
                    "INNER JOIN MvtBIBAutor AS Autor ON Autor.codAutor = Item.codAutor " +
                    "INNER JOIN MvtBIBEditora AS Editora ON Editora.codEditora = Item.codEditora " +
                    "INNER JOIN MvtBIBSecao AS Secao ON Secao.codSecao = Item.codSecao " +
                    "INNER JOIN (SELECT codItem FROM MvtBIBItemAcervo) As ItemInfo On ItemInfo.codItem = Item.codItem WHERE 1=1 ";
                    
                    
                if(txtNomeItem.Text.Trim() != "")
                {
                    cmd.CommandText += "AND (Item.nome LIKE '%" + txtNomeItem.Text + "%')";
                }
                 if(txtNomeAutor.Text.Trim() != "")
                {
                    cmd.CommandText += "AND Autor.nome LIKE '%" + txtNomeAutor.Text + "%'";
                }
                 if (txtLocal.Text.Trim() != "")
                {
                    cmd.CommandText += "AND Localizacao.descricaoLocal LIKE '%" + txtLocal.Text + "%' ";
                }
                 if (txtColecao.Text.Trim() != "")
                {
                    cmd.CommandText += "AND (Item.colecao LIKE '%" + txtColecao.Text + "%')";
                }
                 if (cbxTipoItem.Text != "Tudo" || cbxTipoItem.Text != "")
                {
                    cmd.CommandText += "AND (Item.tipoItem LIKE '%" + cbxTipoItem.Text + "%')";
                }
                 if (cbxSituacao.Text != "")
                {
                    cmd.CommandText += "AND (Item.situacao LIKE '%" + cbxSituacao.Text + "%')";
                }
                






                da = new SqlDataAdapter(cmd.CommandText, conexao.conectar());

                dataTable = new DataTable();
                da.Fill(dataTable);
                gridItens.DataSource = dataTable;

            }
            catch (Exception _e)
            {
                MessageBox.Show("erro " + _e);
            }

        }    
    }
}
