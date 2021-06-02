using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class FormSecao : Form
    {
        public FormSecao()
        {
            InitializeComponent();

        }
        Secao secao = new Secao();
        private void LimparCampos()
        {
            txtCodSecao.Text = string.Empty;
            txtDescricaoSecao.Text = string.Empty;
        }
            
        

        private void FormSecao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBSecao'. Você pode movê-la ou removê-la conforme necessário.
            this.mvtBIBSecaoTableAdapter.Fill(this.treinamentoDataSet.MvtBIBSecao);

            Secao secao = new Secao();
            btnExcluirSecao.Enabled = false;
            secao.Dgv = gridSecoesCadastradas;
            secao.AtualizarDataGrid();

        }
        

        private void gridSecoesCadastradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodSecao.Text = gridSecoesCadastradas.CurrentRow.Cells[0].Value.ToString();
            txtDescricaoSecao.Text = gridSecoesCadastradas.CurrentRow.Cells[1].Value.ToString();
            btnExcluirSecao.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Secao secao = new Secao();
            secao.InfoSecao = txtDescricaoSecao.Text;
            secao.CodSecao = txtCodSecao.Text;
            secao.Dgv = gridSecoesCadastradas;
            if (txtDescricaoSecao.Text.Trim() == "")
                {
                MessageBox.Show("Campo vazio!");
                }
                else
                {
                    if (txtCodSecao.Text.Trim() == "")
                    {
                        secao.CadastrarSecao();
                        MessageBox.Show(secao.mensagem);
                    }
                    else
                    {
                    
                    secao.EditarSecao();
                        MessageBox.Show(secao.mensagem);
                    }


                }
            LimparCampos();
            secao.AtualizarDataGrid();



        }

        private void btnExcluirSecao_Click(object sender, EventArgs e)
        {

            Secao secao = new Secao();
            secao.Dgv = gridSecoesCadastradas;
           
            
            secao.ExcluirSecao(txtCodSecao.Text);
            secao.AtualizarDataGrid();
            MessageBox.Show(secao.mensagem);

            LimparCampos();
        }

        private void txtDescricaoSecao_TextChanged(object sender, EventArgs e)
        {
            Secao secao = new Secao();
            secao.Dgv = gridSecoesCadastradas;
            secao.BuscaDataGrid(txtDescricaoSecao.Text);

        }

        private void txtCodSecao_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
