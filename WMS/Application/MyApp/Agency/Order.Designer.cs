
namespace AppCommand
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBank = new System.Windows.Forms.RadioButton();
            this.btnMomo = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.orderInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.notifyWrongValue2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyWrongValue1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.orderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AllowUserToResizeColumns = false;
            this.dataProduct.AllowUserToResizeRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(12, 66);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersVisible = false;
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataProduct.RowTemplate.Height = 36;
            this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduct.Size = new System.Drawing.Size(758, 475);
            this.dataProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Method: ";
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Transparent;
            this.btnBank.ForeColor = System.Drawing.Color.White;
            this.btnBank.Location = new System.Drawing.Point(548, 12);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(100, 24);
            this.btnBank.TabIndex = 2;
            this.btnBank.TabStop = true;
            this.btnBank.Text = "Banking";
            this.btnBank.UseVisualStyleBackColor = false;
            // 
            // btnMomo
            // 
            this.btnMomo.AutoSize = true;
            this.btnMomo.BackColor = System.Drawing.Color.Transparent;
            this.btnMomo.ForeColor = System.Drawing.Color.White;
            this.btnMomo.Location = new System.Drawing.Point(548, 41);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(67, 21);
            this.btnMomo.TabIndex = 3;
            this.btnMomo.TabStop = true;
            this.btnMomo.Text = "Momo";
            this.btnMomo.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(664, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(106, 48);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // orderInfo
            // 
            this.orderInfo.Controls.Add(this.txtTotal);
            this.orderInfo.Controls.Add(this.dataOrder);
            this.orderInfo.Controls.Add(this.label3);
            this.orderInfo.Controls.Add(this.btnCancel);
            this.orderInfo.Controls.Add(this.btnYes);
            this.orderInfo.Controls.Add(this.label2);
            this.orderInfo.Location = new System.Drawing.Point(12, 12);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(758, 529);
            this.orderInfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order\'s info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(21, 410);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(723, 25);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "Total: ";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataOrder
            // 
            this.dataOrder.AllowUserToAddRows = false;
            this.dataOrder.AllowUserToDeleteRows = false;
            this.dataOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Location = new System.Drawing.Point(24, 54);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            this.dataOrder.RowHeadersVisible = false;
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataOrder.RowTemplate.Height = 36;
            this.dataOrder.RowTemplate.ReadOnly = true;
            this.dataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrder.Size = new System.Drawing.Size(720, 340);
            this.dataOrder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do you agree to order?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(536, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(652, 477);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(92, 37);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // notifyWrongValue2
            // 
            this.notifyWrongValue2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue2.BalloonTipText = "Quantity must >=0";
            this.notifyWrongValue2.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue2.Icon")));
            this.notifyWrongValue2.Text = "notifyIcon1";
            this.notifyWrongValue2.Visible = true;
            // 
            // notifyWrongValue1
            // 
            this.notifyWrongValue1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyWrongValue1.BalloonTipText = "Quantity must be \"integer\"";
            this.notifyWrongValue1.BalloonTipTitle = "Wrong format";
            this.notifyWrongValue1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyWrongValue1.Icon")));
            this.notifyWrongValue1.Text = "notifyIcon2";
            this.notifyWrongValue1.Visible = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCommand.Properties.Resources.income_spend;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnMomo);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.orderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnBank;
        private System.Windows.Forms.RadioButton btnMomo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel orderInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.NotifyIcon notifyWrongValue2;
        private System.Windows.Forms.NotifyIcon notifyWrongValue1;
    }
}