using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca.UI
{
    public partial class FormBuscarLeitor : Form
    {
        public FormBuscarLeitor()
        {
            InitializeComponent();
        }
        public string CodLeitor { get; set; }
        public string NomeLeitor { get; set; }

        private void FormBuscarLeitor_Load(object sender, EventArgs e)
        {
            
            Leitor form = new Leitor();
            form.Dgv = gridLeitores;
            form.AtualizarDataGrid();

        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            Leitor form = new Leitor();
            form.Dgv = gridLeitores;
            form.BuscaDataGrid(txtNomeLeitor.Text);

            
        }
        private void gridLeitores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodLeitor = gridLeitores.CurrentRow.Cells[0].Value.ToString();
            NomeLeitor = gridLeitores.CurrentRow.Cells[1].Value.ToString();
            txtNomeLeitor.Text = NomeLeitor;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridLeitores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodLeitor = gridLeitores.CurrentRow.Cells[0].Value.ToString();
            NomeLeitor = gridLeitores.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
