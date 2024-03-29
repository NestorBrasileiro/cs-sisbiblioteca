﻿using System;
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
    public partial class FormBuscarSecao : Form
    {
        

        public FormBuscarSecao()
        {
            InitializeComponent();
        }
        public string InfoSecao { get; set; }
        public string Cod { get; set; }
        
        private void FormBuscarSecao_Load(object sender, EventArgs e)
        {
            //// TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet.MvtBIBSecao'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBSecaoTableAdapter.Fill(this.treinamentoDataSet.MvtBIBSecao);
            //// TODO: esta linha de código carrega dados na tabela 'treinamentoDataSet7.MvtBIBSecao'. Você pode movê-la ou removê-la conforme necessário.
            //this.mvtBIBSecaoTableAdapter.Fill(this.treinamentoDataSet7.MvtBIBSecao);
            Secao secao = new Secao();
            secao.Dgv = gridSecoes;
            secao.AtualizarDataGrid();
        }

        private void txtNomeEditora_TextChanged(object sender, EventArgs e)
        {
            Secao secao = new Secao();
            secao.Dgv = gridSecoes;
            secao.BuscaDataGrid(txtInfoSecao.Text);
        }

        private void gridSecoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Cod = gridSecoes.CurrentRow.Cells[0].Value.ToString();
            txtInfoSecao.Text = gridSecoes.CurrentRow.Cells[1].Value.ToString();
            InfoSecao = txtInfoSecao.Text;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridSecoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod = gridSecoes.CurrentRow.Cells[0].Value.ToString();
            txtInfoSecao.Text = gridSecoes.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
