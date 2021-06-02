
namespace biblioteca.UI
{
    partial class FormBuscarEditora
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
            this.gridEditoras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mvtBIBEditoraTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBEditoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBEditoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEditoras
            // 
            this.gridEditoras.AllowUserToAddRows = false;
            this.gridEditoras.AllowUserToDeleteRows = false;
            this.gridEditoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEditoras.AutoGenerateColumns = false;
            this.gridEditoras.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridEditoras.DataSource = this.mvtBIBEditoraBindingSource;
            this.gridEditoras.Location = new System.Drawing.Point(12, 42);
            this.gridEditoras.Name = "gridEditoras";
            this.gridEditoras.ReadOnly = true;
            this.gridEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEditoras.Size = new System.Drawing.Size(304, 251);
            this.gridEditoras.TabIndex = 2;
            this.gridEditoras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEditoras_CellClick);
            this.gridEditoras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEditoras_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codEditora";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditora.Location = new System.Drawing.Point(54, 12);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(181, 23);
            this.txtNomeEditora.TabIndex = 0;
            this.txtNomeEditora.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(241, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // mvtBIBEditoraTableAdapter
            // 
            this.mvtBIBEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuscarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(328, 305);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridEditoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEditora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBuscarEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editoras";
            this.Load += new System.EventHandler(this.FormBuscarEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEditoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBEditoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEditoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEditora;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn codEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConfirmar;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBEditoraBindingSource;
        private treinamentoDataSetTableAdapters.MvtBIBEditoraTableAdapter mvtBIBEditoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}