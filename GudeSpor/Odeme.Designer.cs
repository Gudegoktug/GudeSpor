namespace GudeSpor
{
    partial class Odeme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudeSpor31DataSet1 = new GudeSpor.GudeSpor31DataSet1();
            this.ogrenciTableAdapter = new GudeSpor.GudeSpor31DataSet1TableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdenecekTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuncelBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTelDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            this.ogrIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTelDataGridViewTextBoxColumn
            // 
            this.ogrTelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrTelDataGridViewTextBoxColumn.DataPropertyName = "OgrTel";
            this.ogrTelDataGridViewTextBoxColumn.HeaderText = "OgrTel";
            this.ogrTelDataGridViewTextBoxColumn.Name = "ogrTelDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.gudeSpor31DataSet1;
            // 
            // gudeSpor31DataSet1
            // 
            this.gudeSpor31DataSet1.DataSetName = "GudeSpor31DataSet1";
            this.gudeSpor31DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Id";
            // 
            // txtOgrId
            // 
            this.txtOgrId.Location = new System.Drawing.Point(15, 26);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(161, 20);
            this.txtOgrId.TabIndex = 2;
            // 
            // btnOde
            // 
            this.btnOde.ContextMenuStrip = this.contextMenuStrip1;
            this.btnOde.Location = new System.Drawing.Point(15, 190);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(75, 44);
            this.btnOde.TabIndex = 3;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ödenecek Tutar";
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.Location = new System.Drawing.Point(15, 152);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(161, 20);
            this.txtOdenecekTutar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncel Borç";
            // 
            // txtGuncelBorc
            // 
            this.txtGuncelBorc.Location = new System.Drawing.Point(15, 111);
            this.txtGuncelBorc.Name = "txtGuncelBorc";
            this.txtGuncelBorc.Size = new System.Drawing.Size(161, 20);
            this.txtGuncelBorc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci İsim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 20);
            this.txtName.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 247);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGuncelBorc);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtOgrId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GudeSpor31DataSet1 gudeSpor31DataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private GudeSpor31DataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdenecekTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuncelBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
    }
}