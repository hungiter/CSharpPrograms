
namespace AppCommand
{
    partial class FrmTrangChu_Ketoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu_Ketoan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTKHH = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsingBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNhapKho,
            this.itemXuatKho,
            this.tHỐNGKÊToolStripMenuItem,
            this.itemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemNhapKho
            // 
            this.itemNhapKho.Name = "itemNhapKho";
            this.itemNhapKho.Size = new System.Drawing.Size(75, 24);
            this.itemNhapKho.Text = "IMPORT";
            this.itemNhapKho.Click += new System.EventHandler(this.itemNhapKho_Click);
            // 
            // itemXuatKho
            // 
            this.itemXuatKho.Name = "itemXuatKho";
            this.itemXuatKho.Size = new System.Drawing.Size(75, 24);
            this.itemXuatKho.Text = "EXPORT";
            this.itemXuatKho.Click += new System.EventHandler(this.itemXuatKho_Click);
            // 
            // tHỐNGKÊToolStripMenuItem
            // 
            this.tHỐNGKÊToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTKDT,
            this.itemTKHH});
            this.tHỐNGKÊToolStripMenuItem.Name = "tHỐNGKÊToolStripMenuItem";
            this.tHỐNGKÊToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.tHỐNGKÊToolStripMenuItem.Text = "STATISTICS";
            // 
            // itemTKDT
            // 
            this.itemTKDT.Name = "itemTKDT";
            this.itemTKDT.Size = new System.Drawing.Size(304, 26);
            this.itemTKDT.Text = "MONTHLY REVENUE STATISTICS";
            this.itemTKDT.Click += new System.EventHandler(this.itemTKDT_Click);
            // 
            // itemTKHH
            // 
            this.itemTKHH.Name = "itemTKHH";
            this.itemTKHH.Size = new System.Drawing.Size(304, 26);
            this.itemTKHH.Text = "STATISTICS OF GOODS IN OUT";
            this.itemTKHH.Click += new System.EventHandler(this.itemTKHH_Click);
            // 
            // itemLogout
            // 
            this.itemLogout.Name = "itemLogout";
            this.itemLogout.Size = new System.Drawing.Size(83, 24);
            this.itemLogout.Text = "LOG OUT";
            this.itemLogout.Click += new System.EventHandler(this.itemLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppCommand.Properties.Resources.tpcn;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 509);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::AppCommand.Properties.Resources.tpcn;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtUsingBy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 509);
            this.panel2.TabIndex = 0;
            // 
            // txtUsingBy
            // 
            this.txtUsingBy.BackColor = System.Drawing.Color.LightGray;
            this.txtUsingBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsingBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsingBy.ForeColor = System.Drawing.Color.Black;
            this.txtUsingBy.Location = new System.Drawing.Point(0, 0);
            this.txtUsingBy.Name = "txtUsingBy";
            this.txtUsingBy.Size = new System.Drawing.Size(557, 29);
            this.txtUsingBy.TabIndex = 2;
            this.txtUsingBy.Text = "Using by : ";
            this.txtUsingBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(0, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create by Grop N2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(0, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 148);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ware House Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTrangChu_Ketoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmTrangChu_Ketoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemNhapKho;
        private System.Windows.Forms.ToolStripMenuItem itemXuatKho;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTKDT;
        private System.Windows.Forms.ToolStripMenuItem itemTKHH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUsingBy;
        private System.Windows.Forms.ToolStripMenuItem itemLogout;
    }
}