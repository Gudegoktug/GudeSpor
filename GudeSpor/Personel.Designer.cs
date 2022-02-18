namespace GudeSpor
{
    partial class Personel
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
            this.gudeSpor31DataSet2 = new GudeSpor.GudeSpor31DataSet2();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new GudeSpor.GudeSpor31DataSet2TableAdapters.PersonelTableAdapter();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPAdres = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPSurname = new System.Windows.Forms.TextBox();
            this.mskPTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.gudeSpor31DataSet3 = new GudeSpor.GudeSpor31DataSet3();
            this.bransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bransTableAdapter = new GudeSpor.GudeSpor31DataSet3TableAdapters.BransTableAdapter();
            this.btnPKayit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pAdDataGridViewTextBoxColumn,
            this.pSoyadDataGridViewTextBoxColumn,
            this.pBransDataGridViewTextBoxColumn,
            this.pTelDataGridViewTextBoxColumn,
            this.pAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
           
            // 
            // gudeSpor31DataSet2
            // 
            this.gudeSpor31DataSet2.DataSetName = "GudeSpor31DataSet2";
            this.gudeSpor31DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.gudeSpor31DataSet2;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "PId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "PId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // pAdDataGridViewTextBoxColumn
            // 
            this.pAdDataGridViewTextBoxColumn.DataPropertyName = "PAd";
            this.pAdDataGridViewTextBoxColumn.HeaderText = "PAd";
            this.pAdDataGridViewTextBoxColumn.Name = "pAdDataGridViewTextBoxColumn";
            this.pAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pSoyadDataGridViewTextBoxColumn
            // 
            this.pSoyadDataGridViewTextBoxColumn.DataPropertyName = "PSoyad";
            this.pSoyadDataGridViewTextBoxColumn.HeaderText = "PSoyad";
            this.pSoyadDataGridViewTextBoxColumn.Name = "pSoyadDataGridViewTextBoxColumn";
            this.pSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // pBransDataGridViewTextBoxColumn
            // 
            this.pBransDataGridViewTextBoxColumn.DataPropertyName = "PBrans";
            this.pBransDataGridViewTextBoxColumn.HeaderText = "PBrans";
            this.pBransDataGridViewTextBoxColumn.Name = "pBransDataGridViewTextBoxColumn";
            this.pBransDataGridViewTextBoxColumn.Width = 125;
            // 
            // pTelDataGridViewTextBoxColumn
            // 
            this.pTelDataGridViewTextBoxColumn.DataPropertyName = "PTel";
            this.pTelDataGridViewTextBoxColumn.HeaderText = "PTel";
            this.pTelDataGridViewTextBoxColumn.Name = "pTelDataGridViewTextBoxColumn";
            this.pTelDataGridViewTextBoxColumn.Width = 150;
            // 
            // pAdresDataGridViewTextBoxColumn
            // 
            this.pAdresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAdresDataGridViewTextBoxColumn.DataPropertyName = "PAdres";
            this.pAdresDataGridViewTextBoxColumn.HeaderText = "PAdres";
            this.pAdresDataGridViewTextBoxColumn.Name = "pAdresDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Branş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Personel Telefon";
            // 
            // txtPAdres
            // 
            this.txtPAdres.Location = new System.Drawing.Point(395, 206);
            this.txtPAdres.Multiline = true;
            this.txtPAdres.Name = "txtPAdres";
            this.txtPAdres.Size = new System.Drawing.Size(204, 89);
            this.txtPAdres.TabIndex = 6;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(142, 166);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(121, 20);
            this.txtPName.TabIndex = 7;
            // 
            // txtPSurname
            // 
            this.txtPSurname.Location = new System.Drawing.Point(142, 206);
            this.txtPSurname.Name = "txtPSurname";
            this.txtPSurname.Size = new System.Drawing.Size(121, 20);
            this.txtPSurname.TabIndex = 7;
            // 
            // mskPTel
            // 
            this.mskPTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPTel.Location = new System.Drawing.Point(395, 166);
            this.mskPTel.Mask = "(999) 000-0000";
            this.mskPTel.Name = "mskPTel";
            this.mskPTel.Size = new System.Drawing.Size(113, 21);
            this.mskPTel.TabIndex = 8;
            // 
            // cmbBrans
            // 
            this.cmbBrans.DataSource = this.bransBindingSource;
            this.cmbBrans.DisplayMember = "BransAd";
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(142, 247);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 21);
            this.cmbBrans.TabIndex = 9;
            this.cmbBrans.ValueMember = "BransAd";
            // 
            // gudeSpor31DataSet3
            // 
            this.gudeSpor31DataSet3.DataSetName = "GudeSpor31DataSet3";
            this.gudeSpor31DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bransBindingSource
            // 
            this.bransBindingSource.DataMember = "Brans";
            this.bransBindingSource.DataSource = this.gudeSpor31DataSet3;
            // 
            // bransTableAdapter
            // 
            this.bransTableAdapter.ClearBeforeFill = true;
            // 
            // btnPKayit
            // 
            this.btnPKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPKayit.Image = global::GudeSpor.Properties.Resources.pngwing_com__2_;
            this.btnPKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPKayit.Location = new System.Drawing.Point(634, 154);
            this.btnPKayit.Name = "btnPKayit";
            this.btnPKayit.Size = new System.Drawing.Size(97, 77);
            this.btnPKayit.TabIndex = 10;
            this.btnPKayit.Text = "Kayıt";
            this.btnPKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPKayit.UseVisualStyleBackColor = true;
            this.btnPKayit.Click += new System.EventHandler(this.btnPKayit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::GudeSpor.Properties.Resources.pngwing_com__4_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(634, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 77);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPKayit);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.mskPTel);
            this.Controls.Add(this.txtPSurname);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GudeSpor31DataSet2 gudeSpor31DataSet2;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private GudeSpor31DataSet2TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPAdres;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPSurname;
        private System.Windows.Forms.MaskedTextBox mskPTel;
        private System.Windows.Forms.ComboBox cmbBrans;
        private GudeSpor31DataSet3 gudeSpor31DataSet3;
        private System.Windows.Forms.BindingSource bransBindingSource;
        private GudeSpor31DataSet3TableAdapters.BransTableAdapter bransTableAdapter;
        private System.Windows.Forms.Button btnPKayit;
        private System.Windows.Forms.Button button1;
    }
}