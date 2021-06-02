
namespace biblioteca
{
    partial class FormReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.cbxMovimento = new System.Windows.Forms.ComboBox();
            this.txtExemplar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtLocalItem = new System.Windows.Forms.TextBox();
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetTabelas = new biblioteca.treinamentoDataSetTabelas();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.btnBuscarLeitor = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.dateInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.datePrazoReserva = new System.Windows.Forms.DateTimePicker();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.codItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numExemplarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código do Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo do item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data da Reserva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Codigo do Leitor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Situação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Prazo";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodItem.Location = new System.Drawing.Point(130, 45);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.ReadOnly = true;
            this.txtCodItem.Size = new System.Drawing.Size(90, 24);
            this.txtCodItem.TabIndex = 13;
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Enabled = false;
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(308, 45);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.ReadOnly = true;
            this.txtNomeItem.Size = new System.Drawing.Size(238, 24);
            this.txtNomeItem.TabIndex = 11;
            // 
            // cbxMovimento
            // 
            this.cbxMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMovimento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMovimento.FormattingEnabled = true;
            this.cbxMovimento.Items.AddRange(new object[] {
            "Reservar",
            "Devolver"});
            this.cbxMovimento.Location = new System.Drawing.Point(130, 15);
            this.cbxMovimento.Name = "cbxMovimento";
            this.cbxMovimento.Size = new System.Drawing.Size(90, 24);
            this.cbxMovimento.TabIndex = 0;
            // 
            // txtExemplar
            // 
            this.txtExemplar.Enabled = false;
            this.txtExemplar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplar.Location = new System.Drawing.Point(130, 105);
            this.txtExemplar.Name = "txtExemplar";
            this.txtExemplar.ReadOnly = true;
            this.txtExemplar.Size = new System.Drawing.Size(90, 24);
            this.txtExemplar.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Leitor";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLeitor.Location = new System.Drawing.Point(130, 165);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.ReadOnly = true;
            this.txtCodLeitor.Size = new System.Drawing.Size(90, 24);
            this.txtCodLeitor.TabIndex = 16;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Enabled = false;
            this.txtNomeLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(308, 165);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.ReadOnly = true;
            this.txtNomeLeitor.Size = new System.Drawing.Size(238, 24);
            this.txtNomeLeitor.TabIndex = 17;
            // 
            // txtLocalItem
            // 
            this.txtLocalItem.Enabled = false;
            this.txtLocalItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalItem.Location = new System.Drawing.Point(308, 105);
            this.txtLocalItem.Name = "txtLocalItem";
            this.txtLocalItem.ReadOnly = true;
            this.txtLocalItem.Size = new System.Drawing.Size(238, 24);
            this.txtLocalItem.TabIndex = 18;
            // 
            // gridReserva
            // 
            this.gridReserva.AllowUserToAddRows = false;
            this.gridReserva.AllowUserToDeleteRows = false;
            this.gridReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReserva.AutoGenerateColumns = false;
            this.gridReserva.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codItemDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.codAutorDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.numExemplarDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.codLeitorDataGridViewTextBoxColumn,
            this.leitorDataGridViewTextBoxColumn,
            this.dataReservaDataGridViewTextBoxColumn,
            this.prazoReservaDataGridViewTextBoxColumn,
            this.codLocalDataGridViewTextBoxColumn,
            this.descricaoLocalDataGridViewTextBoxColumn});
            this.gridReserva.DataSource = this.reservaBindingSource;
            this.gridReserva.Location = new System.Drawing.Point(12, 255);
            this.gridReserva.Name = "gridReserva";
            this.gridReserva.ReadOnly = true;
            this.gridReserva.Size = new System.Drawing.Size(608, 265);
            this.gridReserva.TabIndex = 6;
            this.gridReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellClick);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.treinamentoDataSetTabelas;
            // 
            // treinamentoDataSetTabelas
            // 
            this.treinamentoDataSetTabelas.DataSetName = "treinamentoDataSetTabelas";
            this.treinamentoDataSetTabelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(130, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.Enabled = false;
            this.cbxSituacao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.cbxSituacao.Location = new System.Drawing.Point(308, 135);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(112, 24);
            this.cbxSituacao.TabIndex = 28;
            // 
            // btnBuscarLeitor
            // 
            this.btnBuscarLeitor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLeitor.Location = new System.Drawing.Point(552, 164);
            this.btnBuscarLeitor.Name = "btnBuscarLeitor";
            this.btnBuscarLeitor.Size = new System.Drawing.Size(65, 24);
            this.btnBuscarLeitor.TabIndex = 2;
            this.btnBuscarLeitor.Text = "Buscar";
            this.btnBuscarLeitor.UseVisualStyleBackColor = false;
            this.btnBuscarLeitor.Click += new System.EventHandler(this.btnBuscarLeitor_Click);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarItem.Location = new System.Drawing.Point(552, 44);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(65, 24);
            this.btnBuscarItem.TabIndex = 1;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = false;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.Enabled = false;
            this.cbxTipoItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Artigo",
            "DVD/CD",
            "Folheto",
            "Jornal",
            "Livro",
            "Revista"});
            this.cbxTipoItem.Location = new System.Drawing.Point(130, 135);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(90, 24);
            this.cbxTipoItem.TabIndex = 35;
            // 
            // dateInicioReserva
            // 
            this.dateInicioReserva.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicioReserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateInicioReserva.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicioReserva.Location = new System.Drawing.Point(130, 195);
            this.dateInicioReserva.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateInicioReserva.MinDate = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            this.dateInicioReserva.Name = "dateInicioReserva";
            this.dateInicioReserva.Size = new System.Drawing.Size(90, 24);
            this.dateInicioReserva.TabIndex = 3;
            // 
            // datePrazoReserva
            // 
            this.datePrazoReserva.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePrazoReserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePrazoReserva.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePrazoReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePrazoReserva.Location = new System.Drawing.Point(308, 195);
            this.datePrazoReserva.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.datePrazoReserva.MinDate = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            this.datePrazoReserva.Name = "datePrazoReserva";
            this.datePrazoReserva.Size = new System.Drawing.Size(90, 24);
            this.datePrazoReserva.TabIndex = 4;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Enabled = false;
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(308, 75);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(238, 24);
            this.txtNomeAutor.TabIndex = 41;
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Enabled = false;
            this.txtCodAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAutor.Location = new System.Drawing.Point(130, 75);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.ReadOnly = true;
            this.txtCodAutor.Size = new System.Drawing.Size(90, 24);
            this.txtCodAutor.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(234, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Local";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Exemplar";
            // 
            // codItemDataGridViewTextBoxColumn
            // 
            this.codItemDataGridViewTextBoxColumn.DataPropertyName = "codItem";
            this.codItemDataGridViewTextBoxColumn.HeaderText = "Cógido";
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
            this.numExemplarDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.numExemplarDataGridViewTextBoxColumn.Name = "numExemplarDataGridViewTextBoxColumn";
            this.numExemplarDataGridViewTextBoxColumn.ReadOnly = true;
            this.numExemplarDataGridViewTextBoxColumn.Width = 60;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 70;
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
            this.leitorDataGridViewTextBoxColumn.MinimumWidth = 200;
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
            this.descricaoLocalDataGridViewTextBoxColumn.Name = "descricaoLocalDataGridViewTextBoxColumn";
            this.descricaoLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 532);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtCodAutor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.datePrazoReserva);
            this.Controls.Add(this.dateInicioReserva);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.btnBuscarItem);
            this.Controls.Add(this.btnBuscarLeitor);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.txtLocalItem);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.txtCodLeitor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtExemplar);
            this.Controls.Add(this.cbxMovimento);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reseva";
            this.Load += new System.EventHandler(this.FormReseva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.ComboBox cbxMovimento;
        private System.Windows.Forms.TextBox txtExemplar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtLocalItem;
        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Button btnBuscarLeitor;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.DateTimePicker dateInicioReserva;
        private System.Windows.Forms.DateTimePicker datePrazoReserva;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private treinamentoDataSetTabelas treinamentoDataSetTabelas;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numExemplarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoLocalDataGridViewTextBoxColumn;
    }
}