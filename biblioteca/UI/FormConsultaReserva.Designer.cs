
namespace biblioteca.UI
{
    partial class FormConsultaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.gridEmprestimos = new System.Windows.Forms.DataGridView();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetTabelas = new biblioteca.treinamentoDataSetTabelas();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.dateInicioAte = new System.Windows.Forms.DateTimePicker();
            this.dateInicioDesde = new System.Windows.Forms.DateTimePicker();
            this.dateFinalDesde = new System.Windows.Forms.DateTimePicker();
            this.dateFinalAte = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reservaTableAdapter = new biblioteca.treinamentoDataSetTabelasTableAdapters.reservaTableAdapter();
            this.codItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numExemplarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leitor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Início";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(58, 12);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(265, 24);
            this.txtItem.TabIndex = 0;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(58, 42);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(265, 24);
            this.txtLocal.TabIndex = 1;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(58, 72);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(265, 24);
            this.txtAutor.TabIndex = 2;
            // 
            // txtLeitor
            // 
            this.txtLeitor.Location = new System.Drawing.Point(58, 102);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(265, 24);
            this.txtLeitor.TabIndex = 3;
            // 
            // gridEmprestimos
            // 
            this.gridEmprestimos.AllowUserToAddRows = false;
            this.gridEmprestimos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEmprestimos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmprestimos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmprestimos.AutoGenerateColumns = false;
            this.gridEmprestimos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmprestimos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codItemDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.codAutorDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.numExemplarDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.tipoItemDataGridViewTextBoxColumn,
            this.codLeitorDataGridViewTextBoxColumn,
            this.leitorDataGridViewTextBoxColumn,
            this.dataReservaDataGridViewTextBoxColumn,
            this.prazoReservaDataGridViewTextBoxColumn,
            this.codLocalDataGridViewTextBoxColumn,
            this.descricaoLocalDataGridViewTextBoxColumn});
            this.gridEmprestimos.DataSource = this.reservaBindingSource;
            this.gridEmprestimos.GridColor = System.Drawing.SystemColors.Window;
            this.gridEmprestimos.Location = new System.Drawing.Point(12, 162);
            this.gridEmprestimos.Name = "gridEmprestimos";
            this.gridEmprestimos.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEmprestimos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmprestimos.Size = new System.Drawing.Size(847, 242);
            this.gridEmprestimos.TabIndex = 9;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "reserva";
            this.reservaBindingSource.DataSource = this.treinamentoDataSetTabelas;
            // 
            // treinamentoDataSetTabelas
            // 
            this.treinamentoDataSetTabelas.DataSetName = "treinamentoDataSetTabelas";
            this.treinamentoDataSetTabelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultar.Location = new System.Drawing.Point(58, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 24);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Todos",
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.cbxTipoItem.Location = new System.Drawing.Point(453, 12);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(100, 24);
            this.cbxTipoItem.TabIndex = 4;
            // 
            // dateInicioAte
            // 
            this.dateInicioAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicioAte.Location = new System.Drawing.Point(592, 42);
            this.dateInicioAte.Name = "dateInicioAte";
            this.dateInicioAte.Size = new System.Drawing.Size(100, 24);
            this.dateInicioAte.TabIndex = 6;
            // 
            // dateInicioDesde
            // 
            this.dateInicioDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicioDesde.Location = new System.Drawing.Point(453, 42);
            this.dateInicioDesde.Name = "dateInicioDesde";
            this.dateInicioDesde.Size = new System.Drawing.Size(100, 24);
            this.dateInicioDesde.TabIndex = 5;
            // 
            // dateFinalDesde
            // 
            this.dateFinalDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinalDesde.Location = new System.Drawing.Point(453, 72);
            this.dateFinalDesde.Name = "dateFinalDesde";
            this.dateFinalDesde.Size = new System.Drawing.Size(100, 24);
            this.dateFinalDesde.TabIndex = 10;
            // 
            // dateFinalAte
            // 
            this.dateFinalAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinalAte.Location = new System.Drawing.Point(592, 72);
            this.dateFinalAte.Name = "dateFinalAte";
            this.dateFinalAte.Size = new System.Drawing.Size(100, 24);
            this.dateFinalAte.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Até";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data Final";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Até";
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // codItemDataGridViewTextBoxColumn
            // 
            this.codItemDataGridViewTextBoxColumn.DataPropertyName = "codItem";
            this.codItemDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codItemDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codItemDataGridViewTextBoxColumn.Name = "codItemDataGridViewTextBoxColumn";
            this.codItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.codItemDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codAutorDataGridViewTextBoxColumn
            // 
            this.codAutorDataGridViewTextBoxColumn.DataPropertyName = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.HeaderText = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.Name = "codAutorDataGridViewTextBoxColumn";
            this.codAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numExemplarDataGridViewTextBoxColumn
            // 
            this.numExemplarDataGridViewTextBoxColumn.DataPropertyName = "numExemplar";
            this.numExemplarDataGridViewTextBoxColumn.HeaderText = "Exemplar";
            this.numExemplarDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.numExemplarDataGridViewTextBoxColumn.Name = "numExemplarDataGridViewTextBoxColumn";
            this.numExemplarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoItemDataGridViewTextBoxColumn
            // 
            this.tipoItemDataGridViewTextBoxColumn.DataPropertyName = "tipoItem";
            this.tipoItemDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoItemDataGridViewTextBoxColumn.Name = "tipoItemDataGridViewTextBoxColumn";
            this.tipoItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLeitorDataGridViewTextBoxColumn
            // 
            this.codLeitorDataGridViewTextBoxColumn.DataPropertyName = "codLeitor";
            this.codLeitorDataGridViewTextBoxColumn.HeaderText = "codLeitor";
            this.codLeitorDataGridViewTextBoxColumn.Name = "codLeitorDataGridViewTextBoxColumn";
            this.codLeitorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLeitorDataGridViewTextBoxColumn.Visible = false;
            // 
            // leitorDataGridViewTextBoxColumn
            // 
            this.leitorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leitorDataGridViewTextBoxColumn.DataPropertyName = "Leitor";
            this.leitorDataGridViewTextBoxColumn.HeaderText = "Leitor";
            this.leitorDataGridViewTextBoxColumn.MinimumWidth = 170;
            this.leitorDataGridViewTextBoxColumn.Name = "leitorDataGridViewTextBoxColumn";
            this.leitorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataReservaDataGridViewTextBoxColumn
            // 
            this.dataReservaDataGridViewTextBoxColumn.DataPropertyName = "dataReserva";
            this.dataReservaDataGridViewTextBoxColumn.HeaderText = "Data da Reserva";
            this.dataReservaDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dataReservaDataGridViewTextBoxColumn.Name = "dataReservaDataGridViewTextBoxColumn";
            this.dataReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prazoReservaDataGridViewTextBoxColumn
            // 
            this.prazoReservaDataGridViewTextBoxColumn.DataPropertyName = "prazoReserva";
            this.prazoReservaDataGridViewTextBoxColumn.HeaderText = "Prazo da Reserva";
            this.prazoReservaDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.prazoReservaDataGridViewTextBoxColumn.Name = "prazoReservaDataGridViewTextBoxColumn";
            this.prazoReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLocalDataGridViewTextBoxColumn
            // 
            this.codLocalDataGridViewTextBoxColumn.DataPropertyName = "codLocal";
            this.codLocalDataGridViewTextBoxColumn.HeaderText = "codLocal";
            this.codLocalDataGridViewTextBoxColumn.Name = "codLocalDataGridViewTextBoxColumn";
            this.codLocalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLocalDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoLocalDataGridViewTextBoxColumn
            // 
            this.descricaoLocalDataGridViewTextBoxColumn.DataPropertyName = "descricaoLocal";
            this.descricaoLocalDataGridViewTextBoxColumn.HeaderText = "Local";
            this.descricaoLocalDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.descricaoLocalDataGridViewTextBoxColumn.Name = "descricaoLocalDataGridViewTextBoxColumn";
            this.descricaoLocalDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoLocalDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(871, 416);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateFinalDesde);
            this.Controls.Add(this.dateFinalAte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateInicioDesde);
            this.Controls.Add(this.dateInicioAte);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gridEmprestimos);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Emprestimo";
            this.Load += new System.EventHandler(this.ConsultaEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.DataGridView gridEmprestimos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.DateTimePicker dateInicioAte;
        private System.Windows.Forms.DateTimePicker dateInicioDesde;
        private System.Windows.Forms.DateTimePicker dateFinalDesde;
        private System.Windows.Forms.DateTimePicker dateFinalAte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private treinamentoDataSetTabelas treinamentoDataSetTabelas;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private treinamentoDataSetTabelasTableAdapters.reservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numExemplarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoLocalDataGridViewTextBoxColumn;
    }
}