
namespace biblioteca
{
    partial class FormLocal
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
            this.gridLocais = new System.Windows.Forms.DataGridView();
            this.codLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBLocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirLocal = new System.Windows.Forms.Button();
            this.btnCadLocal = new System.Windows.Forms.Button();
            this.txtLocalDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mvtBIBLocalTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBLocalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLocalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLocais
            // 
            this.gridLocais.AllowUserToAddRows = false;
            this.gridLocais.AllowUserToDeleteRows = false;
            this.gridLocais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLocais.AutoGenerateColumns = false;
            this.gridLocais.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocalDataGridViewTextBoxColumn,
            this.descricaoLocalDataGridViewTextBoxColumn});
            this.gridLocais.DataSource = this.mvtBIBLocalBindingSource;
            this.gridLocais.Location = new System.Drawing.Point(12, 126);
            this.gridLocais.Name = "gridLocais";
            this.gridLocais.ReadOnly = true;
            this.gridLocais.Size = new System.Drawing.Size(725, 230);
            this.gridLocais.TabIndex = 3;
            this.gridLocais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocais_CellClick);
            // 
            // codLocalDataGridViewTextBoxColumn
            // 
            this.codLocalDataGridViewTextBoxColumn.DataPropertyName = "codLocal";
            this.codLocalDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codLocalDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codLocalDataGridViewTextBoxColumn.Name = "codLocalDataGridViewTextBoxColumn";
            this.codLocalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLocalDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoLocalDataGridViewTextBoxColumn
            // 
            this.descricaoLocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoLocalDataGridViewTextBoxColumn.DataPropertyName = "descricaoLocal";
            this.descricaoLocalDataGridViewTextBoxColumn.HeaderText = "Local";
            this.descricaoLocalDataGridViewTextBoxColumn.Name = "descricaoLocalDataGridViewTextBoxColumn";
            this.descricaoLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mvtBIBLocalBindingSource
            // 
            this.mvtBIBLocalBindingSource.DataMember = "MvtBIBLocal";
            this.mvtBIBLocalBindingSource.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(84, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(90, 24);
            this.txtCod.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExcluirLocal
            // 
            this.btnExcluirLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirLocal.Location = new System.Drawing.Point(180, 93);
            this.btnExcluirLocal.Name = "btnExcluirLocal";
            this.btnExcluirLocal.Size = new System.Drawing.Size(90, 27);
            this.btnExcluirLocal.TabIndex = 2;
            this.btnExcluirLocal.Text = "Excluir";
            this.btnExcluirLocal.UseVisualStyleBackColor = false;
            this.btnExcluirLocal.Click += new System.EventHandler(this.btnExcluirLocal_Click);
            // 
            // btnCadLocal
            // 
            this.btnCadLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnCadLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLocal.Location = new System.Drawing.Point(84, 93);
            this.btnCadLocal.Name = "btnCadLocal";
            this.btnCadLocal.Size = new System.Drawing.Size(90, 27);
            this.btnCadLocal.TabIndex = 1;
            this.btnCadLocal.Text = "Salvar";
            this.btnCadLocal.UseVisualStyleBackColor = false;
            this.btnCadLocal.Click += new System.EventHandler(this.btnCadLocal_Click);
            // 
            // txtLocalDescricao
            // 
            this.txtLocalDescricao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalDescricao.Location = new System.Drawing.Point(84, 38);
            this.txtLocalDescricao.Multiline = true;
            this.txtLocalDescricao.Name = "txtLocalDescricao";
            this.txtLocalDescricao.Size = new System.Drawing.Size(271, 49);
            this.txtLocalDescricao.TabIndex = 0;
            this.txtLocalDescricao.TextChanged += new System.EventHandler(this.txtLocalDescricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Descrição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mvtBIBLocalTableAdapter
            // 
            this.mvtBIBLocalTableAdapter.ClearBeforeFill = true;
            // 
            // FormLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(749, 368);
            this.Controls.Add(this.gridLocais);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirLocal);
            this.Controls.Add(this.btnCadLocal);
            this.Controls.Add(this.txtLocalDescricao);
            this.Controls.Add(this.label2);
            this.Name = "FormLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local";
            this.Load += new System.EventHandler(this.FormLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLocalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridLocais;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirLocal;
        private System.Windows.Forms.Button btnCadLocal;
        private System.Windows.Forms.TextBox txtLocalDescricao;
        private System.Windows.Forms.Label label2;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBLocalBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBLocalTableAdapter mvtBIBLocalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoLocalDataGridViewTextBoxColumn;
    }
}