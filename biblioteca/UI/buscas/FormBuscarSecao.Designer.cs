
namespace biblioteca.UI
{
    partial class FormBuscarSecao
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
            this.gridSecoes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBSecaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfoSecao = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mvtBIBSecaoTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBSecaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBSecaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSecoes
            // 
            this.gridSecoes.AllowUserToAddRows = false;
            this.gridSecoes.AllowUserToDeleteRows = false;
            this.gridSecoes.AutoGenerateColumns = false;
            this.gridSecoes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridSecoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridSecoes.DataSource = this.mvtBIBSecaoBindingSource;
            this.gridSecoes.Location = new System.Drawing.Point(12, 42);
            this.gridSecoes.Name = "gridSecoes";
            this.gridSecoes.ReadOnly = true;
            this.gridSecoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSecoes.Size = new System.Drawing.Size(427, 315);
            this.gridSecoes.TabIndex = 2;
            this.gridSecoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSecoes_CellClick);
            this.gridSecoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSecoes_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codSecao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricaoSecao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição";
            // 
            // txtInfoSecao
            // 
            this.txtInfoSecao.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoSecao.Location = new System.Drawing.Point(78, 12);
            this.txtInfoSecao.Name = "txtInfoSecao";
            this.txtInfoSecao.Size = new System.Drawing.Size(262, 23);
            this.txtInfoSecao.TabIndex = 0;
            this.txtInfoSecao.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(341, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 24);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // mvtBIBSecaoTableAdapter
            // 
            this.mvtBIBSecaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuscarSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(451, 369);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridSecoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfoSecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBuscarSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Seção";
            this.Load += new System.EventHandler(this.FormBuscarSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSecoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBSecaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSecoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfoSecao;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn codSecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoSecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConfirmar;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBSecaoBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBSecaoTableAdapter mvtBIBSecaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}