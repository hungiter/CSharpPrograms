using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCommand
{
    public partial class Confirm : Form
    {
        string id;
        SqlConnection conn;
        public Confirm(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Confirm_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string command = "exec nhanduocHang '" + id + "'";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                read.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
