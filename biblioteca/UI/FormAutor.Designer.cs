
namespace biblioteca
{
    partial class FormMenu
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
            this.mvtBIBAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataSet11 = new biblioteca.DataSet1();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfoAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAutoresCadastrados = new System.Windows.Forms.DataGridView();
            this.codAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.mvtBIBAutorTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBAutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutoresCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(99, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(111, 24);
            this.txtCod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirAutor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAutor.Location = new System.Drawing.Point(193, 115);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(88, 22);
            this.btnExcluirAutor.TabIndex = 4;
            this.btnExcluirAutor.Text = "Excluir";
            this.btnExcluirAutor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirAutor.UseVisualStyleBackColor = false;
            this.btnExcluirAutor.Click += new System.EventHandler(this.excluir_Click_1);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.Transparent;
            this.bntSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntSalvar.Location = new System.Drawing.Point(99, 115);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(88, 22);
            this.bntSalvar.TabIndex = 3;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(99, 38);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(276, 24);
            this.txtNomeAutor.TabIndex = 1;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Informações";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfoAutor
            // 
            this.txtInfoAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoAutor.Location = new System.Drawing.Point(99, 64);
            this.txtInfoAutor.Multiline = true;
            this.txtInfoAutor.Name = "txtInfoAutor";
            this.txtInfoAutor.Size = new System.Drawing.Size(276, 45);
            this.txtInfoAutor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridAutoresCadastrados
            // 
            this.gridAutoresCadastrados.AllowUserToAddRows = false;
            this.gridAutoresCadastrados.AllowUserToDeleteRows = false;
            this.gridAutoresCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAutoresCadastrados.AutoGenerateColumns = false;
            this.gridAutoresCadastrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridAutoresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutoresCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAutorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.gridAutoresCadastrados.DataSource = this.mvtBIBAutorBindingSource;
            this.gridAutoresCadastrados.Location = new System.Drawing.Point(10, 143);
            this.gridAutoresCadastrados.Name = "gridAutoresCadastrados";
            this.gridAutoresCadastrados.ReadOnly = true;
            this.gridAutoresCadastrados.Size = new System.Drawing.Size(660, 205);
            this.gridAutoresCadastrados.TabIndex = 5;
            this.gridAutoresCadastrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAutoresCadastrados_CellClick);
            // 
            // codAutorDataGridViewTextBoxColumn
            // 
            this.codAutorDataGridViewTextBoxColumn.DataPropertyName = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codAutorDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codAutorDataGridViewTextBoxColumn.Name = "codAutorDataGridViewTextBoxColumn";
            this.codAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAutorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mvtBIBAutorBindingSource
            // 
            this.mvtBIBAutorBindingSource.DataMember = "MvtBIBAutor";
            this.mvtBIBAutorBindingSource.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mvtBIBAutorTableAdapter
            // 
            this.mvtBIBAutorTableAdapter.ClearBeforeFill = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 360);
            this.Controls.Add(this.gridAutoresCadastrados);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirAutor);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInfoAutor);
            this.Controls.Add(this.label2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Autor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutoresCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mvtBIBAutorBindingSource1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirAutor;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfoAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridAutoresCadastrados;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBAutorBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBAutorTableAdapter mvtBIBAutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}

