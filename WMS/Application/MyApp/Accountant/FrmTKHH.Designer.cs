
namespace AppCommand
{
    partial class FrmTKHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTKHH));
            this.productStatisticTable = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productStatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // productStatisticTable
            // 
            this.productStatisticTable.AllowUserToAddRows = false;
            this.productStatisticTable.AllowUserToDeleteRows = false;
            this.productStatisticTable.AllowUserToResizeColumns = false;
            this.productStatisticTable.AllowUserToResizeRows = false;
            this.productStatisticTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productStatisticTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productStatisticTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productStatisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productStatisticTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.productStatisticTable.Location = new System.Drawing.Point(16, 47);
            this.productStatisticTable.Margin = new System.Windows.Forms.Padding(4);
            this.productStatisticTable.Name = "productStatisticTable";
            this.productStatisticTable.ReadOnly = true;
            this.productStatisticTable.RowHeadersVisible = false;
            this.productStatisticTable.RowHeadersWidth = 51;
            this.productStatisticTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productStatisticTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productStatisticTable.RowTemplate.Height = 36;
            this.productStatisticTable.RowTemplate.ReadOnly = true;
            this.productStatisticTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productStatisticTable.Size = new System.Drawing.Size(753, 492);
            this.productStatisticTable.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(669, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboMonth
            // 
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(16, 12);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(120, 28);
            this.comboMonth.TabIndex = 3;
            this.comboMonth.SelectedIndexChanged += new System.EventHandler(this.comboMonth_SelectedIndexChanged);
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.comboYear.Location = new System.Drawing.Point(142, 12);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(120, 28);
            this.comboYear.TabIndex = 4;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // FrmTKHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.productStatisticTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmTKHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics of product in out";
            this.Load += new System.EventHandler(this.FrmTKHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productStatisticTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productStatisticTable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboYear;
    }
}