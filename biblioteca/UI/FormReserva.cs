using biblioteca.Business;
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
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }
        
        private void FormReseva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'treinamentoDataSetTabelas.Reserva'. Você pode movê-la ou removê-la conforme necessário.
            //this.reservaTableAdapter.Fill(this.treinamentoDataSetTabelas.Reserva);
            
            MovReserva reserva = new MovReserva();
            reserva.Dgv = gridReserva;
            reserva.AtualizarDataGrid();
            LimparCampos();
            DataGrid();
        }
        private void LimparCampos()
        {
            txtCodItem.Text = string.Empty;
            txtNomeItem.Text = string.Empty;
            txtCodAutor.Text = string.Empty;
            txtNomeAutor.Text = string.Empty;

            txtExemplar.Text = string.Empty;

            txtLocalItem.Text = string.Empty;
            txtCodLeitor.Text = string.Empty;
            txtNomeLeitor.Text = string.Empty;
            dateInicioReserva.Value = DateTime.Today;
            datePrazoReserva.Value = DateTime.Today;

            cbxTipoItem.SelectedIndex = -1;
            cbxMovimento.SelectedIndex = -1;
            cbxSituacao.SelectedIndex = -1;
        }
        private void DataGrid()
        {
            
        }
        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            FormBuscarLeitor form = new FormBuscarLeitor();
            form.ShowDialog();
            txtCodLeitor.Text = form.CodLeitor;
            txtNomeLeitor.Text = form.NomeLeitor;
        }
        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            FormBuscarItemAcervo form = new FormBuscarItemAcervo();
            form.ShowDialog();

            txtCodItem.Text = form.CodItem;
            txtNomeItem.Text = form.Nome;
            txtCodAutor.Text = form.CodAutor;
            txtNomeAutor.Text = form.NomeAutor;
            cbxTipoItem.SelectedItem = form.TipoItem;
            txtLocalItem.Text = form.Local;
            txtExemplar.Text = form.Exemplar;
            cbxSituacao.SelectedItem = form.Situacao;

        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int dataValida = DateTime.Compare(dateInicioReserva.Value, datePrazoReserva.Value);
            
            if (txtNomeItem.Text.Trim() == "" || txtNomeLeitor.Text.Trim() == "" || cbxMovimento.Text.Trim() == "")
            {
                MessageBox.Show("Há campos em branco no cadastro!");
            }
            
            else if (dataValida > 0 || dataValida == 0) { MessageBox.Show("A data de prazo não pode ser menor ou \n igual a do início da reserva"); }
            else
            {
                MovReserva reserva = new MovReserva();
                reserva.Dgv = gridReserva;
                reserva.CodItem = txtCodItem.Text;
                reserva.CodLeitor = txtCodLeitor.Text;
                reserva.DataReserva = dateInicioReserva.Value;
                reserva.PrazoReserva = datePrazoReserva.Value;


                //movimento reservar 0 e devolver 1
                //situação disponível 0 e emprestado 1
                if (cbxMovimento.SelectedIndex == 0)
                {
                    if (cbxSituacao.SelectedIndex == 0)
                    {
                        
                        reserva.Reservar();
                        MessageBox.Show(reserva.mensagem);
                        reserva.AtualizarDataGrid();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("O item já está reservado");
                    }
                    
                }else if(cbxMovimento.SelectedIndex == 1)
                {
                    if (cbxSituacao.SelectedIndex == 1)
                    {
                        reserva.Devolver();
                        MessageBox.Show(reserva.mensagem);
                        reserva.AtualizarDataGrid();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("O item já está disponível");
                    }   
                }
            } 
        }

        private void gridReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodItem.Text = gridReserva.CurrentRow.Cells[0].Value.ToString();
            txtNomeItem.Text = gridReserva.CurrentRow.Cells[1].Value.ToString();
            txtCodAutor.Text = gridReserva.CurrentRow.Cells[2].Value.ToString();
            txtNomeAutor.Text = gridReserva.CurrentRow.Cells[3].Value.ToString();
            txtExemplar.Text = gridReserva.CurrentRow.Cells[4].Value.ToString();
            cbxSituacao.SelectedItem = gridReserva.CurrentRow.Cells[5].Value.ToString();
            txtCodLeitor.Text = gridReserva.CurrentRow.Cells[6].Value.ToString();
            txtNomeLeitor.Text = gridReserva.CurrentRow.Cells[7].Value.ToString();
            dateInicioReserva.Text = gridReserva.CurrentRow.Cells[8].Value.ToString();
            datePrazoReserva.Text = gridReserva.CurrentRow.Cells[9].Value.ToString();
            txtLocalItem.Text = gridReserva.CurrentRow.Cells[11].Value.ToString();

            
        }
    }
}
