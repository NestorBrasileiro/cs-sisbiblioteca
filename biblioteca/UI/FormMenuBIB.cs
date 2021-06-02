using biblioteca.UI;
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
    public partial class formMenuBIB : Form
    {
        public formMenuBIB()
        {
            InitializeComponent();
        }

        private void btnMenuAutor_Click(object sender, EventArgs e)
        {
            FormMenu formAutor = new FormMenu();
                formAutor.Show();
        }

        private void btnMenuLeitor_Click(object sender, EventArgs e)
        {
            FormLeitor formLeitor = new FormLeitor();
            formLeitor.Show();
            
        }

        private void btnMenuEditora_Click(object sender, EventArgs e)
        {
            FormEditora formEditora = new FormEditora();
            formEditora.Show();
        }

        private void btnMenuLocal_Click(object sender, EventArgs e)
        {
            FormLocal formLocal = new FormLocal();
            formLocal.Show();
        }

        private void btnMenuSecao_Click(object sender, EventArgs e)
        {
            FormSecao formSecao = new FormSecao();
            formSecao.Show();
        }

        private void btnMenuAcervo_Click(object sender, EventArgs e)
        {
            FormItemAcervo formItemAcervo = new FormItemAcervo();
            formItemAcervo.Show();
        }

        private void btnMenuReserva_Click(object sender, EventArgs e)
        {
            FormReserva formReserva = new FormReserva();
            formReserva.Show();
        }

        private void btnMenuConsReserva_Click(object sender, EventArgs e)
        {
            FormConsultaReserva form = new FormConsultaReserva();
            form.Show();
        }

        private void btnMenuConsAcervo_Click(object sender, EventArgs e)
        {
            FormConsultaAcervo form = new FormConsultaAcervo();
            form.Show();
        }

        private void formMenuBIB_Load(object sender, EventArgs e)
        {

        }
    }
}
