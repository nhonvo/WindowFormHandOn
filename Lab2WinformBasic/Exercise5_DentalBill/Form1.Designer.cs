namespace DentalBill
{
    partial class Form1
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
            this.gbxDichVu = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cbxNieng = new System.Windows.Forms.CheckBox();
            this.lblNieng = new System.Windows.Forms.Label();
            this.txtSoLuongTram = new System.Windows.Forms.TextBox();
            this.lblSoLuongTram = new System.Windows.Forms.Label();
            this.cbxTram = new System.Windows.Forms.CheckBox();
            this.lblTram = new System.Windows.Forms.Label();
            this.txtSoLuongNho = new System.Windows.Forms.TextBox();
            this.lblSoLuongNho = new System.Windows.Forms.Label();
            this.cbxNho = new System.Windows.Forms.CheckBox();
            this.lblNho = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.gbxDichVu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDichVu
            // 
            this.gbxDichVu.Controls.Add(this.lblThanhTien);
            this.gbxDichVu.Controls.Add(this.btnTinh);
            this.gbxDichVu.Controls.Add(this.lblTongTien);
            this.gbxDichVu.Controls.Add(this.cbxNieng);
            this.gbxDichVu.Controls.Add(this.lblNieng);
            this.gbxDichVu.Controls.Add(this.txtSoLuongTram);
            this.gbxDichVu.Controls.Add(this.lblSoLuongTram);
            this.gbxDichVu.Controls.Add(this.cbxTram);
            this.gbxDichVu.Controls.Add(this.lblTram);
            this.gbxDichVu.Controls.Add(this.txtSoLuongNho);
            this.gbxDichVu.Controls.Add(this.lblSoLuongNho);
            this.gbxDichVu.Controls.Add(this.cbxNho);
            this.gbxDichVu.Controls.Add(this.lblNho);
            this.gbxDichVu.Location = new System.Drawing.Point(12, 185);
            this.gbxDichVu.Name = "gbxDichVu";
            this.gbxDichVu.Size = new System.Drawing.Size(783, 275);
            this.gbxDichVu.TabIndex = 1;
            this.gbxDichVu.TabStop = false;
            this.gbxDichVu.Text = "Dịch vụ";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(255, 213);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 12;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(47, 216);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(55, 13);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // cbxNieng
            // 
            this.cbxNieng.AutoSize = true;
            this.cbxNieng.Location = new System.Drawing.Point(113, 145);
            this.cbxNieng.Name = "cbxNieng";
            this.cbxNieng.Size = new System.Drawing.Size(18, 17);
            this.cbxNieng.TabIndex = 9;
            this.cbxNieng.UseVisualStyleBackColor = true;
            // 
            // lblNieng
            // 
            this.lblNieng.AutoSize = true;
            this.lblNieng.Location = new System.Drawing.Point(46, 145);
            this.lblNieng.Name = "lblNieng";
            this.lblNieng.Size = new System.Drawing.Size(43, 16);
            this.lblNieng.TabIndex = 8;
            this.lblNieng.Text = "Niềng";
            // 
            // txtSoLuongTram
            // 
            this.txtSoLuongTram.Location = new System.Drawing.Point(489, 98);
            this.txtSoLuongTram.Name = "txtSoLuongTram";
            this.txtSoLuongTram.Size = new System.Drawing.Size(185, 22);
            this.txtSoLuongTram.TabIndex = 7;
            // 
            // lblSoLuongTram
            // 
            this.lblSoLuongTram.AutoSize = true;
            this.lblSoLuongTram.Location = new System.Drawing.Point(373, 104);
            this.lblSoLuongTram.Name = "lblSoLuongTram";
            this.lblSoLuongTram.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuongTram.TabIndex = 6;
            this.lblSoLuongTram.Text = "Số lượng";
            // 
            // cbxTram
            // 
            this.cbxTram.AutoSize = true;
            this.cbxTram.Location = new System.Drawing.Point(113, 100);
            this.cbxTram.Name = "cbxTram";
            this.cbxTram.Size = new System.Drawing.Size(18, 17);
            this.cbxTram.TabIndex = 5;
            this.cbxTram.UseVisualStyleBackColor = true;
            this.cbxTram.CheckedChanged += new System.EventHandler(this.cbxTram_CheckedChanged);
            // 
            // lblTram
            // 
            this.lblTram.AutoSize = true;
            this.lblTram.Location = new System.Drawing.Point(46, 100);
            this.lblTram.Name = "lblTram";
            this.lblTram.Size = new System.Drawing.Size(39, 16);
            this.lblTram.TabIndex = 4;
            this.lblTram.Text = "Trám";
            // 
            // txtSoLuongNho
            // 
            this.txtSoLuongNho.Location = new System.Drawing.Point(489, 54);
            this.txtSoLuongNho.Name = "txtSoLuongNho";
            this.txtSoLuongNho.Size = new System.Drawing.Size(185, 22);
            this.txtSoLuongNho.TabIndex = 3;
            // 
            // lblSoLuongNho
            // 
            this.lblSoLuongNho.AutoSize = true;
            this.lblSoLuongNho.Location = new System.Drawing.Point(373, 60);
            this.lblSoLuongNho.Name = "lblSoLuongNho";
            this.lblSoLuongNho.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuongNho.TabIndex = 2;
            this.lblSoLuongNho.Text = "Số lượng";
            // 
            // cbxNho
            // 
            this.cbxNho.AutoSize = true;
            this.cbxNho.Location = new System.Drawing.Point(113, 56);
            this.cbxNho.Name = "cbxNho";
            this.cbxNho.Size = new System.Drawing.Size(18, 17);
            this.cbxNho.TabIndex = 1;
            this.cbxNho.UseVisualStyleBackColor = true;
            this.cbxNho.CheckedChanged += new System.EventHandler(this.cbxNho_CheckedChanged);
            // 
            // lblNho
            // 
            this.lblNho.AutoSize = true;
            this.lblNho.Location = new System.Drawing.Point(46, 56);
            this.lblNho.Name = "lblNho";
            this.lblNho.Size = new System.Drawing.Size(32, 16);
            this.lblNho.TabIndex = 0;
            this.lblNho.Text = "Nhổ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 78);
            this.panel1.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(214, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(476, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(74, 15);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(354, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "DENTAL BILL";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(144, 216);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(14, 16);
            this.lblThanhTien.TabIndex = 13;
            this.lblThanhTien.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 529);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDichVu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDichVu.ResumeLayout(false);
            this.gbxDichVu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.CheckBox cbxNho;
        private System.Windows.Forms.Label lblNho;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.CheckBox cbxNieng;
        private System.Windows.Forms.Label lblNieng;
        private System.Windows.Forms.TextBox txtSoLuongTram;
        private System.Windows.Forms.Label lblSoLuongTram;
        private System.Windows.Forms.CheckBox cbxTram;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.TextBox txtSoLuongNho;
        private System.Windows.Forms.Label lblSoLuongNho;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThanhTien;
    }
}

