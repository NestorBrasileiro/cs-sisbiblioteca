
namespace biblioteca
{
    partial class FormSecao
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
            this.gridSecoesCadastradas = new System.Windows.Forms.DataGridView();
            this.codSecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoSecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBSecaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirSecao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricaoSecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mvtBIBSecaoTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBSecaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecoesCadastradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBSecaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSecoesCadastradas
            // 
            this.gridSecoesCadastradas.AllowUserToAddRows = false;
            this.gridSecoesCadastradas.AllowUserToDeleteRows = false;
            this.gridSecoesCadastradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSecoesCadastradas.AutoGenerateColumns = false;
            this.gridSecoesCadastradas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridSecoesCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecoesCadastradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSecaoDataGridViewTextBoxColumn,
            this.descricaoSecaoDataGridViewTextBoxColumn});
            this.gridSecoesCadastradas.DataSource = this.mvtBIBSecaoBindingSource;
            this.gridSecoesCadastradas.Location = new System.Drawing.Point(12, 130);
            this.gridSecoesCadastradas.Name = "gridSecoesCadastradas";
            this.gridSecoesCadastradas.ReadOnly = true;
            this.gridSecoesCadastradas.Size = new System.Drawing.Size(724, 227);
            this.gridSecoesCadastradas.TabIndex = 3;
            this.gridSecoesCadastradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSecoesCadastradas_CellClick);
            // 
            // codSecaoDataGridViewTextBoxColumn
            // 
            this.codSecaoDataGridViewTextBoxColumn.DataPropertyName = "codSecao";
            this.codSecaoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codSecaoDataGridViewTextBoxColumn.MinimumWidth = 55;
            this.codSecaoDataGridViewTextBoxColumn.Name = "codSecaoDataGridViewTextBoxColumn";
            this.codSecaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSecaoDataGridViewTextBoxColumn.Width = 55;
            // 
            // descricaoSecaoDataGridViewTextBoxColumn
            // 
            this.descricaoSecaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoSecaoDataGridViewTextBoxColumn.DataPropertyName = "descricaoSecao";
            this.descricaoSecaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoSecaoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descricaoSecaoDataGridViewTextBoxColumn.Name = "descricaoSecaoDataGridViewTextBoxColumn";
            this.descricaoSecaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mvtBIBSecaoBindingSource
            // 
            this.mvtBIBSecaoBindingSource.DataMember = "MvtBIBSecao";
            this.mvtBIBSecaoBindingSource.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSecao.Location = new System.Drawing.Point(90, 12);
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(102, 24);
            this.txtCodSecao.TabIndex = 51;
            this.txtCodSecao.TextChanged += new System.EventHandler(this.txtCodSecao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExcluirSecao
            // 
            this.btnExcluirSecao.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSecao.Location = new System.Drawing.Point(184, 99);
            this.btnExcluirSecao.Name = "btnExcluirSecao";
            this.btnExcluirSecao.Size = new System.Drawing.Size(88, 25);
            this.btnExcluirSecao.TabIndex = 2;
            this.btnExcluirSecao.Text = "Excluir";
            this.btnExcluirSecao.UseVisualStyleBackColor = false;
            this.btnExcluirSecao.Click += new System.EventHandler(this.btnExcluirSecao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(90, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 25);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricaoSecao
            // 
            this.txtDescricaoSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoSecao.Location = new System.Drawing.Point(90, 38);
            this.txtDescricaoSecao.Multiline = true;
            this.txtDescricaoSecao.Name = "txtDescricaoSecao";
            this.txtDescricaoSecao.Size = new System.Drawing.Size(235, 55);
            this.txtDescricaoSecao.TabIndex = 0;
            this.txtDescricaoSecao.TextChanged += new System.EventHandler(this.txtDescricaoSecao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Descrição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mvtBIBSecaoTableAdapter
            // 
            this.mvtBIBSecaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(748, 369);
            this.Controls.Add(this.gridSecoesCadastradas);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirSecao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricaoSecao);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seção";
            this.Load += new System.EventHandler(this.FormSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSecoesCadastradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBSecaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSecoesCadastradas;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirSecao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricaoSecao;
        private System.Windows.Forms.Label label2;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBSecaoBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBSecaoTableAdapter mvtBIBSecaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoSecaoDataGridViewTextBoxColumn;
    }
}