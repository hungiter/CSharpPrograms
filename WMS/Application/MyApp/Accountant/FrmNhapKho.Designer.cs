
namespace AppCommand
{
    partial class FrmNhapKho
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.historyList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.notifyWrongValue1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.updateConfirm = new System.Windows.Forms.Panel();
            this.updateList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rejectUpdate = new System.Windows.Forms.PictureBox();
            this.acceptUpdate = new System.Windows.Forms.PictureBox();
            this.notifyWrongValue2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyUpdateSucces = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyList)).BeginInit();
            this.updateConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Location = new System.Drawing.Point(13, 49);
            this.productList.Margin = new System.Windows.Forms.Padding(4);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.RowHeadersVisible = false;
            this.productList.RowHeadersWidth = 51;
            this.productList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productList.RowTemplate.Height = 36;
            this.productList.Size = new System.Drawing.Size(756, 300);
            this.productList.TabIndex = 8;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Goods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Import History";
            // 
            // historyList
            // 
            this.historyList.AllowUserToAddRows = false;
            this.historyList.AllowUserToDeleteRows = false;
            this.historyList.AllowUserToResizeRows = false;
            this.historyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.historyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyList.Location = new System.Drawing.Point(13, 402);
            this.historyList.Margin = new System.Windows.Forms.Padding(4);
            this.historyList.MultiSelect = false;
            this.historyList.Name = "historyList";
            this.historyList.RowHeadersVisible = false;
            this.historyList.RowHeadersWidth = 51;
            this.historyList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.historyList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.historyList.RowTemplate.Height = 36;
            this.historyList.Size = new System.Drawing.Size(600, 300);
            this.historyList.TabIndex = 12;
            this.historyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyList_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(634, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(477, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 40);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(633, 662);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // notifyWrongValue1
            // 
            this.notifyWrongValue1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue1.BalloonTipText = "Add.. must be \"integer\"";
            this.notifyWrongValue1.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue1.Icon")));
            this.notifyWrongValue1.Text = "notifyIcon1";
            this.notifyWrongValue1.Visible = true;
            // 
            // updateConfirm
            // 
            this.updateConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateConfirm.Controls.Add(this.updateList);
            this.updateConfirm.Controls.Add(this.label2);
            this.updateConfirm.Controls.Add(this.rejectUpdate);
            this.updateConfirm.Controls.Add(this.acceptUpdate);
            this.updateConfirm.Location = new System.Drawing.Point(12, 12);
            this.updateConfirm.Name = "updateConfirm";
            this.updateConfirm.Size = new System.Drawing.Size(758, 337);
            this.updateConfirm.TabIndex = 17;
            // 
            // updateList
            // 
            this.updateList.AllowUserToAddRows = false;
            this.updateList.AllowUserToDeleteRows = false;
            this.updateList.AllowUserToOrderColumns = true;
            this.updateList.AllowUserToResizeRows = false;
            this.updateList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updateList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.updateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateList.Location = new System.Drawing.Point(13, 14);
            this.updateList.Name = "updateList";
            this.updateList.ReadOnly = true;
            this.updateList.RowHeadersVisible = false;
            this.updateList.RowHeadersWidth = 51;
            this.updateList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.updateList.RowTemplate.Height = 36;
            this.updateList.RowTemplate.ReadOnly = true;
            this.updateList.Size = new System.Drawing.Size(728, 225);
            this.updateList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "This action cannot be return. Continue updating?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rejectUpdate
            // 
            this.rejectUpdate.BackColor = System.Drawing.Color.Transparent;
            this.rejectUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rejectUpdate.BackgroundImage")));
            this.rejectUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rejectUpdate.Location = new System.Drawing.Point(637, 285);
            this.rejectUpdate.Name = "rejectUpdate";
            this.rejectUpdate.Size = new System.Drawing.Size(40, 40);
            this.rejectUpdate.TabIndex = 1;
            this.rejectUpdate.TabStop = false;
            this.rejectUpdate.Click += new System.EventHandler(this.rejectUpdate_Click);
            // 
            // acceptUpdate
            // 
            this.acceptUpdate.BackColor = System.Drawing.Color.Transparent;
            this.acceptUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceptUpdate.BackgroundImage")));
            this.acceptUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acceptUpdate.Location = new System.Drawing.Point(697, 281);
            this.acceptUpdate.Name = "acceptUpdate";
            this.acceptUpdate.Size = new System.Drawing.Size(44, 44);
            this.acceptUpdate.TabIndex = 0;
            this.acceptUpdate.TabStop = false;
            this.acceptUpdate.Click += new System.EventHandler(this.acceptUpdate_Click);
            // 
            // notifyWrongValue2
            // 
            this.notifyWrongValue2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue2.BalloonTipText = "Input value must >=0";
            this.notifyWrongValue2.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue2.Icon")));
            this.notifyWrongValue2.Text = "notifyIcon1";
            this.notifyWrongValue2.Visible = true;
            // 
            // notifyUpdateSucces
            // 
            this.notifyUpdateSucces.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyUpdateSucces.BalloonTipText = "1 item has been added to history";
            this.notifyUpdateSucces.BalloonTipTitle = "UpdateSucces";
            this.notifyUpdateSucces.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyUpdateSucces.Icon")));
            this.notifyUpdateSucces.Text = "notifyIcon1";
            this.notifyUpdateSucces.Visible = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(633, 602);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(136, 40);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 719);
            this.ControlBox = false;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.updateConfirm);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 766);
            this.MinimumSize = new System.Drawing.Size(800, 766);
            this.Name = "FrmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Import Form";
            this.Load += new System.EventHandler(this.FrmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyList)).EndInit();
            this.updateConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView historyList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NotifyIcon notifyWrongValue1;
        private System.Windows.Forms.Panel updateConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox rejectUpdate;
        private System.Windows.Forms.PictureBox acceptUpdate;
        private System.Windows.Forms.DataGridView updateList;
        private System.Windows.Forms.NotifyIcon notifyWrongValue2;
        private System.Windows.Forms.NotifyIcon notifyUpdateSucces;
        private System.Windows.Forms.Button btnShow;
    }
}