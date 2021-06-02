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
    public partial class FormMenu : Form
    {
        public void LimparCampos()
        {
            txtInfoAutor.Text = string.Empty;
            txtCod.Text = string.Empty;
            txtNomeAutor.Text = string.Empty;
        }

        public FormMenu()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBAutor'. Você pode movê-la ou removê-la conforme necessário.
            this.mvtBIBAutorTableAdapter.Fill(this.treinamentoDataSet.MvtBIBAutor);

            btnExcluirAutor.Enabled = false;
            Autor autor = new Autor();
            autor.Dgv = gridAutoresCadastrados;
            autor.AtualizarDataGrid();
        }

        private void salvar_Click_1(object sender, EventArgs e)
        {
            //gridAutoresCadastrados.Columns.Add();

            //gridAutoresCadastrados.Rows.Add();

            //gridAutoresCadastrados["codAutor", 0].Value = "codigo"

            Autor autor = new Autor();
            autor.Dgv = gridAutoresCadastrados;
            autor.CodAutor = txtCod.Text;
            autor.NomeAutor = txtNomeAutor.Text;
            autor.InfoAutor = txtInfoAutor.Text;

            if (txtNomeAutor.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome válido");
            }
            else
            {

                if (txtCod.Text == "")
                {
                    autor.CadastroAutor();
                    MessageBox.Show(autor.mensagem);
                }
                else
                {
                    autor.EditarAutor();
                    MessageBox.Show(autor.mensagem);


                }
                autor.AtualizarDataGrid();

            }
            LimparCampos();
        }



        private void excluir_Click_1(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            if (txtNomeAutor.Text.Trim() == "" || txtNomeAutor.Text.Trim() == "")
            {
                MessageBox.Show("insira um usuário válido");
            }
            else
            {

                autor.ExcluirAutor(txtCod.Text);
                MessageBox.Show(autor.mensagem);
                autor.Dgv = gridAutoresCadastrados;
                autor.AtualizarDataGrid();
            }
            LimparCampos();
        }

        private void gridAutoresCadastrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = gridAutoresCadastrados.CurrentRow.Cells[0].Value.ToString();
            txtNomeAutor.Text = gridAutoresCadastrados.CurrentRow.Cells[1].Value.ToString();
            txtInfoAutor.Text = gridAutoresCadastrados.CurrentRow.Cells[2].Value.ToString();
            btnExcluirAutor.Enabled = true;
        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.Dgv = gridAutoresCadastrados;
            autor.BuscaDataGrid(txtNomeAutor.Text);
            if (txtNomeAutor.Text == "") { btnExcluirAutor.Enabled = false; }
        }

     
    }
}
