
namespace lab05_bt1
{
    partial class formbai1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.cbbmahoadon = new System.Windows.Forms.ComboBox();
            this.RDBphieugiaohang = new System.Windows.Forms.RadioButton();
            this.RDBbaogiasanpham = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxuat);
            this.groupBox1.Controls.Add(this.cbbmahoadon);
            this.groupBox1.Controls.Add(this.RDBphieugiaohang);
            this.groupBox1.Controls.Add(this.RDBbaogiasanpham);
            this.groupBox1.Location = new System.Drawing.Point(65, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại xuất thông tin";
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(488, 86);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(95, 35);
            this.btnxuat.TabIndex = 4;
            this.btnxuat.Text = "Xuất report";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // cbbmahoadon
            // 
            this.cbbmahoadon.FormattingEnabled = true;
            this.cbbmahoadon.Items.AddRange(new object[] {
            "HDX001",
            "HDX002",
            "HDX003"});
            this.cbbmahoadon.Location = new System.Drawing.Point(272, 56);
            this.cbbmahoadon.Name = "cbbmahoadon";
            this.cbbmahoadon.Size = new System.Drawing.Size(181, 24);
            this.cbbmahoadon.TabIndex = 3;
            this.cbbmahoadon.SelectedIndexChanged += new System.EventHandler(this.cbbmahoadon_SelectedIndexChanged);
            // 
            // RDBphieugiaohang
            // 
            this.RDBphieugiaohang.AutoSize = true;
            this.RDBphieugiaohang.Location = new System.Drawing.Point(41, 57);
            this.RDBphieugiaohang.Name = "RDBphieugiaohang";
            this.RDBphieugiaohang.Size = new System.Drawing.Size(168, 21);
            this.RDBphieugiaohang.TabIndex = 1;
            this.RDBphieugiaohang.TabStop = true;
            this.RDBphieugiaohang.Text = "Bảng phiếu mua hàng";
            this.RDBphieugiaohang.UseVisualStyleBackColor = true;
            this.RDBphieugiaohang.CheckedChanged += new System.EventHandler(this.RDBphieugiaohang_CheckedChanged);
            // 
            // RDBbaogiasanpham
            // 
            this.RDBbaogiasanpham.AutoSize = true;
            this.RDBbaogiasanpham.Location = new System.Drawing.Point(41, 30);
            this.RDBbaogiasanpham.Name = "RDBbaogiasanpham";
            this.RDBbaogiasanpham.Size = new System.Drawing.Size(179, 21);
            this.RDBbaogiasanpham.TabIndex = 2;
            this.RDBbaogiasanpham.TabStop = true;
            this.RDBbaogiasanpham.Text = "Bảng báo giá sản phẩm";
            this.RDBbaogiasanpham.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(65, 127);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(923, 490);
            this.reportViewer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 629);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDBphieugiaohang;
        private System.Windows.Forms.RadioButton RDBbaogiasanpham;
        private System.Windows.Forms.ComboBox cbbmahoadon;
        private System.Windows.Forms.Button btnxuat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

