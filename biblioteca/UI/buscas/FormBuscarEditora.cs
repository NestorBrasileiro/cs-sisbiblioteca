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
    public partial class FormBuscarEditora : Form
    {
        
        public FormBuscarEditora()
        {
            InitializeComponent();
        }
        public string Editora { get; set; }
        public string Cod { get; set; }
        private void FormBuscarEditora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBEditora'. Você pode movê-la ou removê-la conforme necessário.
            this.mvtBIBEditoraTableAdapter.Fill(this.treinamentoDataSet.MvtBIBEditora);
            Editora editora = new Editora();
            editora.Dgv = gridEditoras;
            editora.AtualizarDataGrid();

        }
        private void gridEditoras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridEditoras.CurrentRow.Cells[0].Value.ToString();
            Editora = gridEditoras.CurrentRow.Cells[1].Value.ToString();
            txtNomeEditora.Text = Editora;
        }
        private void txtNomeEditora_TextChanged(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            editora.Dgv = gridEditoras;
            editora.BuscaDataGrid(txtNomeEditora.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridEditoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridEditoras.CurrentRow.Cells[0].Value.ToString();
            Editora = gridEditoras.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
