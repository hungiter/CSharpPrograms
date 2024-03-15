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
    public partial class FrmTKHH : Form
    {
        SqlConnection conn;
        string user;
        string loadstatus = "onload";
        string[] productid = { };
        string[] productname = { };

        public FrmTKHH(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmTKHH_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
            initPage();
        }


        private void initPage()
        {
            comboMonth.SelectedIndex = 0;
            comboYear.SelectedIndex = 0;
            try
            {
                conn.Open();
                string prod = "Select MaHang,TenMatHang From HangHoa";
                SqlCommand cmd = new SqlCommand(prod, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                List<string> tmpid = new List<string>();
                List<string> tmpname = new List<string>();
                while (rd.Read())
                {
                    tmpid.Add(rd.GetString(0));
                    tmpname.Add(rd.GetString(1));
                }
                rd.Close();
                productid = tmpid.ToArray();
                productname = tmpname.ToArray();

                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            loadAll(2020);

            loadstatus = "Finish";
        }

        private void loadTable(int month,int year)
        {
            string inout = "";
            SqlCommand cmd;
            SqlDataReader read;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product's ID");
            dt.Columns.Add(dc);
            dc = new DataColumn("Product's Name");
            dt.Columns.Add(dc);
            dc = new DataColumn("Out");
            dt.Columns.Add(dc);
            dc = new DataColumn("In");
            dt.Columns.Add(dc);
            try
            {
                conn.Open();

                for (int i = 0; i < productid.Length; i++)
                {
                    inout += "Exec dbo.thongkeHangHoaRaVao '"+productid[i]+"',"+month+","+year;

                    cmd = new SqlCommand(inout, conn);

                    string proIn = "0", proOut = "0";

                    cmd = new SqlCommand(inout, conn);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        proOut = read.GetInt32(0).ToString();
                        proIn = read.GetInt32(1).ToString();
                    }
                    read.Close();

                    DataRow dr = dt.NewRow();
                    dr["Product's ID"] = productid[i];
                    dr["Product's Name"] = productname[i];
                    dr["Out"] = proOut;
                    dr["In"] = proIn;
                    dt.Rows.Add(dr);

                    inout = "";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                productStatisticTable.DataSource = dt;

                productStatisticTable.Columns[0].Width = 125;
                productStatisticTable.Columns[2].Width = 100;
                productStatisticTable.Columns[3].Width = 100;

                productStatisticTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                productStatisticTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


                productStatisticTable.Rows[0].Cells[0].Selected = true;
            }
            else
            {
                dt = new DataTable();
                productStatisticTable.DataSource = dt;
            }
        }

        private void loadAll(int year)
        {
            string inout = "";
            SqlCommand cmd;
            SqlDataReader read;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product's ID");
            dt.Columns.Add(dc);
            dc = new DataColumn("Product's Name");
            dt.Columns.Add(dc);
            dc = new DataColumn("Out");
            dt.Columns.Add(dc);
            dc = new DataColumn("In");
            dt.Columns.Add(dc);
            try
            {
                conn.Open();

                for (int i = 0; i < productid.Length; i++)
                {
                    int proIn = 0, proOut = 0;
                    for (int m = 1; m <= 12; m++)
                    {
                        inout += "Exec dbo.thongkeHangHoaRaVao '" + productid[i] + "'," + m + "," + year;
                        cmd = new SqlCommand(inout, conn);
                        cmd = new SqlCommand(inout, conn);
                        read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            proOut += read.GetInt32(0);
                            proIn += read.GetInt32(1);
                        }
                        read.Close();
                        inout = "";

                    }

                    DataRow dr = dt.NewRow();
                    dr["Product's ID"] = productid[i];
                    dr["Product's Name"] = productname[i];
                    dr["Out"] = proOut+"";
                    dr["In"] = proIn+"";
                    dt.Rows.Add(dr);

                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                productStatisticTable.DataSource = dt;

                productStatisticTable.Columns[0].Width = 125;
                productStatisticTable.Columns[2].Width = 100;
                productStatisticTable.Columns[3].Width = 100;

                productStatisticTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                productStatisticTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

                productStatisticTable.Rows[0].Cells[0].Selected = true;
            }
            else
            {
                dt = new DataTable();
                productStatisticTable.DataSource = dt;
            }
        }

        private void reloadProductInOut()
        {
            int month = 0;
            int year = 0;
            month = comboMonth.SelectedItem.ToString().Equals("All")?0:int.Parse(comboMonth.SelectedItem.ToString());
            year = int.Parse(comboYear.SelectedItem.ToString());
            if(month == 0)
            {
                loadAll(year);
            }
            else
            {
                loadTable(month, year);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmTrangChu_Ketoan back = new FrmTrangChu_Ketoan(user);
            this.Hide();
            back.ShowDialog();
            this.Close();
            
        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadstatus.Equals("Finish")) {
                reloadProductInOut();
            }         
        }
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadstatus.Equals("Finish"))
            {
                reloadProductInOut();
            }
        }
    }
}
