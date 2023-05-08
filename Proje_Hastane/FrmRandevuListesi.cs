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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Değişikliğin yapıldığı satırın ID değerini alın
            int randevuId = (int)dataGridView1.Rows[e.RowIndex].Cells["Randevuid"].Value;

            // Değiştirilen hücrenin adını alın
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            // Değiştirilen hücrenin yeni değerini alın
            string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            // SqlCommand nesnesi oluşturun
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Randevular SET " + columnName + "=@value WHERE Randevuid=@id", bgl.baglanti());
            cmd.Parameters.AddWithValue("@value", newValue);
            cmd.Parameters.AddWithValue("@id", randevuId);
            cmd.ExecuteNonQuery();

            // DataGridView'in DataSource özelliğini yeniden yükleyin
            LoadData();
        }
    }
}
