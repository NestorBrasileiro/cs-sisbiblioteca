using biblioteca.UI;
using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class FormItemAcervo : Form
    {
        public FormItemAcervo()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtCodAutor.Text = string.Empty;
            txtCodEditora.Text = string.Empty;
            txtCodItem.Text = string.Empty;
            txtCodLocal.Text = string.Empty;
            txtCodSecao.Text = string.Empty;
            txtIdioma.Text = string.Empty;
            txtNomeLocal.Text = string.Empty;
            txtNomeAutor.Text = string.Empty;
            txtNomeColecao.Text = string.Empty;
            txtNomeEditora.Text = string.Empty;
            txtNomeItem.Text = string.Empty;
            maskExemplar.Text = string.Empty;
            txtNomeSecao.Text = string.Empty;
            maskVolume.Text = string.Empty;
            cbxTipoItem.SelectedIndex = -1;
            cbxSituacao.SelectedIndex = 0;
        }
        private void FormItemAcervo_Load(object sender, EventArgs e)
        {


            ItemAcervo item = new ItemAcervo();
            item.Dgv = gridItensCadastrados;
            item.AtualizarDataGrid();
            btnExcluirItem.Enabled = false;
            cbxSituacao.SelectedIndex = 0;
            
        }

        private void btnBuscarLocal_Click(object sender, EventArgs e)
        {
            FormBuscarLocal form = new FormBuscarLocal();
            form.ShowDialog();
            txtNomeLocal.Text = form.Local;
            txtCodLocal.Text = form.Cod;
        }
  


        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            FormBuscarAutor form = new FormBuscarAutor();
            form.ShowDialog();
            txtNomeAutor.Text = form.Autor;
            txtCodAutor.Text = form.Cod;
        }

        private void btnBuscarEditora_Click(object sender, EventArgs e)
        {
            FormBuscarEditora form = new FormBuscarEditora();
            form.ShowDialog();
            txtNomeEditora.Text = form.Editora;
            txtCodEditora.Text = form.Cod;
        }

        private void btnBuscarSecao_Click(object sender, EventArgs e)
        {
            FormBuscarSecao secao = new FormBuscarSecao();
            secao.ShowDialog();
            txtNomeSecao.Text = secao.InfoSecao;
            txtCodSecao.Text = secao.Cod;
        }

        
        

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            
            ItemAcervo item = new ItemAcervo();
            item.Dgv = gridItensCadastrados;

            if (cbxTipoItem.Text.Trim() == "" || txtNomeItem.Text.Trim() == "" || txtNomeLocal.Text.Trim() =="" || txtNomeAutor.Text.Trim() =="" || txtNomeEditora.Text.Trim() == "" || txtCodSecao.Text.Trim() == "" ) {
                MessageBox.Show("Há campos obrigatórios em branco!");
            }
            else
            {
                item.CodItem = txtCodItem.Text;
                
                item.NomeItem = txtNomeItem.Text;
                item.CodLocal = txtCodLocal.Text;
                item.CodAutor = txtCodAutor.Text;
                item.CodEditora = txtCodEditora.Text;
                item.CodSecao = txtCodSecao.Text;

                item.Volume = maskVolume.Text;
                item.AnoEdicao = maskAnoEdicao.Text;
                item.NumExemplar = maskExemplar.Text;
                item.TipoItem = cbxTipoItem.Text;
                item.Idioma = txtIdioma.Text;
                item.Colecao = txtNomeColecao.Text;

                if (txtCodItem.Text.Trim() == "")
                {
                    item.Situacao = cbxSituacao.Text ;
                    item.CadastrarItem();
                    MessageBox.Show(item.mensagem);
                    item.AtualizarDataGrid();
                    LimparCampos();
                }
                else
                {
                    item.Situacao = cbxSituacao.Text;
                    item.EditarItem();
                    MessageBox.Show(item.mensagem);
                    item.AtualizarDataGrid();
                    LimparCampos();

                }
            }
        }
     
        private void gridItensCadastrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluirItem.Enabled = true;

            txtCodItem.Text = gridItensCadastrados.CurrentRow.Cells[0].Value.ToString();
            txtNomeItem.Text = gridItensCadastrados.CurrentRow.Cells[1].Value.ToString();
            maskExemplar.Text = gridItensCadastrados.CurrentRow.Cells[2].Value.ToString();
            cbxTipoItem.SelectedItem = gridItensCadastrados.CurrentRow.Cells[3].Value.ToString();
            cbxSituacao.SelectedItem = gridItensCadastrados.CurrentRow.Cells[4].Value.ToString();
            txtCodAutor.Text = gridItensCadastrados.CurrentRow.Cells[5].Value.ToString();
            txtNomeAutor.Text = gridItensCadastrados.CurrentRow.Cells[6].Value.ToString();
            txtCodEditora.Text = gridItensCadastrados.CurrentRow.Cells[7].Value.ToString();
            txtNomeEditora.Text = gridItensCadastrados.CurrentRow.Cells[8].Value.ToString();
            txtCodLocal.Text = gridItensCadastrados.CurrentRow.Cells[9].Value.ToString();
            txtNomeLocal.Text = gridItensCadastrados.CurrentRow.Cells[10].Value.ToString();
            txtCodSecao.Text = gridItensCadastrados.CurrentRow.Cells[11].Value.ToString();
            txtNomeSecao.Text = gridItensCadastrados.CurrentRow.Cells[12].Value.ToString();
            txtNomeColecao.Text = gridItensCadastrados.CurrentRow.Cells[13].Value.ToString();
            maskVolume.Text = gridItensCadastrados.CurrentRow.Cells[14].Value.ToString();
            txtIdioma.Text = gridItensCadastrados.CurrentRow.Cells[15].Value.ToString();
            maskAnoEdicao.Text = gridItensCadastrados.CurrentRow.Cells[16].Value.ToString();
            
            
        }
        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            ItemAcervo item = new ItemAcervo();
            item.Dgv = gridItensCadastrados;
            item.CodItem = txtCodItem.Text;
            item.ExcluirItem();
            LimparCampos();
            MessageBox.Show(item.mensagem);
            item.AtualizarDataGrid();

        }
    }
}
