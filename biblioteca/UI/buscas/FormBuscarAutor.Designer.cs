
namespace biblioteca.UI
{
    partial class FormBuscarAutor
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
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSet = new biblioteca.treinamentoDataSet();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mvtBIBAutorTableAdapter = new biblioteca.treinamentoDataSetTableAdapters.MvtBIBAutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(53, 12);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(293, 23);
            this.txtNomeAutor.TabIndex = 0;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // gridAutores
            // 
            this.gridAutores.AllowUserToAddRows = false;
            this.gridAutores.AllowUserToDeleteRows = false;
            this.gridAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAutores.AutoGenerateColumns = false;
            this.gridAutores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gridAutores.DataSource = this.mvtBIBAutorBindingSource1;
            this.gridAutores.Location = new System.Drawing.Point(12, 42);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.ReadOnly = true;
            this.gridAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAutores.Size = new System.Drawing.Size(423, 312);
            this.gridAutores.TabIndex = 2;
            this.gridAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAutores_CellClick);
            this.gridAutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAutores_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codAutor";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // mvtBIBAutorBindingSource1
            // 
            this.mvtBIBAutorBindingSource1.DataMember = "MvtBIBAutor";
            this.mvtBIBAutorBindingSource1.DataSource = this.treinamentoDataSet;
            // 
            // treinamentoDataSet
            // 
            this.treinamentoDataSet.DataSetName = "treinamentoDataSet";
            this.treinamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(352, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 24);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // mvtBIBAutorTableAdapter
            // 
            this.mvtBIBAutorTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuscarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(447, 366);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBuscarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autor";
            this.Load += new System.EventHandler(this.FormBuscarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAutores;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConfirmar;
        private treinamentoDataSet treinamentoDataSet;
        private System.Windows.Forms.BindingSource mvtBIBAutorBindingSource1;
        private treinamentoDataSetTableAdapters.MvtBIBAutorTableAdapter mvtBIBAutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}