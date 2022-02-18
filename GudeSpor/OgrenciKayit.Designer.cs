namespace GudeSpor
{
    partial class OgrenciKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOgrName = new System.Windows.Forms.TextBox();
            this.txtOgrSurname = new System.Windows.Forms.TextBox();
            this.txtBabaName = new System.Windows.Forms.TextBox();
            this.txtAnneName = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtBeden = new System.Windows.Forms.TextBox();
            this.txtAyakNo = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.mskVeliNo = new System.Windows.Forms.MaskedTextBox();
            this.mskEvTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.bransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudeSpor31DataSet = new GudeSpor.GudeSpor31DataSet();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.rdoKadin = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBabaMeslek = new System.Windows.Forms.TextBox();
            this.txtAnneMeslek = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSozlesmeSure = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAylikFiyat = new System.Windows.Forms.TextBox();
            this.lblTotalFiyat = new System.Windows.Forms.Label();
            this.bransTableAdapter = new GudeSpor.GudeSpor31DataSetTableAdapters.BransTableAdapter();
            this.txtResimEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtpara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tc No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Baba Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Anne Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Veli Telefonu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ev Telefonu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Anne Meslek";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Baba Meslek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Boy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Kilo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Beden";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 135);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ayakkabı Numarası";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 173);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Branş";
            // 
            // txtOgrName
            // 
            this.txtOgrName.Location = new System.Drawing.Point(148, 34);
            this.txtOgrName.Name = "txtOgrName";
            this.txtOgrName.Size = new System.Drawing.Size(100, 21);
            this.txtOgrName.TabIndex = 1;
            // 
            // txtOgrSurname
            // 
            this.txtOgrSurname.Location = new System.Drawing.Point(148, 61);
            this.txtOgrSurname.Name = "txtOgrSurname";
            this.txtOgrSurname.Size = new System.Drawing.Size(100, 21);
            this.txtOgrSurname.TabIndex = 1;
            // 
            // txtBabaName
            // 
            this.txtBabaName.Location = new System.Drawing.Point(113, 33);
            this.txtBabaName.Name = "txtBabaName";
            this.txtBabaName.Size = new System.Drawing.Size(100, 21);
            this.txtBabaName.TabIndex = 1;
            // 
            // txtAnneName
            // 
            this.txtAnneName.Location = new System.Drawing.Point(113, 69);
            this.txtAnneName.Name = "txtAnneName";
            this.txtAnneName.Size = new System.Drawing.Size(100, 21);
            this.txtAnneName.TabIndex = 1;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(353, 34);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 21);
            this.txtBoy.TabIndex = 1;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(353, 66);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 21);
            this.txtKilo.TabIndex = 1;
            // 
            // txtBeden
            // 
            this.txtBeden.Location = new System.Drawing.Point(353, 98);
            this.txtBeden.Name = "txtBeden";
            this.txtBeden.Size = new System.Drawing.Size(100, 21);
            this.txtBeden.TabIndex = 1;
            // 
            // txtAyakNo
            // 
            this.txtAyakNo.Location = new System.Drawing.Point(423, 135);
            this.txtAyakNo.Name = "txtAyakNo";
            this.txtAyakNo.Size = new System.Drawing.Size(100, 21);
            this.txtAyakNo.TabIndex = 1;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(148, 95);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(100, 21);
            this.mskTc.TabIndex = 2;
            // 
            // mskOgrTel
            // 
            this.mskOgrTel.Location = new System.Drawing.Point(148, 167);
            this.mskOgrTel.Mask = "(999) 000-0000";
            this.mskOgrTel.Name = "mskOgrTel";
            this.mskOgrTel.Size = new System.Drawing.Size(100, 21);
            this.mskOgrTel.TabIndex = 2;
            // 
            // mskVeliNo
            // 
            this.mskVeliNo.Location = new System.Drawing.Point(113, 105);
            this.mskVeliNo.Mask = "(999) 000-0000";
            this.mskVeliNo.Name = "mskVeliNo";
            this.mskVeliNo.Size = new System.Drawing.Size(100, 21);
            this.mskVeliNo.TabIndex = 2;
            // 
            // mskEvTel
            // 
            this.mskEvTel.Location = new System.Drawing.Point(384, 105);
            this.mskEvTel.Mask = "(999) 000-0000";
            this.mskEvTel.Name = "mskEvTel";
            this.mskEvTel.Size = new System.Drawing.Size(100, 21);
            this.mskEvTel.TabIndex = 2;
            // 
            // cmbBrans
            // 
            this.cmbBrans.DataSource = this.bransBindingSource;
            this.cmbBrans.DisplayMember = "BransAd";
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(353, 170);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 23);
            this.cmbBrans.TabIndex = 3;
            this.cmbBrans.ValueMember = "BransAd";
            // 
            // bransBindingSource
            // 
            this.bransBindingSource.DataMember = "Brans";
            this.bransBindingSource.DataSource = this.gudeSpor31DataSet;
            // 
            // gudeSpor31DataSet
            // 
            this.gudeSpor31DataSet.DataSetName = "GudeSpor31DataSet";
            this.gudeSpor31DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(81, 204);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(61, 19);
            this.rdoErkek.TabIndex = 4;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // rdoKadin
            // 
            this.rdoKadin.AutoSize = true;
            this.rdoKadin.Location = new System.Drawing.Point(148, 204);
            this.rdoKadin.Name = "rdoKadin";
            this.rdoKadin.Size = new System.Drawing.Size(62, 19);
            this.rdoKadin.TabIndex = 5;
            this.rdoKadin.TabStop = true;
            this.rdoKadin.Text = "Kadın";
            this.rdoKadin.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 135);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Doğum Tarihi";
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Location = new System.Drawing.Point(148, 132);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.Size = new System.Drawing.Size(100, 21);
            this.mskDogumTarihi.TabIndex = 6;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.mskDogumTarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoKadin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoErkek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbBrans);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.mskOgrTel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAyakNo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtBeden);
            this.groupBox1.Controls.Add(this.txtOgrName);
            this.groupBox1.Controls.Add(this.txtKilo);
            this.groupBox1.Controls.Add(this.txtOgrSurname);
            this.groupBox1.Controls.Add(this.txtBoy);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 295);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(334, 199);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(196, 80);
            this.txtAdres.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(278, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 7;
            this.label20.Text = "Adres";
            // 
            // txtBabaMeslek
            // 
            this.txtBabaMeslek.Location = new System.Drawing.Point(384, 30);
            this.txtBabaMeslek.Name = "txtBabaMeslek";
            this.txtBabaMeslek.Size = new System.Drawing.Size(100, 21);
            this.txtBabaMeslek.TabIndex = 1;
            // 
            // txtAnneMeslek
            // 
            this.txtAnneMeslek.Location = new System.Drawing.Point(384, 66);
            this.txtAnneMeslek.Name = "txtAnneMeslek";
            this.txtAnneMeslek.Size = new System.Drawing.Size(100, 21);
            this.txtAnneMeslek.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskEvTel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mskVeliNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAnneName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAnneMeslek);
            this.groupBox2.Controls.Add(this.txtBabaName);
            this.groupBox2.Controls.Add(this.txtBabaMeslek);
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veli Bilgi";
            // 
            // button1
            // 
            this.button1.Image = global::GudeSpor.Properties.Resources.pngwing_com__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(445, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 78);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(566, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 178);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(322, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Sözleşme Süresi";
            // 
            // txtSozlesmeSure
            // 
            this.txtSozlesmeSure.Location = new System.Drawing.Point(325, 506);
            this.txtSozlesmeSure.Name = "txtSozlesmeSure";
            this.txtSozlesmeSure.Size = new System.Drawing.Size(100, 21);
            this.txtSozlesmeSure.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(328, 541);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 15);
            this.label19.TabIndex = 13;
            this.label19.Text = "Aylık Fiyat";
            // 
            // txtAylikFiyat
            // 
            this.txtAylikFiyat.Location = new System.Drawing.Point(325, 559);
            this.txtAylikFiyat.Name = "txtAylikFiyat";
            this.txtAylikFiyat.Size = new System.Drawing.Size(100, 21);
            this.txtAylikFiyat.TabIndex = 14;
            // 
            // lblTotalFiyat
            // 
            this.lblTotalFiyat.AutoSize = true;
            this.lblTotalFiyat.Location = new System.Drawing.Point(356, 593);
            this.lblTotalFiyat.Name = "lblTotalFiyat";
            this.lblTotalFiyat.Size = new System.Drawing.Size(69, 15);
            this.lblTotalFiyat.TabIndex = 15;
            this.lblTotalFiyat.Text = "TotalFiyat";
            // 
            // bransTableAdapter
            // 
            this.bransTableAdapter.ClearBeforeFill = true;
            // 
            // txtResimEkle
            // 
            this.txtResimEkle.Location = new System.Drawing.Point(598, 202);
            this.txtResimEkle.Name = "txtResimEkle";
            this.txtResimEkle.Size = new System.Drawing.Size(91, 23);
            this.txtResimEkle.TabIndex = 16;
            this.txtResimEkle.Text = "Resim Ekle";
            this.txtResimEkle.UseVisualStyleBackColor = true;
            this.txtResimEkle.Click += new System.EventHandler(this.txtResimEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(325, 617);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(100, 21);
            this.txtpara.TabIndex = 17;
            this.txtpara.Visible = false;
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 706);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.txtResimEkle);
            this.Controls.Add(this.lblTotalFiyat);
            this.Controls.Add(this.txtAylikFiyat);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSozlesmeSure);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OgrenciKayit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudeSpor31DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOgrName;
        private System.Windows.Forms.TextBox txtOgrSurname;
        private System.Windows.Forms.TextBox txtBabaName;
        private System.Windows.Forms.TextBox txtAnneName;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtBeden;
        private System.Windows.Forms.TextBox txtAyakNo;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskOgrTel;
        private System.Windows.Forms.MaskedTextBox mskVeliNo;
        private System.Windows.Forms.MaskedTextBox mskEvTel;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.RadioButton rdoKadin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBabaMeslek;
        private System.Windows.Forms.TextBox txtAnneMeslek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSozlesmeSure;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAylikFiyat;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label20;
        private GudeSpor31DataSet gudeSpor31DataSet;
        private System.Windows.Forms.BindingSource bransBindingSource;
        private GudeSpor31DataSetTableAdapters.BransTableAdapter bransTableAdapter;
        private System.Windows.Forms.Button txtResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTotalFiyat;
        private System.Windows.Forms.TextBox txtpara;
    }
}

