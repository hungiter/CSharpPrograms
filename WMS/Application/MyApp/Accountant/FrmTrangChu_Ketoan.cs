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
    public partial class FrmTrangChu_Ketoan : Form
    {
        SqlConnection conn;
        string user;

        public FrmTrangChu_Ketoan(string user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
            string command = "Select HovaTen From Taikhoan Where Tendangnhap = '" + user + "'";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                string name = reader.GetString(0);
                txtUsingBy.Text = "Using by: " + name;

                reader.Close();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We got some mistake in FrmTrangChu_Ketoan");
            }
        }

        private void itemNhapKho_Click(object sender, EventArgs e)
        {
            FrmNhapKho nhapKho = new FrmNhapKho(user);
            this.Hide();
            nhapKho.ShowDialog();
            this.Close();
        }

        private void itemXuatKho_Click(object sender, EventArgs e)
        {
            FrmXuatKho xuatKho = new FrmXuatKho(user);
            this.Hide();
            xuatKho.ShowDialog();
            this.Close();
        }

        private void itemTKDT_Click(object sender, EventArgs e)
        {
            FrmTKDT tkdt = new FrmTKDT(user);
            this.Hide();
            tkdt.ShowDialog();
            this.Close();
        }

        private void itemTKHH_Click(object sender, EventArgs e)
        {
            FrmTKHH tkhh = new FrmTKHH(user);
            this.Hide();
            tkhh.ShowDialog();
            this.Close();
        }

        private void itemLogout_Click(object sender, EventArgs e)
        {
            FrmLogin reload = new FrmLogin();
            this.Hide();
            reload.ShowDialog();
            this.Close();
        }
    }
}
