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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Odeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeSpor31DataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.gudeSpor31DataSet1.Ogrenci);

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            //ogrenci borcu gösterme ve ödeme
            int odenen, kalan,guncel;
            odenen = Convert.ToInt32(txtOdenecekTutar.Text);
            kalan = Convert.ToInt32(txtGuncelBorc.Text);
            MessageBox.Show(odenen + " TL\t \t" + "\n" + "Ödemeyi onaylıyor musunuz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            guncel = kalan - odenen;
            txtGuncelBorc.Text = guncel.ToString();
            //odeme yapma
            SqlCommand ode = new SqlCommand("update Ogrenci set Ucret=@p1 where OgrId=@p2", bgl.baglanti());
            ode.Parameters.AddWithValue("@p2", txtOgrId.Text);
            ode.Parameters.AddWithValue("@p1", (guncel)).ToString();
            ode.ExecuteNonQuery();
            this.ogrenciTableAdapter.Fill(this.gudeSpor31DataSet1.Ogrenci);
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview tek tık ile value seçimi ve belirtilen araçlara atama
            int secilen;
            string id, kalan,ad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtOgrId.Text = id;
            txtGuncelBorc.Text = kalan;
            txtName.Text = ad;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
