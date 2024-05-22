using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.Class
{
    internal class functions
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void ketnoi()
        {
            connstring = "Data Source=DESKTOP-FI0IVCS;Initial Catalog=QLMP;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connstring);
            conn.ConnectionString = connstring;
            conn.Open();
            MessageBox.Show("Ket noi thanh cong");
        }
       
    }
}
