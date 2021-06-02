
namespace biblioteca
{
    partial class FormLeitor
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
            this.label18 = new System.Windows.Forms.Label();
            this.txtEndCepLeitor = new System.Windows.Forms.MaskedTextBox();
            this.cbxEndUfLeitor = new System.Windows.Forms.ComboBox();
            this.cbxSexoLeitor = new System.Windows.Forms.ComboBox();
            this.txtRgLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtTelLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCelLeitor = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEndCidadeLeitor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEndBairroLeitor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEndRuaLeitor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtEndNumLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirLeitor = new System.Windows.Forms.Button();
            this.bntCadLeitor = new System.Windows.Forms.Button();
            this.labelAviso = new System.Windows.Forms.Label();
            this.gridLeitoresCadastrados = new System.Windows.Forms.DataGridView();
            this.codLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoBairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoUFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBLeitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.dateDataNasc = new System.Windows.Forms.DateTimePicker();
            this.mvtBIBLeitorTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBLeitorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeitoresCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLeitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(337, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 79;
            this.label18.Text = "CEP";
            // 
            // txtEndCepLeitor
            // 
            this.txtEndCepLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCepLeitor.Location = new System.Drawing.Point(373, 158);
            this.txtEndCepLeitor.Mask = "00000-000";
            this.txtEndCepLeitor.Name = "txtEndCepLeitor";
            this.txtEndCepLeitor.Size = new System.Drawing.Size(83, 24);
            this.txtEndCepLeitor.TabIndex = 11;
            this.txtEndCepLeitor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbxEndUfLeitor
            // 
            this.cbxEndUfLeitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndUfLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEndUfLeitor.FormattingEnabled = true;
            this.cbxEndUfLeitor.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbxEndUfLeitor.Location = new System.Drawing.Point(373, 187);
            this.cbxEndUfLeitor.Name = "cbxEndUfLeitor";
            this.cbxEndUfLeitor.Size = new System.Drawing.Size(83, 24);
            this.cbxEndUfLeitor.TabIndex = 13;
            // 
            // cbxSexoLeitor
            // 
            this.cbxSexoLeitor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbxSexoLeitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexoLeitor.FormattingEnabled = true;
            this.cbxSexoLeitor.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoLeitor.Location = new System.Drawing.Point(609, 71);
            this.cbxSexoLeitor.Name = "cbxSexoLeitor";
            this.cbxSexoLeitor.Size = new System.Drawing.Size(100, 24);
            this.cbxSexoLeitor.TabIndex = 3;
            // 
            // txtRgLeitor
            // 
            this.txtRgLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgLeitor.Location = new System.Drawing.Point(242, 101);
            this.txtRgLeitor.Mask = "0000000000";
            this.txtRgLeitor.Name = "txtRgLeitor";
            this.txtRgLeitor.Size = new System.Drawing.Size(121, 24);
            this.txtRgLeitor.TabIndex = 5;
            this.txtRgLeitor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRgLeitor.ValidatingType = typeof(int);
            // 
            // txtCpfLeitor
            // 
            this.txtCpfLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfLeitor.Location = new System.Drawing.Point(74, 101);
            this.txtCpfLeitor.Mask = "000,000,000-00";
            this.txtCpfLeitor.Name = "txtCpfLeitor";
            this.txtCpfLeitor.Size = new System.Drawing.Size(117, 24);
            this.txtCpfLeitor.TabIndex = 4;
            this.txtCpfLeitor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelLeitor
            // 
            this.txtTelLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelLeitor.Location = new System.Drawing.Point(609, 103);
            this.txtTelLeitor.Mask = "(99) 00000-0000";
            this.txtTelLeitor.Name = "txtTelLeitor";
            this.txtTelLeitor.Size = new System.Drawing.Size(100, 24);
            this.txtTelLeitor.TabIndex = 6;
            this.txtTelLeitor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelCelLeitor
            // 
            this.txtTelCelLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCelLeitor.Location = new System.Drawing.Point(609, 136);
            this.txtTelCelLeitor.Mask = "(99) 00000-0000";
            this.txtTelCelLeitor.Name = "txtTelCelLeitor";
            this.txtTelCelLeitor.Size = new System.Drawing.Size(100, 24);
            this.txtTelCelLeitor.TabIndex = 7;
            this.txtTelCelLeitor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(344, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 16);
            this.label17.TabIndex = 66;
            this.label17.Text = "UF";
            // 
            // txtEndCidadeLeitor
            // 
            this.txtEndCidadeLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCidadeLeitor.Location = new System.Drawing.Point(74, 187);
            this.txtEndCidadeLeitor.Name = "txtEndCidadeLeitor";
            this.txtEndCidadeLeitor.Size = new System.Drawing.Size(257, 24);
            this.txtEndCidadeLeitor.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 64;
            this.label16.Text = "Cidade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 63;
            this.label15.Text = "Bairro";
            // 
            // txtEndBairroLeitor
            // 
            this.txtEndBairroLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndBairroLeitor.Location = new System.Drawing.Point(74, 159);
            this.txtEndBairroLeitor.Name = "txtEndBairroLeitor";
            this.txtEndBairroLeitor.Size = new System.Drawing.Size(257, 24);
            this.txtEndBairroLeitor.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 61;
            // 
            // txtEndRuaLeitor
            // 
            this.txtEndRuaLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndRuaLeitor.Location = new System.Drawing.Point(74, 131);
            this.txtEndRuaLeitor.Name = "txtEndRuaLeitor";
            this.txtEndRuaLeitor.Size = new System.Drawing.Size(289, 24);
            this.txtEndRuaLeitor.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Rua";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(555, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Telefone";
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLeitor.Location = new System.Drawing.Point(74, 71);
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.Size = new System.Drawing.Size(289, 24);
            this.txtEmailLeitor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Data de nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Codigo";
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(74, 41);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(382, 24);
            this.txtNomeLeitor.TabIndex = 0;
            this.txtNomeLeitor.TextChanged += new System.EventHandler(this.txtNomeLeitor_TextChanged);
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLeitor.Location = new System.Drawing.Point(74, 12);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.ReadOnly = true;
            this.txtCodLeitor.Size = new System.Drawing.Size(84, 24);
            this.txtCodLeitor.TabIndex = 19;
            this.txtCodLeitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndNumLeitor
            // 
            this.txtEndNumLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndNumLeitor.Location = new System.Drawing.Point(395, 131);
            this.txtEndNumLeitor.Name = "txtEndNumLeitor";
            this.txtEndNumLeitor.Size = new System.Drawing.Size(61, 24);
            this.txtEndNumLeitor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "N°";
            // 
            // btnExcluirLeitor
            // 
            this.btnExcluirLeitor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirLeitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirLeitor.Location = new System.Drawing.Point(168, 217);
            this.btnExcluirLeitor.Name = "btnExcluirLeitor";
            this.btnExcluirLeitor.Size = new System.Drawing.Size(88, 27);
            this.btnExcluirLeitor.TabIndex = 15;
            this.btnExcluirLeitor.Text = "Excluir";
            this.btnExcluirLeitor.UseVisualStyleBackColor = false;
            this.btnExcluirLeitor.Click += new System.EventHandler(this.btnExcluirLeitor_Click_1);
            // 
            // bntCadLeitor
            // 
            this.bntCadLeitor.BackColor = System.Drawing.Color.Transparent;
            this.bntCadLeitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntCadLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCadLeitor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadLeitor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntCadLeitor.Location = new System.Drawing.Point(74, 217);
            this.bntCadLeitor.Name = "bntCadLeitor";
            this.bntCadLeitor.Size = new System.Drawing.Size(88, 27);
            this.bntCadLeitor.TabIndex = 14;
            this.bntCadLeitor.Text = "Salvar";
            this.bntCadLeitor.UseVisualStyleBackColor = false;
            this.bntCadLeitor.Click += new System.EventHandler(this.bntCadLeitor_Click);
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.Location = new System.Drawing.Point(618, 240);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(0, 16);
            this.labelAviso.TabIndex = 82;
            this.labelAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridLeitoresCadastrados
            // 
            this.gridLeitoresCadastrados.AllowUserToAddRows = false;
            this.gridLeitoresCadastrados.AllowUserToDeleteRows = false;
            this.gridLeitoresCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLeitoresCadastrados.AutoGenerateColumns = false;
            this.gridLeitoresCadastrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridLeitoresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeitoresCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLeitorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.sexoDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telefoneCelularDataGridViewTextBoxColumn,
            this.enderecoNomeDataGridViewTextBoxColumn,
            this.enderecoBairroDataGridViewTextBoxColumn,
            this.enderecoCidadeDataGridViewTextBoxColumn,
            this.enderecoCEPDataGridViewTextBoxColumn,
            this.enderecoUFDataGridViewTextBoxColumn,
            this.enderecoNumeroDataGridViewTextBoxColumn});
            this.gridLeitoresCadastrados.DataSource = this.mvtBIBLeitorBindingSource;
            this.gridLeitoresCadastrados.GridColor = System.Drawing.SystemColors.Window;
            this.gridLeitoresCadastrados.Location = new System.Drawing.Point(12, 250);
            this.gridLeitoresCadastrados.Name = "gridLeitoresCadastrados";
            this.gridLeitoresCadastrados.ReadOnly = true;
            this.gridLeitoresCadastrados.Size = new System.Drawing.Size(697, 242);
            this.gridLeitoresCadastrados.TabIndex = 16;
            this.gridLeitoresCadastrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLeitoresCadastrados_CellClick);
            this.gridLeitoresCadastrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLeitoresCadastrados_CellContentClick);
            // 
            // codLeitorDataGridViewTextBoxColumn
            // 
            this.codLeitorDataGridViewTextBoxColumn.DataPropertyName = "codLeitor";
            this.codLeitorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codLeitorDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codLeitorDataGridViewTextBoxColumn.Name = "codLeitorDataGridViewTextBoxColumn";
            this.codLeitorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLeitorDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "leitor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Leitor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 40;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 80;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Width = 80;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgDataGridViewTextBoxColumn.Width = 80;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 85;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 85;
            // 
            // telefoneCelularDataGridViewTextBoxColumn
            // 
            this.telefoneCelularDataGridViewTextBoxColumn.DataPropertyName = "telefoneCelular";
            this.telefoneCelularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.telefoneCelularDataGridViewTextBoxColumn.MinimumWidth = 85;
            this.telefoneCelularDataGridViewTextBoxColumn.Name = "telefoneCelularDataGridViewTextBoxColumn";
            this.telefoneCelularDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneCelularDataGridViewTextBoxColumn.Width = 85;
            // 
            // enderecoNomeDataGridViewTextBoxColumn
            // 
            this.enderecoNomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enderecoNomeDataGridViewTextBoxColumn.DataPropertyName = "enderecoNome";
            this.enderecoNomeDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.enderecoNomeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.enderecoNomeDataGridViewTextBoxColumn.Name = "enderecoNomeDataGridViewTextBoxColumn";
            this.enderecoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoBairroDataGridViewTextBoxColumn
            // 
            this.enderecoBairroDataGridViewTextBoxColumn.DataPropertyName = "enderecoBairro";
            this.enderecoBairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.enderecoBairroDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.enderecoBairroDataGridViewTextBoxColumn.Name = "enderecoBairroDataGridViewTextBoxColumn";
            this.enderecoBairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoBairroDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoCidadeDataGridViewTextBoxColumn
            // 
            this.enderecoCidadeDataGridViewTextBoxColumn.DataPropertyName = "enderecoCidade";
            this.enderecoCidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.enderecoCidadeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.enderecoCidadeDataGridViewTextBoxColumn.Name = "enderecoCidadeDataGridViewTextBoxColumn";
            this.enderecoCidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoCidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoCEPDataGridViewTextBoxColumn
            // 
            this.enderecoCEPDataGridViewTextBoxColumn.DataPropertyName = "enderecoCEP";
            this.enderecoCEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.enderecoCEPDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.enderecoCEPDataGridViewTextBoxColumn.Name = "enderecoCEPDataGridViewTextBoxColumn";
            this.enderecoCEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoUFDataGridViewTextBoxColumn
            // 
            this.enderecoUFDataGridViewTextBoxColumn.DataPropertyName = "enderecoUF";
            this.enderecoUFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.enderecoUFDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.enderecoUFDataGridViewTextBoxColumn.Name = "enderecoUFDataGridViewTextBoxColumn";
            this.enderecoUFDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoUFDataGridViewTextBoxColumn.Width = 50;
            // 
            // enderecoNumeroDataGridViewTextBoxColumn
            // 
            this.enderecoNumeroDataGridViewTextBoxColumn.DataPropertyName = "enderecoNumero";
            this.enderecoNumeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.enderecoNumeroDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.enderecoNumeroDataGridViewTextBoxColumn.Name = "enderecoNumeroDataGridViewTextBoxColumn";
            this.enderecoNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoNumeroDataGridViewTextBoxColumn.Width = 70;
            // 
            // mvtBIBLeitorBindingSource
            // 
            this.mvtBIBLeitorBindingSource.DataMember = "MvtBIBLeitor";
            this.mvtBIBLeitorBindingSource.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateDataNasc
            // 
            this.dateDataNasc.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataNasc.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataNasc.Location = new System.Drawing.Point(609, 41);
            this.dateDataNasc.Name = "dateDataNasc";
            this.dateDataNasc.Size = new System.Drawing.Size(100, 24);
            this.dateDataNasc.TabIndex = 1;
            this.dateDataNasc.ValueChanged += new System.EventHandler(this.dateDataNasc_ValueChanged);
            // 
            // mvtBIBLeitorTableAdapter
            // 
            this.mvtBIBLeitorTableAdapter.ClearBeforeFill = true;
            // 
            // FormLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(721, 504);
            this.Controls.Add(this.dateDataNasc);
            this.Controls.Add(this.gridLeitoresCadastrados);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.btnExcluirLeitor);
            this.Controls.Add(this.bntCadLeitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndNumLeitor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEndCepLeitor);
            this.Controls.Add(this.cbxEndUfLeitor);
            this.Controls.Add(this.cbxSexoLeitor);
            this.Controls.Add(this.txtRgLeitor);
            this.Controls.Add(this.txtCpfLeitor);
            this.Controls.Add(this.txtTelLeitor);
            this.Controls.Add(this.txtTelCelLeitor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEndCidadeLeitor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEndBairroLeitor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEndRuaLeitor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmailLeitor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.txtCodLeitor);
            this.Name = "FormLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca - Cadastro Leitor";
            this.Load += new System.EventHandler(this.formLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLeitoresCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLeitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtEndCepLeitor;
        private System.Windows.Forms.ComboBox cbxEndUfLeitor;
        private System.Windows.Forms.ComboBox cbxSexoLeitor;
        private System.Windows.Forms.MaskedTextBox txtRgLeitor;
        private System.Windows.Forms.MaskedTextBox txtCpfLeitor;
        private System.Windows.Forms.MaskedTextBox txtTelLeitor;
        private System.Windows.Forms.MaskedTextBox txtTelCelLeitor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEndCidadeLeitor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEndBairroLeitor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEndRuaLeitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtEndNumLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirLeitor;
        private System.Windows.Forms.Button bntCadLeitor;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn leitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridLeitoresCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateDataNasc;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBLeitorBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBLeitorTableAdapter mvtBIBLeitorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoBairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoUFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoNumeroDataGridViewTextBoxColumn;
    }
}