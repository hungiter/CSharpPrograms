using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCommand
{
    class ConnectSQL
    {
        internal static SqlConnection SQLconnect()
        {
            string servername = "MY-LUV";
            string database = "DailyBanHang";

            string connectionString = "Server=" + servername + "; Database=" + database + "; Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
