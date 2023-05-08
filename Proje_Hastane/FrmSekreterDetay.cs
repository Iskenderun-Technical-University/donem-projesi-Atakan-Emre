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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;
        
        sqlbaglantisi bgl = new sqlbaglantisi();


        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;
            
            //Ad SoyAd Alma
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter Where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();    

            }
            bgl.baglanti().Close();

            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Doktorlar Datagride Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' +  DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            //Branşları Comboboxa dahil etme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4) ", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluştururdu.");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komutbrans = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komutbrans.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr = komutbrans.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1",RchDuyuru.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");

        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmrandevu = new FrmRandevuListesi();
            frmrandevu.Show();
        }

        private void BtnDuyurlar_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
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

        private void FrmSekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);//Uygulama Tamamen Kapanır
            }
        }
    }
}
