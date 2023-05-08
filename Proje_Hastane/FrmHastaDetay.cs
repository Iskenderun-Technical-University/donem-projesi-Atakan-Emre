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


            if (dr3.HasRows) // Satır sayısı 0'dan büyük ise
            {
                while (dr3.Read())
                {
                    CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
                }
                CmbDoktor.SelectedIndex = 0;
            }
            else // Satır sayısı 0 ise
            {
                MessageBox.Show("Bu branşta henüz doktor eklenmemiş!");
                CmbDoktor.Text = "";
            }
            bgl.baglanti().Close();
        }

      

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans = '" + CmbBrans.Text + "'" + " and RandevuDoktor='" + CmbDoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
           fr.TCno= LblTC.Text;
            fr.Show();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            // Randevu bilgilerini güncellemek için SQL sorgusu hazırlanıyor
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 Where Randevuid=@p3", bgl.baglanti());
            // Parametreler atanıyor
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            // Sorgu çalıştırılıyor
            komut.ExecuteNonQuery();
            // Veritabanı bağlantısı kapatılıyor
            bgl.baglanti().Close();

            // Bilgilendirme mesajı gösteriliyor
            MessageBox.Show("Randevu Alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Aktif Randevular
            // Yeni bir DataTable oluşturuluyor
            DataTable dtAktifRandevu = new DataTable();
            // Veritabanından aktif randevuların bilgilerini getiren SqlDataAdapter hazırlanıyor
            SqlDataAdapter daAktifRandevu = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tcno + " and RandevuDurum=0", bgl.baglanti());
            // Veriler DataTable'a dolduruluyor
            daAktifRandevu.Fill(dtAktifRandevu);
            // DataGridView2'nin veri kaynağı olarak DataTable atanıyor
            dataGridView2.DataSource = dtAktifRandevu;

            // Geçmiş Randevular
            // Yeni bir DataTable oluşturuluyor
            DataTable dtGecmisRandevu = new DataTable();
            // Veritabanından geçmiş randevuların bilgilerini getiren SqlDataAdapter hazırlanıyor
            SqlDataAdapter daGecmisRandevu = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tcno + " and RandevuDurum=1", bgl.baglanti());
            // Veriler DataTable'a dolduruluyor
            daGecmisRandevu.Fill(dtGecmisRandevu);
            // DataGridView1'in veri kaynağı olarak DataTable atanıyor
            dataGridView1.DataSource = dtGecmisRandevu;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text= dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisler frmGirisler = new FrmGirisler();    
            frmGirisler.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Hide(); // Tüm açık formların gizlenmesi
                }
                FrmGirisler frmAnaForm = new FrmGirisler(); // Ana formunuzun yeni bir örneğinin oluşturulması
                frmAnaForm.Show(); // Yeni formun gösterilmesi
                Application.Exit(); // Uygulamanın tamamen kapatılması
            }
        }

        private void FrmHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);//Uygulama Tamamen Kapanır
            }
        }


    }
}
