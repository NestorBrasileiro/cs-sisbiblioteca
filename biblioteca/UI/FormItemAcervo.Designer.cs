
namespace biblioteca
{
    partial class FormItemAcervo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtNomeColecao = new System.Windows.Forms.TextBox();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.btnBuscarLocal = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnBuscarEditora = new System.Windows.Forms.Button();
            this.btnBuscarSecao = new System.Windows.Forms.Button();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.txtCodLocal = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskAnoEdicao = new System.Windows.Forms.MaskedTextBox();
            this.gridItensCadastrados = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetTabelas = new biblioteca.treinamentoDataSetTabelas();
            this.maskVolume = new System.Windows.Forms.MaskedTextBox();
            this.maskExemplar = new System.Windows.Forms.MaskedTextBox();
            this.item = new biblioteca.treinamentoDataSetTabelasTableAdapters.Item();
            this.codItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numExemplarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoSecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoEdicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridItensCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Editora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Coleção";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Exemplar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Volume";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(508, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ano da Edição";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Seção";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(254, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Situação";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodItem.Location = new System.Drawing.Point(69, 12);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.ReadOnly = true;
            this.txtCodItem.Size = new System.Drawing.Size(48, 24);
            this.txtCodItem.TabIndex = 3;
            this.txtCodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(69, 41);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(343, 24);
            this.txtNomeItem.TabIndex = 2;
            // 
            // txtNomeColecao
            // 
            this.txtNomeColecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeColecao.Location = new System.Drawing.Point(602, 41);
            this.txtNomeColecao.Name = "txtNomeColecao";
            this.txtNomeColecao.Size = new System.Drawing.Size(100, 24);
            this.txtNomeColecao.TabIndex = 7;
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Enabled = false;
            this.txtNomeLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLocal.Location = new System.Drawing.Point(123, 70);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(289, 24);
            this.txtNomeLocal.TabIndex = 3;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Enabled = false;
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(123, 100);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(289, 24);
            this.txtNomeAutor.TabIndex = 4;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Enabled = false;
            this.txtNomeEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditora.Location = new System.Drawing.Point(123, 130);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(289, 24);
            this.txtNomeEditora.TabIndex = 5;
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Enabled = false;
            this.txtNomeSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSecao.Location = new System.Drawing.Point(123, 160);
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(289, 24);
            this.txtNomeSecao.TabIndex = 11;
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Artigo",
            "DVD/CD",
            "Folheto",
            "Jornal",
            "Livro",
            "Revista"});
            this.cbxTipoItem.Location = new System.Drawing.Point(160, 11);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(88, 24);
            this.cbxTipoItem.TabIndex = 0;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.Location = new System.Drawing.Point(163, 190);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(88, 27);
            this.btnExcluirItem.TabIndex = 13;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.Transparent;
            this.bntSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntSalvar.Location = new System.Drawing.Point(69, 190);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(88, 27);
            this.bntSalvar.TabIndex = 12;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.Enabled = false;
            this.cbxSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSituacao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.cbxSituacao.Location = new System.Drawing.Point(314, 11);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(98, 24);
            this.cbxSituacao.TabIndex = 1;
            // 
            // btnBuscarLocal
            // 
            this.btnBuscarLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLocal.Location = new System.Drawing.Point(418, 70);
            this.btnBuscarLocal.Name = "btnBuscarLocal";
            this.btnBuscarLocal.Size = new System.Drawing.Size(64, 24);
            this.btnBuscarLocal.TabIndex = 3;
            this.btnBuscarLocal.Text = "Buscar";
            this.btnBuscarLocal.UseVisualStyleBackColor = true;
            this.btnBuscarLocal.Click += new System.EventHandler(this.btnBuscarLocal_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.Location = new System.Drawing.Point(418, 100);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(64, 24);
            this.btnBuscarAutor.TabIndex = 4;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnBuscarEditora
            // 
            this.btnBuscarEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEditora.Location = new System.Drawing.Point(418, 130);
            this.btnBuscarEditora.Name = "btnBuscarEditora";
            this.btnBuscarEditora.Size = new System.Drawing.Size(64, 24);
            this.btnBuscarEditora.TabIndex = 5;
            this.btnBuscarEditora.Text = "Buscar";
            this.btnBuscarEditora.UseVisualStyleBackColor = true;
            this.btnBuscarEditora.Click += new System.EventHandler(this.btnBuscarEditora_Click);
            // 
            // btnBuscarSecao
            // 
            this.btnBuscarSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSecao.Location = new System.Drawing.Point(418, 160);
            this.btnBuscarSecao.Name = "btnBuscarSecao";
            this.btnBuscarSecao.Size = new System.Drawing.Size(64, 24);
            this.btnBuscarSecao.TabIndex = 6;
            this.btnBuscarSecao.Text = "Buscar";
            this.btnBuscarSecao.UseVisualStyleBackColor = true;
            this.btnBuscarSecao.Click += new System.EventHandler(this.btnBuscarSecao_Click);
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSecao.Location = new System.Drawing.Point(69, 160);
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(48, 24);
            this.txtCodSecao.TabIndex = 20;
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Enabled = false;
            this.txtCodEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEditora.Location = new System.Drawing.Point(69, 130);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.Size = new System.Drawing.Size(48, 24);
            this.txtCodEditora.TabIndex = 19;
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Enabled = false;
            this.txtCodAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAutor.Location = new System.Drawing.Point(69, 100);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.Size = new System.Drawing.Size(48, 24);
            this.txtCodAutor.TabIndex = 18;
            // 
            // txtCodLocal
            // 
            this.txtCodLocal.Enabled = false;
            this.txtCodLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLocal.Location = new System.Drawing.Point(69, 70);
            this.txtCodLocal.Name = "txtCodLocal";
            this.txtCodLocal.Size = new System.Drawing.Size(48, 24);
            this.txtCodLocal.TabIndex = 17;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(602, 72);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 24);
            this.txtIdioma.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Idioma";
            // 
            // maskAnoEdicao
            // 
            this.maskAnoEdicao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskAnoEdicao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskAnoEdicao.Location = new System.Drawing.Point(602, 162);
            this.maskAnoEdicao.Mask = "0000";
            this.maskAnoEdicao.Name = "maskAnoEdicao";
            this.maskAnoEdicao.Size = new System.Drawing.Size(62, 24);
            this.maskAnoEdicao.TabIndex = 11;
            // 
            // gridItensCadastrados
            // 
            this.gridItensCadastrados.AllowUserToAddRows = false;
            this.gridItensCadastrados.AllowUserToDeleteRows = false;
            this.gridItensCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItensCadastrados.AutoGenerateColumns = false;
            this.gridItensCadastrados.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItensCadastrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItensCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItensCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codItemDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.numExemplarDataGridViewTextBoxColumn,
            this.tipoItemDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.codAutorDataGridViewTextBoxColumn,
            this.nome1DataGridViewTextBoxColumn,
            this.codEditoraDataGridViewTextBoxColumn,
            this.nome2DataGridViewTextBoxColumn,
            this.codLocalDataGridViewTextBoxColumn,
            this.descricaoLocalDataGridViewTextBoxColumn,
            this.codSecaoDataGridViewTextBoxColumn,
            this.descricaoSecaoDataGridViewTextBoxColumn,
            this.colecaoDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.idiomaDataGridViewTextBoxColumn,
            this.anoEdicaoDataGridViewTextBoxColumn});
            this.gridItensCadastrados.DataSource = this.itemBindingSource;
            this.gridItensCadastrados.GridColor = System.Drawing.SystemColors.Window;
            this.gridItensCadastrados.Location = new System.Drawing.Point(12, 223);
            this.gridItensCadastrados.Name = "gridItensCadastrados";
            this.gridItensCadastrados.ReadOnly = true;
            this.gridItensCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItensCadastrados.Size = new System.Drawing.Size(803, 328);
            this.gridItensCadastrados.TabIndex = 14;
            this.gridItensCadastrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItensCadastrados_CellClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.treinamentoDataSetTabelas;
            // 
            // treinamentoDataSetTabelas
            // 
            this.treinamentoDataSetTabelas.DataSetName = "treinamentoDataSetTabelas";
            this.treinamentoDataSetTabelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskVolume
            // 
            this.maskVolume.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskVolume.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskVolume.Location = new System.Drawing.Point(602, 132);
            this.maskVolume.Mask = "00000";
            this.maskVolume.Name = "maskVolume";
            this.maskVolume.Size = new System.Drawing.Size(62, 24);
            this.maskVolume.TabIndex = 10;
            // 
            // maskExemplar
            // 
            this.maskExemplar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskExemplar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskExemplar.Location = new System.Drawing.Point(602, 102);
            this.maskExemplar.Mask = "00000";
            this.maskExemplar.Name = "maskExemplar";
            this.maskExemplar.Size = new System.Drawing.Size(62, 24);
            this.maskExemplar.TabIndex = 9;
            // 
            // item
            // 
            this.item.ClearBeforeFill = true;
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
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Item";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tipoItemDataGridViewTextBoxColumn
            // 
            this.tipoItemDataGridViewTextBoxColumn.DataPropertyName = "tipoItem";
            this.tipoItemDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoItemDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.tipoItemDataGridViewTextBoxColumn.Name = "tipoItemDataGridViewTextBoxColumn";
            this.tipoItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoItemDataGridViewTextBoxColumn.Width = 50;
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
            // codAutorDataGridViewTextBoxColumn
            // 
            this.codAutorDataGridViewTextBoxColumn.DataPropertyName = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.HeaderText = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.Name = "codAutorDataGridViewTextBoxColumn";
            this.codAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nome1DataGridViewTextBoxColumn
            // 
            this.nome1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome1DataGridViewTextBoxColumn.DataPropertyName = "nome1";
            this.nome1DataGridViewTextBoxColumn.HeaderText = "Autor";
            this.nome1DataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nome1DataGridViewTextBoxColumn.Name = "nome1DataGridViewTextBoxColumn";
            this.nome1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codEditoraDataGridViewTextBoxColumn
            // 
            this.codEditoraDataGridViewTextBoxColumn.DataPropertyName = "codEditora";
            this.codEditoraDataGridViewTextBoxColumn.HeaderText = "codEditora";
            this.codEditoraDataGridViewTextBoxColumn.Name = "codEditoraDataGridViewTextBoxColumn";
            this.codEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEditoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // nome2DataGridViewTextBoxColumn
            // 
            this.nome2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome2DataGridViewTextBoxColumn.DataPropertyName = "nome2";
            this.nome2DataGridViewTextBoxColumn.HeaderText = "Editora";
            this.nome2DataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nome2DataGridViewTextBoxColumn.Name = "nome2DataGridViewTextBoxColumn";
            this.nome2DataGridViewTextBoxColumn.ReadOnly = true;
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
            // codSecaoDataGridViewTextBoxColumn
            // 
            this.codSecaoDataGridViewTextBoxColumn.DataPropertyName = "codSecao";
            this.codSecaoDataGridViewTextBoxColumn.HeaderText = "codSecao";
            this.codSecaoDataGridViewTextBoxColumn.Name = "codSecaoDataGridViewTextBoxColumn";
            this.codSecaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSecaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoSecaoDataGridViewTextBoxColumn
            // 
            this.descricaoSecaoDataGridViewTextBoxColumn.DataPropertyName = "descricaoSecao";
            this.descricaoSecaoDataGridViewTextBoxColumn.HeaderText = "Seção";
            this.descricaoSecaoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.descricaoSecaoDataGridViewTextBoxColumn.Name = "descricaoSecaoDataGridViewTextBoxColumn";
            this.descricaoSecaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoSecaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // colecaoDataGridViewTextBoxColumn
            // 
            this.colecaoDataGridViewTextBoxColumn.DataPropertyName = "colecao";
            this.colecaoDataGridViewTextBoxColumn.HeaderText = "Coleção";
            this.colecaoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.colecaoDataGridViewTextBoxColumn.Name = "colecaoDataGridViewTextBoxColumn";
            this.colecaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.colecaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            this.idiomaDataGridViewTextBoxColumn.DataPropertyName = "idioma";
            this.idiomaDataGridViewTextBoxColumn.HeaderText = "idioma";
            this.idiomaDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            this.idiomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idiomaDataGridViewTextBoxColumn.Width = 60;
            // 
            // anoEdicaoDataGridViewTextBoxColumn
            // 
            this.anoEdicaoDataGridViewTextBoxColumn.DataPropertyName = "anoEdicao";
            this.anoEdicaoDataGridViewTextBoxColumn.HeaderText = "Edição";
            this.anoEdicaoDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.anoEdicaoDataGridViewTextBoxColumn.Name = "anoEdicaoDataGridViewTextBoxColumn";
            this.anoEdicaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoEdicaoDataGridViewTextBoxColumn.Width = 60;
            // 
            // FormItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(827, 563);
            this.Controls.Add(this.maskExemplar);
            this.Controls.Add(this.maskVolume);
            this.Controls.Add(this.gridItensCadastrados);
            this.Controls.Add(this.maskAnoEdicao);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.txtCodEditora);
            this.Controls.Add(this.txtCodAutor);
            this.Controls.Add(this.txtCodLocal);
            this.Controls.Add(this.btnBuscarSecao);
            this.Controls.Add(this.btnBuscarEditora);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnBuscarLocal);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.txtNomeSecao);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.txtNomeColecao);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Item";
            this.Load += new System.EventHandler(this.FormItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItensCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtNomeColecao;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Button btnBuscarLocal;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarEditora;
        private System.Windows.Forms.Button btnBuscarSecao;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.TextBox txtCodLocal;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskAnoEdicao;
        private System.Windows.Forms.DataGridView gridItensCadastrados;
        private System.Windows.Forms.MaskedTextBox maskVolume;
        private System.Windows.Forms.MaskedTextBox maskExemplar;
        private treinamentoDataSetTabelas treinamentoDataSetTabelas;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private treinamentoDataSetTabelasTableAdapters.Item item;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numExemplarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoSecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoEdicaoDataGridViewTextBoxColumn;
    }
}