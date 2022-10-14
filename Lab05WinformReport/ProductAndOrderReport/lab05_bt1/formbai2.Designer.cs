
namespace lab05_bt1
{
    partial class formbai2
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
            this.btnInxem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.dtpthang = new System.Windows.Forms.DateTimePicker();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.rdbtungay = new System.Windows.Forms.RadioButton();
            this.rdbthang = new System.Windows.Forms.RadioButton();
            this.rdbngay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInxem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpdenngay);
            this.groupBox1.Controls.Add(this.dtpthang);
            this.groupBox1.Controls.Add(this.dtptungay);
            this.groupBox1.Controls.Add(this.dtpngay);
            this.groupBox1.Controls.Add(this.rdbtungay);
            this.groupBox1.Controls.Add(this.rdbthang);
            this.groupBox1.Controls.Add(this.rdbngay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(176, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // btnInxem
            // 
            this.btnInxem.Location = new System.Drawing.Point(577, 183);
            this.btnInxem.Margin = new System.Windows.Forms.Padding(4);
            this.btnInxem.Name = "btnInxem";
            this.btnInxem.Size = new System.Drawing.Size(127, 28);
            this.btnInxem.TabIndex = 9;
            this.btnInxem.Text = "In / Xem";
            this.btnInxem.UseVisualStyleBackColor = true;
            this.btnInxem.Click += new System.EventHandler(this.btnInxem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenngay.Location = new System.Drawing.Point(563, 131);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(141, 22);
            this.dtpdenngay.TabIndex = 7;
            // 
            // dtpthang
            // 
            this.dtpthang.CustomFormat = "MM/yyyy";
            this.dtpthang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpthang.Location = new System.Drawing.Point(375, 91);
            this.dtpthang.Name = "dtpthang";
            this.dtpthang.Size = new System.Drawing.Size(141, 22);
            this.dtpthang.TabIndex = 6;
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(375, 131);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(141, 22);
            this.dtptungay.TabIndex = 5;
            // 
            // dtpngay
            // 
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngay.Location = new System.Drawing.Point(374, 56);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(141, 22);
            this.dtpngay.TabIndex = 4;
            // 
            // rdbtungay
            // 
            this.rdbtungay.AutoSize = true;
            this.rdbtungay.Location = new System.Drawing.Point(243, 131);
            this.rdbtungay.Name = "rdbtungay";
            this.rdbtungay.Size = new System.Drawing.Size(108, 21);
            this.rdbtungay.TabIndex = 3;
            this.rdbtungay.TabStop = true;
            this.rdbtungay.Text = "Xem từ ngày";
            this.rdbtungay.UseVisualStyleBackColor = true;
            this.rdbtungay.CheckedChanged += new System.EventHandler(this.rdbtungay_CheckedChanged);
            // 
            // rdbthang
            // 
            this.rdbthang.AutoSize = true;
            this.rdbthang.Location = new System.Drawing.Point(243, 91);
            this.rdbthang.Name = "rdbthang";
            this.rdbthang.Size = new System.Drawing.Size(129, 21);
            this.rdbthang.TabIndex = 2;
            this.rdbthang.TabStop = true;
            this.rdbthang.Text = "Xem theo tháng";
            this.rdbthang.UseVisualStyleBackColor = true;
            this.rdbthang.CheckedChanged += new System.EventHandler(this.rdbthang_CheckedChanged);
            // 
            // rdbngay
            // 
            this.rdbngay.AutoSize = true;
            this.rdbngay.Location = new System.Drawing.Point(243, 52);
            this.rdbngay.Name = "rdbngay";
            this.rdbngay.Size = new System.Drawing.Size(124, 21);
            this.rdbngay.TabIndex = 1;
            this.rdbngay.TabStop = true;
            this.rdbngay.Text = "Xem theo ngày";
            this.rdbngay.UseVisualStyleBackColor = true;
            this.rdbngay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab05_bt1.report.Reportthongkehoadon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(172, 284);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 239);
            this.reportViewer1.TabIndex = 1;
            // 
            // formbai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 547);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formbai2";
            this.Text = "formbai2";
            this.Load += new System.EventHandler(this.formbai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtungay;
        private System.Windows.Forms.RadioButton rdbthang;
        private System.Windows.Forms.RadioButton rdbngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.DateTimePicker dtpthang;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnInxem;
    }
}