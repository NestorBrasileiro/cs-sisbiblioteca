using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class FormLeitor : Form
    {

        public FormLeitor()
        {
            InitializeComponent();
            btnExcluirLeitor.Enabled = false;
        }
        public void LimparCampos()
        {
            txtCodLeitor.Text = string.Empty;
            txtNomeLeitor.Text = string.Empty;
            dateDataNasc.Text = string.Empty;
            cbxSexoLeitor.SelectedIndex = 0;
            txtCpfLeitor.Text = string.Empty;
            txtRgLeitor.Text = string.Empty;
            txtEmailLeitor.Text = string.Empty;
            txtTelLeitor.Text = string.Empty;
            txtTelCelLeitor.Text = string.Empty;
            txtEndRuaLeitor.Text = string.Empty;
            txtEndBairroLeitor.Text = string.Empty;
            txtEndCidadeLeitor.Text = string.Empty;
            txtEndCepLeitor.Text = string.Empty;
            cbxEndUfLeitor.SelectedIndex = 0;
            txtEndNumLeitor.Text = string.Empty;
            cbxEndUfLeitor.SelectedIndex = -1;
            cbxSexoLeitor.SelectedIndex = -1;
        }
        private void formLeitor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBLeitor'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBLeitorTableAdapter.Fill(this.treinamentoDataSet.MvtBIBLeitor);
            // TODO: esta linha de código carrega dados na tabela 'dataSet3.MvtBIBLeitor'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBLeitorTableAdapter.Fill(this.dataSet3.MvtBIBLeitor);
            Leitor leitor = new Leitor();
            leitor.Dgv = gridLeitoresCadastrados;
            leitor.AtualizarDataGrid();
        }

        private void bntCadLeitor_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.Cod = txtCodLeitor.Text;
            leitor.Nome = txtNomeLeitor.Text;
            leitor.Sexo = cbxSexoLeitor.Text;
            leitor.DataNasc = dateDataNasc.Value;
            leitor.Cpf = txtCpfLeitor.Text;
            leitor.Rg = txtRgLeitor.Text;
            leitor.Email = txtEmailLeitor.Text;
            leitor.Tel = txtTelLeitor.Text;
            leitor.TelCel = txtTelCelLeitor.Text;
            leitor.EndRua = txtEndRuaLeitor.Text;
            leitor.EndBairro = txtEndBairroLeitor.Text;
            leitor.EndCidade = txtEndCidadeLeitor.Text;
            leitor.EndCep = txtEndCepLeitor.Text;
            leitor.EndUf = cbxEndUfLeitor.Text;
            leitor.EndNum = txtEndNumLeitor.Text;
            leitor.Dgv = gridLeitoresCadastrados;

            if (txtNomeLeitor.Text == "" || cbxSexoLeitor.Text == "" || txtEndRuaLeitor.Text == ""
                || txtEndBairroLeitor.Text == "" || txtEndCidadeLeitor.Text == "" || cbxEndUfLeitor.Text == "")
            {
                MessageBox.Show("Há campos obrigatórios vazios no formulário!");

            }else if(leitor.ValidaCPF(txtCpfLeitor.Text) == false) { MessageBox.Show("CPF inválido"); txtCpfLeitor.Text = string.Empty; }
            else
            {

                if (txtCodLeitor.Text.Trim() == "")
                {
                    leitor.CadastroLeitor();
                    MessageBox.Show(leitor.mensagem);
                    LimparCampos();
                }
                else
                {

                    leitor.EditarLeitor();
                    MessageBox.Show(leitor.mensagem);
                    LimparCampos();
                }
                
            }
            leitor.AtualizarDataGrid();
        }

        private void btnExcluirLeitor_Click_1(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.Cod = txtCodLeitor.Text;
            leitor.Dgv = gridLeitoresCadastrados;
            leitor.ExcluirLeitor();
            leitor.AtualizarDataGrid();
            MessageBox.Show(leitor.mensagem);
        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor();
            leitor.Dgv = gridLeitoresCadastrados;
            leitor.BuscaDataGrid(txtNomeLeitor.Text);


            
        }

        private void gridLeitoresCadastrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[0].Value.ToString();
            txtNomeLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[1].Value.ToString();
            cbxSexoLeitor.SelectedIndex = (gridLeitoresCadastrados.CurrentRow.Cells[2].Value.ToString() == "M") ? 0 : 1;
            dateDataNasc.Text = gridLeitoresCadastrados.CurrentRow.Cells[3].Value.ToString();
            txtCpfLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[4].Value.ToString();
            txtRgLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[5].Value.ToString();
            txtEmailLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[6].Value.ToString();
            txtTelLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[7].Value.ToString();
            txtTelCelLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[8].Value.ToString();
            txtEndRuaLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[9].Value.ToString();
            txtEndBairroLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[10].Value.ToString();
            txtEndCidadeLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[11].Value.ToString();
            txtEndCepLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[12].Value.ToString();
            cbxEndUfLeitor.SelectedItem = gridLeitoresCadastrados.CurrentRow.Cells[13].Value.ToString();
            txtEndNumLeitor.Text = gridLeitoresCadastrados.CurrentRow.Cells[14].Value.ToString();
            btnExcluirLeitor.Enabled = true;

        }

        private void gridLeitoresCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateDataNasc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
