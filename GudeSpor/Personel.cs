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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti(); 
        private void Personel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeSpor31DataSet3.Brans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransTableAdapter.Fill(this.gudeSpor31DataSet3.Brans);
            // TODO: Bu kod satırı 'gudeSpor31DataSet2.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.gudeSpor31DataSet2.Personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string name,id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            name = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPName.Text = name;
            txtPersonalId.Text = id;
        }

        private void btnPKayit_Click(object sender, EventArgs e)
        {
            try
            {
                //Personel Kayıt
                SqlCommand kayit = new SqlCommand("insert into Personel (PAd,PSoyad,PBrans,PTel,PAdres) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                kayit.Parameters.AddWithValue("@p1", txtPName.Text);
                kayit.Parameters.AddWithValue("@p2", txtPSurname.Text);
                kayit.Parameters.AddWithValue("@p3", cmbBrans.Text);
                kayit.Parameters.AddWithValue("@p4", mskPTel.Text);
                kayit.Parameters.AddWithValue("@p5", txtPAdres.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
                this.personelTableAdapter.Fill(this.gudeSpor31DataSet2.Personel);
                bgl.baglanti().Close();
            }
            catch 
            {
                MessageBox.Show("HATA..!!!");

            }
       

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Personel Id'den silme
                SqlCommand kayit = new SqlCommand("delete Personel where PId=@s1", bgl.baglanti());
                kayit.Parameters.AddWithValue(("@s1"), (txtPersonalId.Text));
                kayit.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.gudeSpor31DataSet2.Personel);
                bgl.baglanti().Close();
                MessageBox.Show("Silindi");
            }
            catch 
            {
                MessageBox.Show("HATA!!!");
            }
        }

      
    }
}
