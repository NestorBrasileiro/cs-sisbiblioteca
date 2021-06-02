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
    public partial class FormBuscarAutor : Form
    {
        Autor autor = new Autor();
        public FormBuscarAutor()
        {
            InitializeComponent();
        }
        public string Autor { get; set; }
        public string Cod { get; set; }
        
        
        private void FormBuscarAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBAutor'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBAutorTableAdapter.Fill(this.treinamentoDataSet.MvtBIBAutor);

            autor.Dgv = gridAutores;
            autor.AtualizarDataGrid();
            
        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {
            autor.Dgv = gridAutores;
            autor.BuscaDataGrid(txtNomeAutor.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridAutores.CurrentRow.Cells[0].Value.ToString();
            Autor = gridAutores.CurrentRow.Cells[1].Value.ToString();
            txtNomeAutor.Text = Autor;
        }

        private void gridAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridAutores.CurrentRow.Cells[0].Value.ToString();
            Autor = gridAutores.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }

}
