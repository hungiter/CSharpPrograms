
namespace AppCommand
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyLoginFail3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyLoginFail1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyLoginSuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyLoginFail2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(258, 175);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(197, 30);
            this.txtTaiKhoan.TabIndex = 0;
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(258, 225);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(197, 30);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(95, 175);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(110, 25);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "Username";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(95, 225);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(106, 25);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(100, 300);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(305, 300);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyLoginFail3
            // 
            this.notifyLoginFail3.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyLoginFail3.BalloonTipText = "Sai tên tài khoản hoặc mật khẩu";
            this.notifyLoginFail3.BalloonTipTitle = "Lỗi đăng nhập";
            this.notifyLoginFail3.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyLoginFail3.Icon")));
            this.notifyLoginFail3.Visible = true;
            // 
            // notifyLoginFail1
            // 
            this.notifyLoginFail1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyLoginFail1.BalloonTipText = "Tên tài khoản và mật khẩu không thể trống";
            this.notifyLoginFail1.BalloonTipTitle = "Lỗi đăng nhập";
            this.notifyLoginFail1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyLoginFail1.Icon")));
            this.notifyLoginFail1.Text = "notifyIcon1";
            this.notifyLoginFail1.Visible = true;
            // 
            // notifyLoginSuccess
            // 
            this.notifyLoginSuccess.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyLoginSuccess.BalloonTipText = "Đang sử dụng bởi tài khoản:";
            this.notifyLoginSuccess.BalloonTipTitle = "Đăng nhập thành công";
            this.notifyLoginSuccess.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyLoginSuccess.Icon")));
            this.notifyLoginSuccess.Text = "notifyIcon1";
            this.notifyLoginSuccess.Visible = true;
            // 
            // notifyLoginFail2
            // 
            this.notifyLoginFail2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyLoginFail2.BalloonTipText = "Mật khẩu dài hơn 6 kí tự";
            this.notifyLoginFail2.BalloonTipTitle = "Lỗi đăng nhập";
            this.notifyLoginFail2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyLoginFail2.Icon")));
            this.notifyLoginFail2.Text = "notifyIcon1";
            this.notifyLoginFail2.Visible = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 151);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::AppCommand.Properties.Resources.tpcn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 397);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(555, 444);
            this.MinimumSize = new System.Drawing.Size(555, 444);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyLoginFail3;
        private System.Windows.Forms.NotifyIcon notifyLoginFail1;
        private System.Windows.Forms.NotifyIcon notifyLoginSuccess;
        private System.Windows.Forms.NotifyIcon notifyLoginFail2;
        private System.Windows.Forms.Label label1;
    }
}

