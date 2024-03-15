
namespace AppCommand
{
    partial class FrmTKDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTKDT));
            this.statisticTables = new System.Windows.Forms.DataGridView();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.Label();
            this.txtSpend = new System.Windows.Forms.Label();
            this.txtTurnover = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.allBtn = new System.Windows.Forms.Button();
            this.noData = new System.Windows.Forms.Label();
            this.moreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticTables)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticTables
            // 
            this.statisticTables.AllowUserToAddRows = false;
            this.statisticTables.AllowUserToDeleteRows = false;
            this.statisticTables.AllowUserToResizeColumns = false;
            this.statisticTables.AllowUserToResizeRows = false;
            this.statisticTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticTables.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.statisticTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticTables.Location = new System.Drawing.Point(13, 71);
            this.statisticTables.Margin = new System.Windows.Forms.Padding(4);
            this.statisticTables.Name = "statisticTables";
            this.statisticTables.ReadOnly = true;
            this.statisticTables.RowHeadersVisible = false;
            this.statisticTables.RowHeadersWidth = 51;
            this.statisticTables.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statisticTables.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statisticTables.RowTemplate.Height = 36;
            this.statisticTables.RowTemplate.ReadOnly = true;
            this.statisticTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticTables.Size = new System.Drawing.Size(513, 469);
            this.statisticTables.TabIndex = 3;
            this.statisticTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statisticTables_CellContentClick);
            // 
            // comboMonth
            // 
            this.comboMonth.DropDownHeight = 160;
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.IntegralHeight = false;
            this.comboMonth.Location = new System.Drawing.Point(650, 71);
            this.comboMonth.MaxDropDownItems = 20;
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(120, 28);
            this.comboMonth.TabIndex = 5;
            this.comboMonth.SelectedIndexChanged += new System.EventHandler(this.comboMonth_SelectedIndexChanged);
            // 
            // comboYear
            // 
            this.comboYear.DropDownHeight = 160;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.IntegralHeight = false;
            this.comboYear.Location = new System.Drawing.Point(650, 116);
            this.comboYear.MaxDropDownItems = 20;
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 28);
            this.comboYear.TabIndex = 6;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(534, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Month: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(534, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Income: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(534, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Spend: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(534, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Turnover: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(670, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.LightCyan;
            this.txtIncome.Location = new System.Drawing.Point(539, 288);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(231, 30);
            this.txtIncome.TabIndex = 13;
            this.txtIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpend
            // 
            this.txtSpend.BackColor = System.Drawing.Color.LightCyan;
            this.txtSpend.Location = new System.Drawing.Point(539, 358);
            this.txtSpend.Name = "txtSpend";
            this.txtSpend.Size = new System.Drawing.Size(231, 30);
            this.txtSpend.TabIndex = 14;
            this.txtSpend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTurnover
            // 
            this.txtTurnover.BackColor = System.Drawing.Color.LightCyan;
            this.txtTurnover.Location = new System.Drawing.Point(539, 428);
            this.txtTurnover.Name = "txtTurnover";
            this.txtTurnover.Size = new System.Drawing.Size(231, 30);
            this.txtTurnover.TabIndex = 15;
            this.txtTurnover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("VNI-Lithos", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(760, 50);
            this.label9.TabIndex = 16;
            this.label9.Text = "Incoming and Spending";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.allBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allBtn.Location = new System.Drawing.Point(537, 216);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(108, 34);
            this.allBtn.TabIndex = 17;
            this.allBtn.Text = "Total statistics";
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // noData
            // 
            this.noData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noData.Location = new System.Drawing.Point(10, 71);
            this.noData.Name = "noData";
            this.noData.Size = new System.Drawing.Size(516, 469);
            this.noData.TabIndex = 18;
            this.noData.Text = "No Data";
            this.noData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moreBtn
            // 
            this.moreBtn.Location = new System.Drawing.Point(537, 505);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(100, 36);
            this.moreBtn.TabIndex = 19;
            this.moreBtn.Text = "More ...";
            this.moreBtn.UseVisualStyleBackColor = true;
            this.moreBtn.Click += new System.EventHandler(this.moreBtn_Click);
            // 
            // FrmTKDT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AppCommand.Properties.Resources.income_spend;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.moreBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTurnover);
            this.Controls.Add(this.txtSpend);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.noData);
            this.Controls.Add(this.statisticTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmTKDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.FrmTKDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView statisticTables;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label txtIncome;
        private System.Windows.Forms.Label txtSpend;
        private System.Windows.Forms.Label txtTurnover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Label noData;
        private System.Windows.Forms.Button moreBtn;
    }
}