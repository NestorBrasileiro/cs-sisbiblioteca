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
    public partial class FormLocal : Form
    {

        public FormLocal()
        {
            InitializeComponent();

        }

        public void LimparCampos()
        {
            txtCod.Text = string.Empty;
            txtLocalDescricao.Text = string.Empty;
        }

        private void btnCadLocal_Click(object sender, EventArgs e)
        {
            Local local = new Local();
            local.Cod = txtCod.Text;
            local.Descricao = txtLocalDescricao.Text;
            local.Dgv = gridLocais;


            if (txtLocalDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Insira as informações do local!");
            }
            else
            {
                if (txtCod.Text.Trim() == "")
                {
                    local.CadastrarLocal();
                    MessageBox.Show(local.mensagem);

                }
                else
                {
                    local.EditarLocal();
                    MessageBox.Show(local.mensagem);

                }
                local.AtualizarDataGrid();
                LimparCampos();
            }


        }


        private void FormLocal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBLocal'. Você pode movê-la ou removê-la conforme necessário.
            this.mvtBIBLocalTableAdapter.Fill(this.treinamentoDataSet.MvtBIBLocal);
            btnExcluirLocal.Enabled = false;
            Local local = new Local();
            local.Dgv = gridLocais;
            local.AtualizarDataGrid();
        }

        private void txtLocalDescricao_TextChanged(object sender, EventArgs e)
        {
            if(txtLocalDescricao.Text.Trim() == "") { btnExcluirLocal.Enabled = false;}
            
            Local local = new Local();
            local.Descricao = txtLocalDescricao.Text;
            local.Dgv = gridLocais;
            local.BuscaDataGrid(txtLocalDescricao.Text);

        }

        private void gridLocais_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCod.Text = gridLocais.CurrentRow.Cells[0].Value.ToString();
            txtLocalDescricao.Text = gridLocais.CurrentRow.Cells[1].Value.ToString();
            btnExcluirLocal.Enabled = true;

        }

        private void btnExcluirLocal_Click(object sender, EventArgs e)
        {
            Local local = new Local();
            local.Cod = txtCod.Text;
            local.Dgv = gridLocais;
            local.ExcluirLocal();
            MessageBox.Show(local.mensagem);
            local.AtualizarDataGrid();
            LimparCampos();
        }
    }
}
