namespace RapPhimNew
{
    partial class FrmHoaDon
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
            System.Windows.Forms.Label soGheLabel;
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label maChiTietHoaDonLabel;
            System.Windows.Forms.Label giaVeLabel;
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxHoaDon = new System.Windows.Forms.GroupBox();
            this.gbxChiTiet = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.maChiTietHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaVeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.khachHangComboBox = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaiKhachHang = new System.Windows.Forms.Button();
            this.soGheTextBox = new System.Windows.Forms.TextBox();
            this.maHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.maChiTietHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.giaVeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            soGheLabel = new System.Windows.Forms.Label();
            maHoaDonLabel = new System.Windows.Forms.Label();
            maChiTietHoaDonLabel = new System.Windows.Forms.Label();
            giaVeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.gbxHoaDon.SuspendLayout();
            this.gbxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soGheLabel
            // 
            soGheLabel.AutoSize = true;
            soGheLabel.Location = new System.Drawing.Point(43, 113);
            soGheLabel.Name = "soGheLabel";
            soGheLabel.Size = new System.Drawing.Size(55, 16);
            soGheLabel.TabIndex = 10;
            soGheLabel.Text = "So Ghe:";
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Location = new System.Drawing.Point(43, 85);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(86, 16);
            maHoaDonLabel.TabIndex = 8;
            maHoaDonLabel.Text = "Ma Hoa Don:";
            // 
            // maChiTietHoaDonLabel
            // 
            maChiTietHoaDonLabel.AutoSize = true;
            maChiTietHoaDonLabel.Location = new System.Drawing.Point(43, 57);
            maChiTietHoaDonLabel.Name = "maChiTietHoaDonLabel";
            maChiTietHoaDonLabel.Size = new System.Drawing.Size(134, 16);
            maChiTietHoaDonLabel.TabIndex = 6;
            maChiTietHoaDonLabel.Text = "Ma Chi Tiet Hoa Don:";
            // 
            // giaVeLabel
            // 
            giaVeLabel.AutoSize = true;
            giaVeLabel.Location = new System.Drawing.Point(43, 29);
            giaVeLabel.Name = "giaVeLabel";
            giaVeLabel.Size = new System.Drawing.Size(51, 16);
            giaVeLabel.TabIndex = 4;
            giaVeLabel.Text = "Gia Ve:";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoGenerateColumns = false;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn1,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.khachHangDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn});
            this.dataGridViewHoaDon.DataSource = this.hoaDonBindingSource;
            this.dataGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(367, 179);
            this.dataGridViewHoaDon.TabIndex = 0;
            this.dataGridViewHoaDon.SelectionChanged += new System.EventHandler(this.dataGridViewHoaDon_SelectionChanged);
            // 
            // maHoaDonDataGridViewTextBoxColumn1
            // 
            this.maHoaDonDataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn1.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn1.Name = "maHoaDonDataGridViewTextBoxColumn1";
            this.maHoaDonDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // khachHangDataGridViewTextBoxColumn
            // 
            this.khachHangDataGridViewTextBoxColumn.DataPropertyName = "KhachHang";
            this.khachHangDataGridViewTextBoxColumn.HeaderText = "KhachHang";
            this.khachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khachHangDataGridViewTextBoxColumn.Name = "khachHangDataGridViewTextBoxColumn";
            this.khachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(RapPhimNew.Models.HoaDon);
            // 
            // gbxHoaDon
            // 
            this.gbxHoaDon.Controls.Add(this.dataGridViewHoaDon);
            this.gbxHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxHoaDon.Location = new System.Drawing.Point(0, 248);
            this.gbxHoaDon.Name = "gbxHoaDon";
            this.gbxHoaDon.Size = new System.Drawing.Size(373, 200);
            this.gbxHoaDon.TabIndex = 1;
            this.gbxHoaDon.TabStop = false;
            this.gbxHoaDon.Text = "Hóa đơn";
            // 
            // gbxChiTiet
            // 
            this.gbxChiTiet.Controls.Add(this.dataGridViewCTHD);
            this.gbxChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxChiTiet.Location = new System.Drawing.Point(0, 0);
            this.gbxChiTiet.Name = "gbxChiTiet";
            this.gbxChiTiet.Size = new System.Drawing.Size(373, 248);
            this.gbxChiTiet.TabIndex = 2;
            this.gbxChiTiet.TabStop = false;
            this.gbxChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AutoGenerateColumns = false;
            this.dataGridViewCTHD.ColumnHeadersHeight = 29;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChiTietHoaDonDataGridViewTextBoxColumn,
            this.soGheDataGridViewTextBoxColumn,
            this.maHoaDonDataGridViewTextBoxColumn,
            this.giaVeDataGridViewTextBoxColumn});
            this.dataGridViewCTHD.DataSource = this.chiTietHoaDonBindingSource;
            this.dataGridViewCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(367, 227);
            this.dataGridViewCTHD.TabIndex = 0;
            // 
            // maChiTietHoaDonDataGridViewTextBoxColumn
            // 
            this.maChiTietHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaChiTietHoaDon";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.HeaderText = "MaChiTietHoaDon";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChiTietHoaDonDataGridViewTextBoxColumn.Name = "maChiTietHoaDonDataGridViewTextBoxColumn";
            this.maChiTietHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // soGheDataGridViewTextBoxColumn
            // 
            this.soGheDataGridViewTextBoxColumn.DataPropertyName = "SoGhe";
            this.soGheDataGridViewTextBoxColumn.HeaderText = "SoGhe";
            this.soGheDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soGheDataGridViewTextBoxColumn.Name = "soGheDataGridViewTextBoxColumn";
            this.soGheDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaVeDataGridViewTextBoxColumn
            // 
            this.giaVeDataGridViewTextBoxColumn.DataPropertyName = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.HeaderText = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaVeDataGridViewTextBoxColumn.Name = "giaVeDataGridViewTextBoxColumn";
            this.giaVeDataGridViewTextBoxColumn.Width = 125;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataSource = typeof(RapPhimNew.Models.ChiTietHoaDon);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(RapPhimNew.Models.KhachHang);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbxHoaDon);
            this.panel2.Controls.Add(this.gbxChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(430, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 450);
            this.panel2.TabIndex = 4;
            // 
            // khachHangComboBox
            // 
            this.khachHangComboBox.DataSource = this.khachHangBindingSource;
            this.khachHangComboBox.DisplayMember = "TenKhachHang";
            this.khachHangComboBox.FormattingEnabled = true;
            this.khachHangComboBox.Location = new System.Drawing.Point(106, 259);
            this.khachHangComboBox.Name = "khachHangComboBox";
            this.khachHangComboBox.Size = new System.Drawing.Size(300, 24);
            this.khachHangComboBox.TabIndex = 0;
            this.khachHangComboBox.ValueMember = "MaKhachHang";
            this.khachHangComboBox.SelectedIndexChanged += new System.EventHandler(this.khachHangComboBox_SelectedIndexChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(12, 266);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(77, 16);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(106, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(300, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiKhachHang
            // 
            this.btnTaiKhachHang.Location = new System.Drawing.Point(15, 305);
            this.btnTaiKhachHang.Name = "btnTaiKhachHang";
            this.btnTaiKhachHang.Size = new System.Drawing.Size(74, 31);
            this.btnTaiKhachHang.TabIndex = 3;
            this.btnTaiKhachHang.Text = "Refesh";
            this.btnTaiKhachHang.UseVisualStyleBackColor = true;
            this.btnTaiKhachHang.Click += new System.EventHandler(this.btnTaiKhachHang_Click);
            // 
            // soGheTextBox
            // 
            this.soGheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "SoGhe", true));
            this.soGheTextBox.Location = new System.Drawing.Point(199, 110);
            this.soGheTextBox.Name = "soGheTextBox";
            this.soGheTextBox.Size = new System.Drawing.Size(100, 22);
            this.soGheTextBox.TabIndex = 11;
            // 
            // maHoaDonTextBox
            // 
            this.maHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "MaHoaDon", true));
            this.maHoaDonTextBox.Location = new System.Drawing.Point(199, 82);
            this.maHoaDonTextBox.Name = "maHoaDonTextBox";
            this.maHoaDonTextBox.Size = new System.Drawing.Size(100, 22);
            this.maHoaDonTextBox.TabIndex = 9;
            // 
            // maChiTietHoaDonTextBox
            // 
            this.maChiTietHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "MaChiTietHoaDon", true));
            this.maChiTietHoaDonTextBox.Location = new System.Drawing.Point(199, 54);
            this.maChiTietHoaDonTextBox.Name = "maChiTietHoaDonTextBox";
            this.maChiTietHoaDonTextBox.Size = new System.Drawing.Size(100, 22);
            this.maChiTietHoaDonTextBox.TabIndex = 7;
            // 
            // giaVeTextBox
            // 
            this.giaVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "GiaVe", true));
            this.giaVeTextBox.Location = new System.Drawing.Point(199, 26);
            this.giaVeTextBox.Name = "giaVeTextBox";
            this.giaVeTextBox.Size = new System.Drawing.Size(100, 22);
            this.giaVeTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaChiTiet);
            this.panel1.Controls.Add(giaVeLabel);
            this.panel1.Controls.Add(this.giaVeTextBox);
            this.panel1.Controls.Add(maChiTietHoaDonLabel);
            this.panel1.Controls.Add(this.maChiTietHoaDonTextBox);
            this.panel1.Controls.Add(maHoaDonLabel);
            this.panel1.Controls.Add(this.maHoaDonTextBox);
            this.panel1.Controls.Add(soGheLabel);
            this.panel1.Controls.Add(this.soGheTextBox);
            this.panel1.Controls.Add(this.btnTaiKhachHang);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblKhachHang);
            this.panel1.Controls.Add(this.khachHangComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 450);
            this.panel1.TabIndex = 3;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Location = new System.Drawing.Point(46, 153);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(253, 23);
            this.btnXoaChiTiet.TabIndex = 12;
            this.btnXoaChiTiet.Text = "Xóa chi tiết ";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDon";
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.gbxHoaDon.ResumeLayout(false);
            this.gbxChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.GroupBox gbxHoaDon;
        private System.Windows.Forms.GroupBox gbxChiTiet;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiTietHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox khachHangComboBox;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiKhachHang;
        private System.Windows.Forms.TextBox soGheTextBox;
        private System.Windows.Forms.TextBox maHoaDonTextBox;
        private System.Windows.Forms.TextBox maChiTietHoaDonTextBox;
        private System.Windows.Forms.TextBox giaVeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaChiTiet;
    }
}