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
    public partial class FrmTKDT : Form
    {
        string user;
        SqlConnection conn;

        string loadstatus = "onload";
        public FrmTKDT(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmTKDT_Load(object sender, EventArgs e)
        {
            conn = ConnectSQL.SQLconnect();
            initPage();
        }

        private void initPage()
        {
            string[] month = { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] year = { "All", "2020", "2021", "2022" };
            comboMonth.Items.AddRange(month);
            comboYear.Items.AddRange(year);

            comboMonth.SelectedIndex = 0;
            comboYear.SelectedIndex = 0;
            loadstatus = "finish";

            allBtn.Enabled = false;
            noData.Visible = false;

            reloadStatisticTable();
        }
        
        private void loadStatisticTable()
        {
            string export = "",import = "";
            SqlCommand cmde,cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                conn.Open();
                for(int y = 2020; y <= 2022; y++)
                {
                    for (int m = 1; m <= 12; m++)
                    {
                        export += "Exec EmportByMonth " + m + "," + y;
                        import += "Exec ImportByMonth " + m + "," + y;

                        cmde = new SqlCommand(export, conn);

                        string income = "No Income", spend = "No Spend";

                        exportRead = cmde.ExecuteReader();
                        while(exportRead.Read())
                        {
                            income = exportRead.GetSqlInt64(2).ToString();
                        }
                        exportRead.Close();

                        cmdi = new SqlCommand(import, conn);
                        importRead = cmdi.ExecuteReader();
                        while(importRead.Read())
                        {
                            spend = importRead.GetSqlInt64(2).ToString();
                        }
                        importRead.Close();

                        if(!income.Equals("No Income") | !spend.Equals("No Spend"))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Month"] = m;
                            dr["Year"] = y;
                            dr["Income"] = income;
                            dr["Spend"] = spend;
                            dt.Rows.Add(dr);
                        }
                        export = "";
                        import = "";
                    }
                }
                
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                allBtn.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                allBtn.Enabled = false;
                noData.Visible = true;
            }
        }
        private void loadStatisticTable_MonthYear(int month, int year)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                conn.Open();

                export += "Exec EmportByMonth " + month + "," + year;
                import += "Exec ImportByMonth " + month + "," + year;

                cmde = new SqlCommand(export, conn);

                string income = "No Income", spend = "No Spend";

                exportRead = cmde.ExecuteReader();
                while (exportRead.Read())
                {
                    income = exportRead.GetSqlInt64(2).ToString();
                }
                exportRead.Close();

                cmdi = new SqlCommand(import, conn);
                importRead = cmdi.ExecuteReader();
                while (importRead.Read())
                {
                    spend = importRead.GetSqlInt64(2).ToString();
                }
                importRead.Close();

                if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                {
                    DataRow dr = dt.NewRow();
                    dr["Month"] = month;
                    dr["Year"] = year;
                    dr["Income"] = income;
                    dr["Spend"] = spend;
                    dt.Rows.Add(dr);
                }
                export = "";
                import = "";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                allBtn.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                allBtn.Enabled = false;
                noData.Visible = true;
            }
        }
        private void loadStatisticTable_Month(int month)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                conn.Open();
                for (int y = 2020; y <= 2022; y++)
                {
                    export += "Exec EmportByMonth " + month + "," + y;
                    import += "Exec ImportByMonth " + month + "," + y;

                    cmde = new SqlCommand(export, conn);

                    string income = "No Income", spend = "No Spend";

                    exportRead = cmde.ExecuteReader();
                    while (exportRead.Read())
                    {
                        income = exportRead.GetSqlInt64(2).ToString();
                    }
                    exportRead.Close();

                    cmdi = new SqlCommand(import, conn);
                    importRead = cmdi.ExecuteReader();
                    while (importRead.Read())
                    {
                        spend = importRead.GetSqlInt64(2).ToString();
                    }
                    importRead.Close();

                    if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["Month"] = month;
                        dr["Year"] = y;
                        dr["Income"] = income;
                        dr["Spend"] = spend;
                        dt.Rows.Add(dr);
                    }
                    export = "";
                    import = "";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                allBtn.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                allBtn.Enabled = false;
                noData.Visible = true;
            }
        }
        private void loadStatisticTable_Year(int year)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                conn.Open();
                for (int m = 1; m <= 12; m++)
                {
                    export += "Exec EmportByMonth " + m + "," + year;
                    import += "Exec ImportByMonth " + m + "," + year;
                    cmde = new SqlCommand(export, conn);

                    string income = "No Income", spend = "No Spend";

                    exportRead = cmde.ExecuteReader();
                    while (exportRead.Read())
                    {
                        income = exportRead.GetSqlInt64(2).ToString();
                    }
                    exportRead.Close();

                    cmdi = new SqlCommand(import, conn);
                    importRead = cmdi.ExecuteReader();
                    while (importRead.Read())
                    {
                        spend = importRead.GetSqlInt64(2).ToString();
                    }
                    importRead.Close();

                    if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["Month"] = m;
                        dr["Year"] = year;
                        dr["Spend"] = spend;
                        dr["Income"] = income;
                        dt.Rows.Add(dr);
                    }
                    export = "";
                    import = "";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                allBtn.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                allBtn.Enabled = false;
                noData.Visible = true;
            }
        }

        private void reloadStatisticTable()
        {
            int month = 0;
            int year = 0;
            if ( (comboMonth.SelectedItem.ToString().Length > 0) & (comboYear.SelectedItem.ToString().Length > 0) ) { 
                month = comboMonth.SelectedItem.ToString().Equals("All") ?  0 : int.Parse(comboMonth.SelectedItem.ToString());
                year = comboYear.SelectedItem.ToString().Equals("All") ? 0 : int.Parse(comboYear.SelectedItem.ToString());
            }
            else { }

            txtIncome.Text ="";
            txtSpend.Text ="";
            txtTurnover.Text ="";

            if (month == 0 & year == 0)
            {
                loadStatisticTable();
            }
            else if ( month != 0 & year != 0)
            {
                loadStatisticTable_MonthYear(month, year);
            }
            else if (month != 0)
            {
                loadStatisticTable_Month(month);
            }
            else
            {
                loadStatisticTable_Year(year);
            }

            if (statisticTables.Rows.Count > 0)
            {
                statisticTables.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                statisticTables.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void statisticTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int income = 0;
            int spend = 0;
            int rowindex = statisticTables.SelectedRows[0].Index;
            statisticTables.Rows[rowindex].Selected = true;

            string tmp1 = statisticTables.Rows[rowindex].Cells[2].Value.ToString();
            string tmp2 = statisticTables.Rows[rowindex].Cells[3].Value.ToString();

            if (!tmp1.Equals("No Spend"))
            {
                spend += int.Parse(tmp1);
            }
            else { }

            if (!tmp2.Equals("No Income"))
            {
                income += int.Parse(tmp2);
            }
            else { }

            if (income == 0) { txtIncome.Text = "0"; } else { txtIncome.Text = income + " k"; }
            if (spend == 0) { txtSpend.Text = "0"; } else { txtSpend.Text = spend + " k"; }
            if (income - spend < 0) { txtTurnover.Text = "Loss: " + (spend - income) + " k"; }else{ txtTurnover.Text = "Profit: " + (income - spend) + " k"; }
        }
        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadstatus.Equals("finish"))
            {
                reloadStatisticTable();
            }
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadstatus.Equals("finish"))
            {
                reloadStatisticTable();
            }
        }
        private void allBtn_Click(object sender, EventArgs e)
        {
            int income = 0;
            int spend = 0;
            for(int i = 0; i < statisticTables.RowCount; i++)
            {
                string tmp1 = statisticTables.Rows[i].Cells[2].Value.ToString();
                string tmp2 = statisticTables.Rows[i].Cells[3].Value.ToString();

                if (!tmp1.Equals("No Spend"))
                {
                    spend += int.Parse(tmp1);
                }
                else { }

                if (!tmp2.Equals("No Income"))
                {
                    income += int.Parse(tmp2);
                }
                else { }
            }

            statisticTables.SelectAll();

            if (income == 0) { txtIncome.Text = "0"; } else{txtIncome.Text = income + " k"; }
            if (spend == 0) { txtSpend.Text = "0";}else{ txtSpend.Text = spend + " k";}
            if (income - spend < 0){txtTurnover.Text = "Loss: " + (spend - income) + " k";}else{txtTurnover.Text = "Profit: " + (income - spend) + " k";}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmTrangChu_Ketoan back = new FrmTrangChu_Ketoan(user);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            FrmTKHH moreinfo = new FrmTKHH(user);
            this.Hide();
            moreinfo.ShowDialog();
            this.Close();
        }
    }
}
