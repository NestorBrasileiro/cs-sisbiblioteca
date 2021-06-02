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
    public partial class FormBuscarLocal : Form
    {
        
        public FormBuscarLocal()
        {
            InitializeComponent();
        }
        public string Cod { get; set; }
        public string Local { get; set; }

        private void FormBuscarLocal_Load(object sender, EventArgs e)
        {
            
            Local form = new Local();
            form.Dgv = gridLocais;
            form.AtualizarDataGrid();
        }

        private void gridLocais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormItemAcervo form = new FormItemAcervo();

            Cod = gridLocais.CurrentRow.Cells[0].Value.ToString();
            Local = gridLocais.CurrentRow.Cells[1].Value.ToString();
            txtNomeLocal.Text = Local;
        }
        private void txtNomeEditora_TextChanged(object sender, EventArgs e)
        {
            Local form = new Local();
            form.Dgv = gridLocais;
            form.BuscaDataGrid(txtNomeLocal.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridLocais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridLocais.CurrentRow.Cells[0].Value.ToString();
            Local = gridLocais.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
