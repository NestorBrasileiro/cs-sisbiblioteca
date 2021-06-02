using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class FormEditora : Form
    {

        public FormEditora()
        {
            InitializeComponent();

        }
        public void LimparCampos()
        {
            txtCod.Text = string.Empty;
            txtNomeEditora.Text = string.Empty;
        }

        private void formEditora_Load(object sender, EventArgs e)
        {
            
            try
            {

                // TODO: This line of code loads data into the 'treinamentoDataSet2.MvtBIBEditora' table. You can move, or remove it, as needed.
                this.mvtBIBEditoraTableAdapter.Fill(this.treinamentoDataSet.MvtBIBEditora);
            }
            catch (Exception _e)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados." + _e);
            }
            btnExcluirEditora.Enabled = false;


        }
        private void btnCadEditora_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            editora.CodEditora = txtCod.Text;
            editora.NomeEditora = txtNomeEditora.Text;
            editora.Dgv = gridEditorasCadastradas;
            if (txtNomeEditora.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome");
            }
            else
            {
                if (txtCod.Text == "")
                {
                    editora.CadastroEditora();
                    MessageBox.Show(editora.mensagem);
                }
                else
                {
                    editora.EditarEditora();
                    MessageBox.Show(editora.mensagem);
                }
                editora.AtualizarDataGrid();
                LimparCampos();

            }

        }

        private void btnExcluirEditora_Click(object sender, EventArgs e)
        {

            Editora editora = new Editora();
            editora.CodEditora = txtCod.Text;
            editora.ExcluirEditora();
            editora.Dgv = gridEditorasCadastradas;
            editora.AtualizarDataGrid();
            MessageBox.Show(editora.mensagem);

            LimparCampos();
        }

        private void gridEditorasCadastradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = gridEditorasCadastradas.CurrentRow.Cells[0].Value.ToString();
            txtNomeEditora.Text = gridEditorasCadastradas.CurrentRow.Cells[1].Value.ToString();
            btnExcluirEditora.Enabled = true;

        }
        private void txtNomeEditora_TextChanged(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            editora.Dgv = gridEditorasCadastradas;
            editora.AtualizarDataGrid();
            if (txtNomeEditora.Text == "") { LimparCampos(); btnExcluirEditora.Enabled = false; }
        }

 
    }
}




