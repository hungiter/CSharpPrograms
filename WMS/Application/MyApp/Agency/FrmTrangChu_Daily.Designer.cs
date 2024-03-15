
namespace AppCommand
{
    partial class FrmTrangChu_Daily
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu_Daily));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnShipped = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pendingPanel = new System.Windows.Forms.Panel();
            this.dataPending = new System.Windows.Forms.DataGridView();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.shippedPanel = new System.Windows.Forms.Panel();
            this.dataShipped = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pendingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPending)).BeginInit();
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.shippedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataShipped)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 528);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(17, 467);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(14, 64);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtName.Size = new System.Drawing.Size(320, 40);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "Name: ";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(192, 467);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(142, 44);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "New Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(14, 174);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtAdd.Size = new System.Drawing.Size(320, 80);
            this.txtAdd.TabIndex = 2;
            this.txtAdd.Text = "Address: ";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(14, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPhone.Size = new System.Drawing.Size(320, 40);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Phone no: ";
            this.txtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(14, 14);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtID.Size = new System.Drawing.Size(320, 40);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID: ";
            this.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.Location = new System.Drawing.Point(392, 13);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(142, 44);
            this.btnPending.TabIndex = 1;
            this.btnPending.Text = "On pending";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnShipped
            // 
            this.btnShipped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipped.Location = new System.Drawing.Point(540, 11);
            this.btnShipped.Name = "btnShipped";
            this.btnShipped.Size = new System.Drawing.Size(142, 44);
            this.btnShipped.TabIndex = 2;
            this.btnShipped.Text = "Shipped";
            this.btnShipped.UseVisualStyleBackColor = false;
            this.btnShipped.Click += new System.EventHandler(this.btnShipped_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(688, 11);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(142, 44);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // pendingPanel
            // 
            this.pendingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pendingPanel.Controls.Add(this.dataPending);
            this.pendingPanel.Location = new System.Drawing.Point(392, 60);
            this.pendingPanel.Name = "pendingPanel";
            this.pendingPanel.Size = new System.Drawing.Size(578, 481);
            this.pendingPanel.TabIndex = 4;
            // 
            // dataPending
            // 
            this.dataPending.AllowUserToAddRows = false;
            this.dataPending.AllowUserToDeleteRows = false;
            this.dataPending.AllowUserToResizeColumns = false;
            this.dataPending.AllowUserToResizeRows = false;
            this.dataPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPending.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPending.Location = new System.Drawing.Point(4, 3);
            this.dataPending.Name = "dataPending";
            this.dataPending.ReadOnly = true;
            this.dataPending.RowHeadersVisible = false;
            this.dataPending.RowHeadersWidth = 51;
            this.dataPending.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataPending.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataPending.RowTemplate.Height = 36;
            this.dataPending.RowTemplate.ReadOnly = true;
            this.dataPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPending.Size = new System.Drawing.Size(571, 472);
            this.dataPending.TabIndex = 0;
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.historyPanel.Controls.Add(this.dataHistory);
            this.historyPanel.Location = new System.Drawing.Point(392, 60);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(578, 487);
            this.historyPanel.TabIndex = 5;
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Location = new System.Drawing.Point(3, 3);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataHistory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataHistory.RowTemplate.Height = 36;
            this.dataHistory.RowTemplate.ReadOnly = true;
            this.dataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHistory.Size = new System.Drawing.Size(572, 475);
            this.dataHistory.TabIndex = 0;
            // 
            // shippedPanel
            // 
            this.shippedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shippedPanel.Controls.Add(this.dataShipped);
            this.shippedPanel.Location = new System.Drawing.Point(392, 61);
            this.shippedPanel.Name = "shippedPanel";
            this.shippedPanel.Size = new System.Drawing.Size(578, 480);
            this.shippedPanel.TabIndex = 6;
            // 
            // dataShipped
            // 
            this.dataShipped.AllowUserToAddRows = false;
            this.dataShipped.AllowUserToDeleteRows = false;
            this.dataShipped.AllowUserToResizeColumns = false;
            this.dataShipped.AllowUserToResizeRows = false;
            this.dataShipped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataShipped.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataShipped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShipped.Location = new System.Drawing.Point(3, 3);
            this.dataShipped.Name = "dataShipped";
            this.dataShipped.ReadOnly = true;
            this.dataShipped.RowHeadersVisible = false;
            this.dataShipped.RowHeadersWidth = 51;
            this.dataShipped.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataShipped.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataShipped.RowTemplate.Height = 36;
            this.dataShipped.RowTemplate.ReadOnly = true;
            this.dataShipped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataShipped.Size = new System.Drawing.Size(572, 474);
            this.dataShipped.TabIndex = 0;
            this.dataShipped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShipped_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(192, 414);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(142, 47);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FrmTrangChu_Daily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnShipped);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pendingPanel);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.shippedPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmTrangChu_Daily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.FrmTrangChu_Daily_Load);
            this.panel1.ResumeLayout(false);
            this.pendingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPending)).EndInit();
            this.historyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.shippedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataShipped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label txtAdd;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnShipped;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pendingPanel;
        private System.Windows.Forms.DataGridView dataPending;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.Panel shippedPanel;
        private System.Windows.Forms.DataGridView dataShipped;
        private System.Windows.Forms.Button btnReload;
    }
}