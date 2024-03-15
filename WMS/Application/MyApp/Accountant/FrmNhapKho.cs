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
    public partial class FrmNhapKho : Form
    {
        SqlConnection conn;
        string user;
        string billid = "";
        public FrmNhapKho(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
            loadProduct();
            loadHistory();

            initPage();
        }
        // ADDITIONAL FUNCTION
        private void initPage()
        {
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
            btnShow.Enabled = false;

            updateList.Refresh();
            updateConfirm.Visible = false;

            for(int i = 0; i < productList.RowCount; i++)
            {
                productList.Rows[i].Cells[4].Value = "0";
            }

            productList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            historyList.SelectionMode = DataGridViewSelectionMode.CellSelect;

            productList.Rows[0].Cells[0].Selected = true;
            historyList.Rows[0].Cells[0].Selected = true;
        }

        private void reloadPage()
        {
            FrmNhapKho reload = new FrmNhapKho(user);
            this.Hide();
            reload.ShowDialog();
            this.Close();
        }

        // DATAGRIDVIEW LOAD
        private void loadProduct()
        {
            try
            {
                conn.Open();

                string command = "SELECT MaHang [Product ID], TenMatHang [Product's name], TonKho [Inventory], Cast(GiaNhap as bigint) [I.Price (k)] FROM HangHoa";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                productList.DataSource = dt;
                productList.Columns.Add("Column", "Add...");

                productList.Columns[0].Width = 125;
                productList.Columns[2].Width = 100;
                productList.Columns[3].Width = 100;
                productList.Columns[4].Width = 100;

                productList.Columns[0].ReadOnly = true;

                productList.Columns[1].ReadOnly = true;

                productList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[2].ReadOnly = true;

                productList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[3].ReadOnly = true;


                for (int i = 0; i < productList.ColumnCount; i++)
                {
                    productList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                productList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productList.ClearSelection();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Code error, check loadProduct()");
                reloadPage();
            }
        }

        private void loadHistory()
        {
            try
            {
                conn.Open();
                string command = "";
                command += "Select NK.SoPhieu [Bill ID], Sum(Cast((HH.GiaNhap*NK.SoLuong) as bigint))[Paid (k)], NK.NgayNhapKho [Imported At], TK.HovaTen [Entered By] ";
                command += "From PhieuNhapKho NK ";
                command += "Left join HangHoa HH On HH.MaHang = NK.MaHangHoa ";
                command += "Left join TaiKhoan TK On TK.ID_Taikhoan = NK.IDNguoiNhap ";
                command += "Group by NK.SoPhieu,NK.NgayNhapKho,TK.HovaTen Order by NK.NgayNhapKho DESC";

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                historyList.DataSource = dt;

                historyList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                historyList.Columns[0].ReadOnly = true;

                historyList.Columns[1].ReadOnly = true;

                historyList.Columns[2].ReadOnly = true;
                historyList.Columns[2].DefaultCellStyle.Format = "MMM dd yyy";

                historyList.Columns[3].ReadOnly = true;

                historyList.ClearSelection();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Code error, check loadHistory()");
                reloadPage();
            }
        }

        private void loadUpdateForm(int row)
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product ID", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Product Name", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Import Price", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Import", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Unit", typeof(String));
            dt.Columns.Add(dc);

            int i = 0;

            for (int j = 0; j < productList.RowCount & i<row; j++)
            {
                string id = productList.Rows[j].Cells[0].Value.ToString();
                string name = productList.Rows[j].Cells[1].Value.ToString();
                string price = productList.Rows[j].Cells[3].Value.ToString();
                string add = productList.Rows[j].Cells[4].Value.ToString();
                
                
                if (int.Parse(add) > 0)
                {
                    DataRow dr = dt.NewRow();
                    
                    dr["Product ID"] = id;
                    dr["Product Name"] = name;
                    dr["Import Price"] = price;
                    dr["Import"] = add;

                    try
                    {
                        conn.Open();
                        string command = "Select DonVi From HangHoa Where MaHang = '"+id+"'";
                        SqlCommand cmd = new SqlCommand(command, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        dr["Unit"] = reader.GetString(0);
                        reader.Close();
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    dt.Rows.InsertAt(dr,i);
                    i++;
                }
            }
            updateList.DataSource = dt;

            updateList.Columns[0].Width = 100;

            updateList.Columns[2].Width = 100;
            updateList.Columns[3].Width = 100;
            updateList.Columns[4].Width = 100;

            updateList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            updateList.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            updateList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            updateList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            updateList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            updateList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            updateList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            updateList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            updateList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            updateList.ClearSelection();
            if (updateList.RowCount > 0)
            {
                updateList.Rows[0].Cells[0].Selected = true;
            }
        }
        // DATAGRIDVIEW CELL CLICK
        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = productList.SelectedCells[0].RowIndex;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Rows[rowindex].Selected = true;

            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
            btnShow.Enabled = false;


            historyList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            historyList.Rows[0].Cells[0].Selected = true;
        }

        private void historyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = historyList.SelectedCells[0].RowIndex;
            historyList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyList.Rows[rowindex].Selected = true;
            billid = historyList.Rows[rowindex].Cells[0].Value.ToString();

            btnShow.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
            updateConfirm.Visible = false;

            productList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productList.Rows[0].Cells[0].Selected = true;
        }

        // BUTTON CLICK
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowcount = 0;
            for(int i = 0; i < productList.RowCount; i++)
            {
                string testcase = "";

                if (productList.Rows[i].Cells[4].Value == null)
                {
                    productList.Rows[i].Cells[4].Value = "0";
                }

                if (productList.Rows[i].Cells[4].Value.ToString().Trim().Length != 0)
                {
                    testcase = productList.Rows[i].Cells[4].Value.ToString().Trim();
                    // "ab87":false; "87":true
                    if (int.TryParse(testcase,out int value))
                    {
                        if (int.Parse(testcase) > 0) { 
                            rowcount += 1;
                        }
                        else if(int.Parse(testcase) < 0)
                        {
                            notifyWrongValue2.ShowBalloonTip(50);
                            return;
                        }
                        else { }
                    }
                    else
                    {
                        notifyWrongValue1.ShowBalloonTip(50);
                        return;
                    }
                }
            }

            if (rowcount == 0)
            {
                MessageBox.Show("Nothing to change");
                return;
            }
            else {
                loadUpdateForm(rowcount);
                updateConfirm.Visible = true;
                btnUpdate.Enabled = false;
                btnClear.Enabled = false;
            }


        }

        private void acceptUpdate_Click(object sender, EventArgs e)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader reader;
            string sophieu,userid;
            try
            {
                conn.Open();

                // Create bill id
                command = "exec dbo.taoPhieuNhapKho";
                cmd = new SqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                reader.Read();

                sophieu = reader.GetString(0);

                reader.Close();
                // Get user id
                command = "Select Id_Taikhoan From Taikhoan Where Tendangnhap = '"+user+"'";
                cmd = new SqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                reader.Read();

                userid = reader.GetString(0);

                reader.Close();
                // Add objects to bill

                for (int i = 0; i < updateList.RowCount; i++)
                {
                    string mahanghoa = updateList.Rows[i].Cells[0].Value.ToString();
                    Int64 soluong = Int64.Parse(updateList.Rows[i].Cells[3].Value.ToString());

                    command = "Exec dbo.themPhieuNhapKho '"+sophieu+"','"+mahanghoa+"',"+soluong+",'"+ userid + "'";
                    cmd = new SqlCommand(command, conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            // Reload
            productList.Columns.RemoveAt(4);
            loadProduct();
            loadHistory();

            for(int i=0; i < historyList.RowCount; i++)
            {
                if (historyList.Rows[i].Cells[0].Value.ToString().Equals(sophieu))
                {
                    historyList.Rows[i].Cells[0].Selected = true;
                    break;
                }
            }

            notifyUpdateSucces.ShowBalloonTip(50);
            initPage();
        }

        private void rejectUpdate_Click(object sender, EventArgs e)
        {
            updateList.Refresh();
            updateConfirm.Visible = false;

            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;


            productList.ClearSelection();

            for (int i = 0; i < productList.RowCount; i++)
            {
                productList.Rows[i].Cells[4].Value = "0";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmTrangChu_Ketoan back = new FrmTrangChu_Ketoan(user);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ImportInfo print = new ImportInfo(billid, conn);
            print.ShowDialog();
        }
    }
}
