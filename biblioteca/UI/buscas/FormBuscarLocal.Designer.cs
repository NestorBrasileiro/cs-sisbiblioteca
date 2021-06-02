
namespace biblioteca.UI
{
    partial class FormBuscarLocal
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvtBIBLocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetCentral = new biblioteca.treinamentoDataSetCentral();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mvtBIBLocalTableAdapter = new biblioteca.treinamentoDataSetCentralTableAdapters.MvtBIBLocalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLocalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLocais
            // 
            this.gridLocais.AllowUserToAddRows = false;
            this.gridLocais.AllowUserToDeleteRows = false;
            this.gridLocais.AutoGenerateColumns = false;
            this.gridLocais.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridLocais.DataSource = this.mvtBIBLocalBindingSource;
            this.gridLocais.Location = new System.Drawing.Point(13, 42);
            this.gridLocais.Name = "gridLocais";
            this.gridLocais.ReadOnly = true;
            this.gridLocais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLocais.Size = new System.Drawing.Size(419, 319);
            this.gridLocais.TabIndex = 2;
            this.gridLocais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocais_CellClick);
            this.gridLocais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocais_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codLocal";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricaoLocal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // mvtBIBLocalBindingSource
            // 
            this.mvtBIBLocalBindingSource.DataMember = "MvtBIBLocal";
            this.mvtBIBLocalBindingSource.DataSource = this.treinamentoDataSetCentral;
            // 
            // treinamentoDataSetCentral
            // 
            this.treinamentoDataSetCentral.DataSetName = "treinamentoDataSetCentral";
            this.treinamentoDataSetCentral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição";
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLocal.Location = new System.Drawing.Point(78, 12);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(245, 23);
            this.txtNomeLocal.TabIndex = 0;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(329, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 24);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // mvtBIBLocalTableAdapter
            // 
            this.mvtBIBLocalTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuscarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 373);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridLocais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBuscarLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Local";
            this.Load += new System.EventHandler(this.FormBuscarLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBIBLocalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetCentral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLocais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLocal;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConfirmar;
        private treinamentoDataSetCentral treinamentoDataSetCentral;
        private System.Windows.Forms.BindingSource mvtBIBLocalBindingSource;
        private treinamentoDataSetCentralTableAdapters.MvtBIBLocalTableAdapter mvtBIBLocalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}