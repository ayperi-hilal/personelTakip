using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    class veriTabani
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = 192.168.1.203; Network Library = DBMSSOCN; Initial Catalog = personelTakipOtomasyonu; User ID = cogurcu; Password = deneme;");
            baglan.Open();
            return baglan;

        }
       
    }
}
