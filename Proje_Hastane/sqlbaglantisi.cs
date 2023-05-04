using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Sql bağlantı kütüphanesi
using System.Security.Policy;

namespace Proje_Hastane
{
    internal class sqlbaglantisi // Sınıf Adı
    {
        public SqlConnection baglanti() // Metodumun Adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=Atakan;Initial Catalog=HastaneProje;Integrated Security=True"); //Connection bağlantım
           
            baglan.Open(); //"baglan" nesnemin adı

            return baglan;

        }

    }
}
