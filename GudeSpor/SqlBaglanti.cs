using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GudeSpor
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=GudeSpor31;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
