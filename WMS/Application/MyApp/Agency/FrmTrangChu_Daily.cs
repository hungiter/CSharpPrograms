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
    public partial class FrmTrangChu_Daily : Form
    {
        SqlConnection conn;
        string user;
        string userid;
        public FrmTrangChu_Daily(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmTrangChu_Daily_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
            initPage();
        }
        private void initPage()
        {
            string command = "Select Id_Taikhoan,HovaTen,SoDienThoai,DiaChi From Taikhoan Where Tendangnhap = '" + user + "'";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                userid = reader.GetString(0);
                txtID.Text = "ID: " + userid;
                txtName.Text = "Name: " + reader.GetString(1);
                txtPhone.Text = "Phoneno: " + reader.GetString(2);
                txtAdd.Text = "Address: " + reader.GetString(3);


                reader.Close();

                loadPending();
                loadShipped();
                loadHistory();

                pendingPanel.Visible = true;
                shippedPanel.Visible = false;
                historyPanel.Visible = false;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We got some mistake in FrmTrangChu_Daily");
            }
        }
        
        private void loadPending()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='on pending'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataPending.DataSource = dt;

                dataPending.Columns[0].Width = 125;
                dataPending.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataPending.Columns[2].Width = 150;

                dataPending.Rows[0].Cells[0].Selected = true;
            }
            else
            {}
        }

        private void loadShipped()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='On being shipped'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataShipped.DataSource = dt;

                dataShipped.Columns[0].Width = 125;
                dataShipped.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataShipped.Columns[2].Width = 150;

                dataShipped.Rows[0].Cells[0].Selected = true;
            }
            else
            { }
        }

        private void loadHistory()
        {
            string command = "Select SoPhieu [Order ID],NgayDatHang  [Order date],NgayNhanHang [Paid on],PT_ThanhToan [Payment Method] ";
            command += "From PhieuDatHang ";
            command += "Where ID_NguoiDat = '" + userid + "' and TrangThai ='Have arrived'";

            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataHistory.DataSource = dt;

                dataHistory.Columns[0].Width = 125;
                dataHistory.Columns[1].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataHistory.Columns[2].DefaultCellStyle.Format = "MMM dd  yyyy";
                dataHistory.Columns[3].Width = 150;

                dataHistory.Rows[0].Cells[0].Selected = true;
            }
            else
            { }
        }

        private void reloadTable()
        {
            try
            {
                DataTable dt = new DataTable();
                dataPending.DataSource = dt;
                dataShipped.DataSource = dt;
                dataHistory.DataSource = dt;

                loadPending();
                loadShipped();
                loadHistory();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            btnPending.BackColor = Color.FromArgb(128, 128, 255);
            btnPending.ForeColor = Color.White;

            btnShipped.BackColor = Color.FromArgb(224, 224, 224);
            btnShipped.ForeColor = Color.Black;
            btnHistory.BackColor = Color.FromArgb(224, 224, 224);
            btnHistory.ForeColor = Color.Black;

            if (dataShipped.RowCount > 0)
            {
                dataShipped.Rows[0].Cells[0].Selected = true;
            }
            if (dataHistory.RowCount > 0)
            {
                dataHistory.Rows[0].Cells[0].Selected = true;
            }

            pendingPanel.Visible = true;
            shippedPanel.Visible = false;
            historyPanel.Visible = false;
        }

        private void btnShipped_Click(object sender, EventArgs e)
        {
            btnShipped.BackColor = Color.FromArgb(128, 128, 255);
            btnShipped.ForeColor = Color.White;

            btnPending.BackColor = Color.FromArgb(224, 224, 224);
            btnPending.ForeColor = Color.Black;
            btnHistory.BackColor = Color.FromArgb(224, 224, 224);
            btnHistory.ForeColor = Color.Black;

            if (dataPending.RowCount > 0)
            {
                dataPending.Rows[0].Cells[0].Selected = true;
            }
            if (dataHistory.RowCount > 0)
            {
                dataHistory.Rows[0].Cells[0].Selected = true;
            }

            pendingPanel.Visible = false;
            shippedPanel.Visible = true;
            historyPanel.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(128, 128, 255);
            btnHistory.ForeColor = Color.White;

            btnPending.BackColor = Color.FromArgb(224, 224, 224);
            btnPending.ForeColor = Color.Black;
            btnShipped.BackColor = Color.FromArgb(224, 224, 224);
            btnShipped.ForeColor = Color.Black;

            if (dataPending.RowCount > 0)
            {
                dataPending.Rows[0].Cells[0].Selected = true;
            }
            if (dataShipped.RowCount > 0)
            {
                dataShipped.Rows[0].Cells[0].Selected = true;
            }

            pendingPanel.Visible = false;
            shippedPanel.Visible = false;
            historyPanel.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin back = new FrmLogin();
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order order = new Order(userid);
            order.ShowDialog();
            try
            {
                conn.Open();
                loadPending();
                loadShipped();
                loadHistory();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("We got some mistake in FrmTrangChu_Daily");
            }
        }

        private void dataShipped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataShipped.SelectedRows[0].Index;
            string id = dataShipped.Rows[index].Cells[0].Value.ToString();

            Confirm cfm = new Confirm(id);
            cfm.ShowDialog();
            reloadTable();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadTable();
        }
    }
}
