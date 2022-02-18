using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GudeSpor
{
    public partial class OgrenciKayit : Form
    {
        public int totalucret;
        public OgrenciKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            //Ogrenci Kayit
            SqlCommand kayit = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTc,OgrTel,OgrCinsiyet,OgrBabaAdi,OgrAnneAdi,OgrVeliTel,OgrEvTel,OgrAnneMeslek,OgrBabaMeslek,OgrEvAdresi,OgrBoy,OgrKilo,OgrBeden,OgrAyakNo,OgrBrans,Ucret,DogumTarihi,CreateDate) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20)",bgl.baglanti());
            kayit.Parameters.AddWithValue("@p1", txtOgrName.Text);
            kayit.Parameters.AddWithValue("@p2", txtOgrSurname.Text);
            kayit.Parameters.AddWithValue("@p3", mskTc.Text);
            kayit.Parameters.AddWithValue("@p4", mskOgrTel.Text);
            if (rdoErkek.Checked)
            {
                kayit.Parameters.AddWithValue("@p5", "Erkek");
            }
            else
            {
                kayit.Parameters.AddWithValue("@p5", "Kadın");
            }
            kayit.Parameters.AddWithValue("@p6", txtBabaName.Text);
            kayit.Parameters.AddWithValue("@p7", txtAnneName.Text);
            kayit.Parameters.AddWithValue("@p8", mskVeliNo.Text);
            kayit.Parameters.AddWithValue("@p9", mskEvTel.Text);
            kayit.Parameters.AddWithValue("@p10", txtAnneMeslek.Text);
            kayit.Parameters.AddWithValue("@p11", txtBabaMeslek.Text);
            kayit.Parameters.AddWithValue("@p12", txtAdres.Text);
            kayit.Parameters.AddWithValue("@p13", txtBoy.Text);
            kayit.Parameters.AddWithValue("@p14", txtKilo.Text);
            kayit.Parameters.AddWithValue("@p15", txtBeden.Text);
            kayit.Parameters.AddWithValue("@p16", txtAyakNo.Text);
            kayit.Parameters.AddWithValue("@p17", cmbBrans.SelectedValue).Value.ToString();
            kayit.Parameters.AddWithValue("@p18", Convert.ToInt32((txtAylikFiyat.Text))*Convert.ToInt32(txtSozlesmeSure.Text)).ToString();
            kayit.Parameters.AddWithValue("@p19", mskDogumTarihi.Text);
            kayit.Parameters.AddWithValue("@p20", DateTime.Now);
            


            kayit.ExecuteNonQuery();
            totalucret = Convert.ToInt32(txtAylikFiyat.Text) * Convert.ToInt32(txtSozlesmeSure.Text);
            lblTotalFiyat.Text = $"{totalucret} TL";
            

            bgl.baglanti().Close();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeSpor31DataSet.Brans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransTableAdapter.Fill(this.gudeSpor31DataSet.Brans);

        }

        private void txtResimEkle_Click(object sender, EventArgs e)
        {
            //resim ekleme
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
