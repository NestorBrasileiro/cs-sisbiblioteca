using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biblioteca.UI
{
    public partial class FormBuscarItemAcervo : Form
    {
        public FormBuscarItemAcervo()
        {
            InitializeComponent();
        }

        public string CodItem { get; set; }
        public string Nome { get; set; }
        public string CodAutor { get; set; }
        public string NomeAutor { get; set; }
        public string TipoItem { get; set; }
        public string Local { get; set; }
        public string Situacao { get; set; }
        public string Exemplar { get; set; }
        


        private void FormBuscarItemAcervo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSetTabelas.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.item.Fill(this.treinamentoDataSetTabelas.Item);
            ItemAcervo item = new ItemAcervo();
            item.Dgv = gridItens;
            item.AtualizarDataGrid();
        }
       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void gridItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CodItem = gridItens.CurrentRow.Cells[0].Value.ToString();
            Nome = gridItens.CurrentRow.Cells[1].Value.ToString();
            Exemplar = gridItens.CurrentRow.Cells[2].Value.ToString();
            TipoItem = gridItens.CurrentRow.Cells[3].Value.ToString();
            Situacao = gridItens.CurrentRow.Cells[4].Value.ToString();
            CodAutor = gridItens.CurrentRow.Cells[5].Value.ToString();
            NomeAutor = gridItens.CurrentRow.Cells[6].Value.ToString();
            Local = gridItens.CurrentRow.Cells[10].Value.ToString();
            

            maskCodItem.Text = CodItem;
            txtNomeItem.Text = Nome;
            maskExemplar.Text = Exemplar;
            maskVolume.Text = gridItens.CurrentRow.Cells[14].Value.ToString();
            cbxTipoItem.SelectedItem = gridItens.CurrentRow.Cells[3].Value.ToString();
            cbxSituacao.SelectedItem = gridItens.CurrentRow.Cells[4].Value.ToString();

            

        }

        private void gridItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodItem = gridItens.CurrentRow.Cells[0].Value.ToString();
            Nome = gridItens.CurrentRow.Cells[1].Value.ToString();
            Exemplar = gridItens.CurrentRow.Cells[2].Value.ToString();
            TipoItem = gridItens.CurrentRow.Cells[3].Value.ToString();
            Situacao = gridItens.CurrentRow.Cells[4].Value.ToString();
            CodAutor = gridItens.CurrentRow.Cells[5].Value.ToString();
            NomeAutor = gridItens.CurrentRow.Cells[6].Value.ToString();
            Local = gridItens.CurrentRow.Cells[10].Value.ToString();
            Close();
        }
    }
}
