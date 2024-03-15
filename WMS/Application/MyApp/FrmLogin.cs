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

namespace AppCommand
{
    public partial class FrmLogin : Form
    {
        SqlConnection conn;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            notifyLoginFail1.Visible = false;
            notifyLoginFail2.Visible = false;
            notifyLoginFail3.Visible = false;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            notifyLoginFail1.Visible = false;
            notifyLoginFail2.Visible = false;
            notifyLoginFail3.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;

            string command = "Exec dbo.loginResult '" + user + "','" + pass + "'";
            if(user.Trim().Length==0 || pass.Trim().Length == 0)
            {
                notifyLoginFail1.Visible = true;
                notifyLoginFail1.ShowBalloonTip(100);
            }else if(pass.Length < 6)
            {
                notifyLoginFail2.Visible = false;
                notifyLoginFail2.ShowBalloonTip(100);
            }
            else
            {
                SqlCommand cmd = new SqlCommand(command, conn);
                loginProcess(cmd, user);
            }
        }

        public void loginProcess(SqlCommand cmd,String user)
        {
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string result = reader.GetString(0);

                if (result.Contains("Hợp lệ"))
                {
                    string[] splitResult = result.Split(',');
                    string vaitro = splitResult[1];

                    notifyLoginSuccess.BalloonTipText += " " + user;
                    notifyLoginSuccess.ShowBalloonTip(50);

                    if (vaitro.Equals("Đại lý"))
                    {
                        reader.Close();
                        conn.Close();
                        movetoAgentForm(user);
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        movetoAccountantForm(user);
                    }
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    notifyLoginFail3.Visible = true;
                    notifyLoginFail3.ShowBalloonTip(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void movetoAgentForm(string user)
        {
            // Demo daily01 / daily123
            FrmTrangChu_Daily go = new FrmTrangChu_Daily(user);
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        public void movetoAccountantForm(string user)
        {
            // Demo ketoan01 / ketoan123
            FrmTrangChu_Ketoan go = new FrmTrangChu_Ketoan(user);
            this.Hide();
            go.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
