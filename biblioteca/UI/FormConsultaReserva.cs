using biblioteca.Business;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biblioteca.UI
{
    public partial class FormConsultaReserva : Form
    {
        public FormConsultaReserva()
        {
            InitializeComponent();
        }
        
        private string tipo;
        
        private void ConsultaEmprestimo_Load(object sender, EventArgs e)
        {
            
            dateInicioDesde.CustomFormat = "dd/MM/yyyy";


            MovReserva buscar = new MovReserva();
            buscar.Dgv = gridEmprestimos;
            buscar.AtualizarDataGrid();
            cbxTipoItem.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dataTable;
            

            SqlCommand cmd = new SqlCommand();

            try
            {
                
                if (cbxTipoItem.SelectedIndex == 0) { this.tipo = string.Empty; }
                else { this.tipo = cbxTipoItem.Text; }
                

                cmd.CommandText = "SELECT Reserva.codItem, Item.nome [Item], Autor.codAutor, Autor.nome [Autor], Item.numExemplar, Item.situacao, Item.tipoItem, Leitor.codLeitor, Leitor.leitor[Leitor], Reserva.dataReserva, Reserva.prazoReserva, Localizacao.codLocal, Localizacao.descricaoLocal FROM MvtBIBReserva AS Reserva " +
                    "INNER JOIN MvtBIBItemAcervo AS Item ON Reserva.codItem = Item.codItem "+
                    "INNER JOIN MvtBIBLocal AS Localizacao ON Localizacao.codLocal = Item.codLocal "+
                    "INNER JOIN MvtBIBAutor AS Autor ON Autor.codAutor = Item.codAutor "+
                    "INNER JOIN MvtBIBLeitor AS Leitor ON Leitor.codLeitor = Reserva.codLeitor "+
                    "INNER JOIN (Select codItem FROM MvtBIBReserva) AS ReservaInfo ON ReservaInfo.codItem = Reserva.codItem ";

                if (txtItem.Text.Trim() != "")
                {
                    cmd.CommandText += "AND(Item.nome LIKE '%" + txtItem.Text + "%')";
                }
                 if ( cbxTipoItem.Text.Trim() != "" || cbxTipoItem.Text != "Tudo")
                {
                    cmd.CommandText += "AND (Item.tipoItem LIKE '%"+tipo+"%')";
                }
                 if (txtLocal.Text.Trim() != "")
                {
                    cmd.CommandText += "AND (Localizacao.descricaoLocal LIKE '%" + txtLocal.Text + "%')";
                }
                 if (txtAutor.Text != "")
                {
                    cmd.CommandText += "AND (Autor.nome LIKE '%" + txtAutor.Text + "%')";
                }
                 if (txtLeitor.Text.Trim() != "")
                {
                    cmd.CommandText += "AND (Leitor.leitor LIKE '%" + txtLeitor.Text + "%')";
                }
                 if (dateInicioDesde.Value != DateTime.Now.Date || dateInicioAte.Value != DateTime.Now.Date || dateFinalDesde.Value != DateTime.Now.Date || dateFinalAte.Value != DateTime.Now.Date )
                {
                    cmd.CommandText += "AND(Reserva.dataReserva BETWEEN '"+dateInicioDesde.Text+ "' AND '" + dateInicioAte.Text + "')" +
                    " AND (Reserva.prazoReserva BETWEEN '" + dateFinalDesde.Text + "' AND '" + dateFinalAte.Text + "')";
                }
                da = new SqlDataAdapter(cmd.CommandText, conexao.conectar());


                dataTable = new DataTable();
                da.Fill(dataTable);
                gridEmprestimos.DataSource = dataTable;
            }
            catch (Exception _e)
            {
                MessageBox.Show("erro " + _e);

            }
            finally
            {
                conexao.desconectar();
            }
        }




    }
}
