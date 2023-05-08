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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

      

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            // Hasta giriş formundan TC ve Şifre bilgileri girildikten sonra giriş butonuna basıldığında bu blok çalışır
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", MskTC.Text); // SQL sorgusundaki ilk parametreye MskTC textbox'ından alınan değer atanır
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text); // SQL sorgusundaki ikinci parametreye TxtSifre textbox'ından alınan değer atanır

            SqlDataReader dr = komut.ExecuteReader(); // SQL sorgusunu çalıştırır ve geriye bir SqlDataReader nesnesi döndürür

            if (dr.Read()) // SqlDataReader nesnesinde bir satır var ise bu blok çalışır
            {
                FrmHastaDetay fr = new FrmHastaDetay(); // Yeni bir hasta detay formu oluşturulur
                fr.tcno = MskTC.Text; // Hasta detay formunun 'tcno' özelliğine, hasta giriş formundan girilen TC değeri atanır
                fr.Show(); // Hasta detay formu gösterilir
                this.Hide(); // Hasta giriş formu gizlenir
            }
            else // SqlDataReader nesnesinde satır yok ise bu blok çalışır
            {
                MessageBox.Show("Hatalı TC & Sifre "); // Hata mesajı gösterilir
            }

            bgl.baglanti().Close(); // SQL bağlantısı kapatılır
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void FrmHastaGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0); // Programın tamamen kapatılması
            }
            else
            {
                e.Cancel = true; // Formun kapanmasının engellenmesi
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmGirisler) // Ana formunuzun adı neyse o yazılabilir
                {
                    form.Show(); // Ana formun gösterilmesi
                    break;
                }
            }
            this.Hide(); // Mevcut formun gizlenmesi
        }

    }
}
