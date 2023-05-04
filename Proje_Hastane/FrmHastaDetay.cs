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

namespace Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tcno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void tc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad verilerini almak için
            LblTC.Text = tcno;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSıyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter ( "Select * From Tbl_Randevular where HastaTC=" + tcno, bgl.baglanti() );
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Alma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans = @p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans = ' " + CmbBrans.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
           fr.TCno= LblTC.Text;
            fr.Show();

        }
    }
}
