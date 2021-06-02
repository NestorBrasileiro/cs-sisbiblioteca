
namespace biblioteca
{
    partial class FormEditora
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
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnExcluirEditora = new System.Windows.Forms.Button();
            this.btnSalvarEditora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridEditorasCadastradas = new System.Windows.Forms.DataGridView();
            this.codEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.mvtBIBEditoraTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBEditoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditorasCadastradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBEditoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(132, 44);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(213, 24);
            this.txtNomeEditora.TabIndex = 0;
            this.txtNomeEditora.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // btnExcluirEditora
            // 
            this.btnExcluirEditora.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirEditora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEditora.Location = new System.Drawing.Point(242, 76);
            this.btnExcluirEditora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirEditora.Name = "btnExcluirEditora";
            this.btnExcluirEditora.Size = new System.Drawing.Size(103, 25);
            this.btnExcluirEditora.TabIndex = 2;
            this.btnExcluirEditora.Text = "Excluir";
            this.btnExcluirEditora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirEditora.UseVisualStyleBackColor = false;
            this.btnExcluirEditora.Click += new System.EventHandler(this.btnExcluirEditora_Click);
            // 
            // btnSalvarEditora
            // 
            this.btnSalvarEditora.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarEditora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvarEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarEditora.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvarEditora.Location = new System.Drawing.Point(132, 76);
            this.btnSalvarEditora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarEditora.Name = "btnSalvarEditora";
            this.btnSalvarEditora.Size = new System.Drawing.Size(103, 25);
            this.btnSalvarEditora.TabIndex = 1;
            this.btnSalvarEditora.Text = "Salvar";
            this.btnSalvarEditora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarEditora.UseVisualStyleBackColor = false;
            this.btnSalvarEditora.Click += new System.EventHandler(this.btnCadEditora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome da Editora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Codigo da Editora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridEditorasCadastradas
            // 
            this.gridEditorasCadastradas.AllowUserToAddRows = false;
            this.gridEditorasCadastradas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEditorasCadastradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEditorasCadastradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEditorasCadastradas.AutoGenerateColumns = false;
            this.gridEditorasCadastradas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridEditorasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEditorasCadastradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEditoraDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.gridEditorasCadastradas.DataSource = this.mvtBIBEditoraBindingSource;
            this.gridEditorasCadastradas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridEditorasCadastradas.Location = new System.Drawing.Point(11, 110);
            this.gridEditorasCadastradas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridEditorasCadastradas.Name = "gridEditorasCadastradas";
            this.gridEditorasCadastradas.ReadOnly = true;
            this.gridEditorasCadastradas.Size = new System.Drawing.Size(641, 177);
            this.gridEditorasCadastradas.TabIndex = 3;
            this.gridEditorasCadastradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEditorasCadastradas_CellClick);
            // 
            // codEditoraDataGridViewTextBoxColumn
            // 
            this.codEditoraDataGridViewTextBoxColumn.DataPropertyName = "codEditora";
            this.codEditoraDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codEditoraDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.codEditoraDataGridViewTextBoxColumn.Name = "codEditoraDataGridViewTextBoxColumn";
            this.codEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEditoraDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mvtBIBEditoraBindingSource
            // 
            this.mvtBIBEditoraBindingSource.DataMember = "MvtBIBEditora";
            this.mvtBIBEditoraBindingSource.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(132, 12);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(100, 24);
            this.txtCod.TabIndex = 6;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mvtBIBEditoraTableAdapter
            // 
            this.mvtBIBEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(665, 300);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.gridEditorasCadastradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirEditora);
            this.Controls.Add(this.btnSalvarEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editora";
            this.Load += new System.EventHandler(this.formEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEditorasCadastradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBEditoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnExcluirEditora;
        private System.Windows.Forms.Button btnSalvarEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridEditorasCadastradas;
        private System.Windows.Forms.TextBox txtCod;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBEditoraBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBEditoraTableAdapter mvtBIBEditoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}