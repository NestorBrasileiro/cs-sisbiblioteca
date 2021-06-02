
namespace biblioteca.UI
{
    partial class FormConsultaAcervo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetTabelas = new biblioteca.treinamentoDataSetTabelas();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coleção";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Situação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seção";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(70, 12);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(294, 24);
            this.txtNomeItem.TabIndex = 2;
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(70, 72);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(181, 24);
            this.txtLocal.TabIndex = 4;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(70, 42);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(440, 24);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // txtColecao
            // 
            this.txtColecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColecao.Location = new System.Drawing.Point(330, 72);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(180, 24);
            this.txtColecao.TabIndex = 5;
            // 
            // txtSecao
            // 
            this.txtSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecao.Location = new System.Drawing.Point(330, 102);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.Size = new System.Drawing.Size(180, 24);
            this.txtSecao.TabIndex = 7;
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItens.AutoGenerateColumns = false;
            this.gridItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gridItens.DataSource = this.itemBindingSource;
            this.gridItens.Location = new System.Drawing.Point(12, 165);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.Size = new System.Drawing.Size(510, 273);
            this.gridItens.TabIndex = 9;
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
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(70, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 27);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.cbxTipoItem.Location = new System.Drawing.Point(410, 12);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(100, 24);
            this.cbxTipoItem.TabIndex = 1;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.cbxSituacao.Location = new System.Drawing.Point(70, 102);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(100, 24);
            this.cbxSituacao.TabIndex = 6;
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
            this.tipoItemDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.tipoItemDataGridViewTextBoxColumn.Name = "tipoItemDataGridViewTextBoxColumn";
            this.tipoItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoItemDataGridViewTextBoxColumn.Width = 70;
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
            this.nome1DataGridViewTextBoxColumn.MinimumWidth = 170;
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
            this.nome2DataGridViewTextBoxColumn.DataPropertyName = "nome2";
            this.nome2DataGridViewTextBoxColumn.HeaderText = "Editora";
            this.nome2DataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nome2DataGridViewTextBoxColumn.Name = "nome2DataGridViewTextBoxColumn";
            this.nome2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nome2DataGridViewTextBoxColumn.Width = 150;
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
            this.volumeDataGridViewTextBoxColumn.Width = 60;
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            this.idiomaDataGridViewTextBoxColumn.DataPropertyName = "idioma";
            this.idiomaDataGridViewTextBoxColumn.HeaderText = "Idioma";
            this.idiomaDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            this.idiomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idiomaDataGridViewTextBoxColumn.Width = 70;
            // 
            // anoEdicaoDataGridViewTextBoxColumn
            // 
            this.anoEdicaoDataGridViewTextBoxColumn.DataPropertyName = "anoEdicao";
            this.anoEdicaoDataGridViewTextBoxColumn.HeaderText = "Ano de edição";
            this.anoEdicaoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.anoEdicaoDataGridViewTextBoxColumn.Name = "anoEdicaoDataGridViewTextBoxColumn";
            this.anoEdicaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoEdicaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // FormConsultaAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gridItens);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.txtColecao);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FormConsultaAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Item";
            this.Load += new System.EventHandler(this.FormConsultaAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.ComboBox cbxSituacao;
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