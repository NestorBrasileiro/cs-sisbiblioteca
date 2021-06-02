
namespace biblioteca.UI
{
    partial class FormBuscarItemAcervo
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
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.maskCodItem = new System.Windows.Forms.MaskedTextBox();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.maskExemplar = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskVolume = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treinamentoDataSetTabelas = new biblioteca.treinamentoDataSetTabelas();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
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
            this.gridItens.Location = new System.Drawing.Point(12, 71);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItens.Size = new System.Drawing.Size(856, 336);
            this.gridItens.TabIndex = 3;
            this.gridItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItens_CellClick);
            this.gridItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItens_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(225, 12);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(354, 23);
            this.txtNomeItem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(585, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // maskCodItem
            // 
            this.maskCodItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCodItem.Location = new System.Drawing.Point(81, 12);
            this.maskCodItem.Mask = "0000";
            this.maskCodItem.Name = "maskCodItem";
            this.maskCodItem.Size = new System.Drawing.Size(47, 23);
            this.maskCodItem.TabIndex = 0;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.Enabled = false;
            this.cbxSituacao.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.cbxSituacao.Location = new System.Drawing.Point(225, 41);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(92, 24);
            this.cbxSituacao.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Situação";
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
            this.cbxTipoItem.Location = new System.Drawing.Point(81, 41);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(80, 24);
            this.cbxTipoItem.TabIndex = 34;
            // 
            // maskExemplar
            // 
            this.maskExemplar.Enabled = false;
            this.maskExemplar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskExemplar.Location = new System.Drawing.Point(412, 41);
            this.maskExemplar.Mask = "0000";
            this.maskExemplar.Name = "maskExemplar";
            this.maskExemplar.Size = new System.Drawing.Size(47, 23);
            this.maskExemplar.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Exemplar";
            // 
            // maskVolume
            // 
            this.maskVolume.Enabled = false;
            this.maskVolume.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskVolume.Location = new System.Drawing.Point(532, 41);
            this.maskVolume.Mask = "0000";
            this.maskVolume.Name = "maskVolume";
            this.maskVolume.Size = new System.Drawing.Size(47, 23);
            this.maskVolume.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Edição";
            // 
            // treinamentoDataSetTabelas
            // 
            this.treinamentoDataSetTabelas.DataSetName = "treinamentoDataSetTabelas";
            this.treinamentoDataSetTabelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.treinamentoDataSetTabelas;
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
            this.nome2DataGridViewTextBoxColumn.DataPropertyName = "nome2";
            this.nome2DataGridViewTextBoxColumn.HeaderText = "Editora";
            this.nome2DataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nome2DataGridViewTextBoxColumn.Name = "nome2DataGridViewTextBoxColumn";
            this.nome2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nome2DataGridViewTextBoxColumn.Width = 120;
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
            this.descricaoLocalDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.descricaoLocalDataGridViewTextBoxColumn.Name = "descricaoLocalDataGridViewTextBoxColumn";
            this.descricaoLocalDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoLocalDataGridViewTextBoxColumn.Width = 120;
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
            this.descricaoSecaoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descricaoSecaoDataGridViewTextBoxColumn.Name = "descricaoSecaoDataGridViewTextBoxColumn";
            this.descricaoSecaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colecaoDataGridViewTextBoxColumn
            // 
            this.colecaoDataGridViewTextBoxColumn.DataPropertyName = "colecao";
            this.colecaoDataGridViewTextBoxColumn.HeaderText = "Coleção";
            this.colecaoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.colecaoDataGridViewTextBoxColumn.Name = "colecaoDataGridViewTextBoxColumn";
            this.colecaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            this.idiomaDataGridViewTextBoxColumn.DataPropertyName = "idioma";
            this.idiomaDataGridViewTextBoxColumn.HeaderText = "idioma";
            this.idiomaDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            this.idiomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idiomaDataGridViewTextBoxColumn.Width = 80;
            // 
            // anoEdicaoDataGridViewTextBoxColumn
            // 
            this.anoEdicaoDataGridViewTextBoxColumn.DataPropertyName = "anoEdicao";
            this.anoEdicaoDataGridViewTextBoxColumn.HeaderText = "Ano de Edição";
            this.anoEdicaoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.anoEdicaoDataGridViewTextBoxColumn.Name = "anoEdicaoDataGridViewTextBoxColumn";
            this.anoEdicaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoEdicaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // FormBuscarItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 419);
            this.Controls.Add(this.maskVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskExemplar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.maskCodItem);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBuscarItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Item";
            this.Load += new System.EventHandler(this.FormBuscarItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetTabelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox maskCodItem;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.MaskedTextBox maskExemplar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskVolume;
        private System.Windows.Forms.Label label6;
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