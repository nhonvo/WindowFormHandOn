
namespace Lab02_02
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
            this.tbMSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMSV = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.tbHVT = new System.Windows.Forms.TextBox();
            this.lbHVT = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbDTB = new System.Windows.Forms.Label();
            this.tbDTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.tbNu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMSV
            // 
            this.tbMSV.Location = new System.Drawing.Point(158, 28);
            this.tbMSV.Name = "tbMSV";
            this.tbMSV.Size = new System.Drawing.Size(121, 22);
            this.tbMSV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(118, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMSV
            // 
            this.lbMSV.AutoSize = true;
            this.lbMSV.Location = new System.Drawing.Point(41, 28);
            this.lbMSV.Name = "lbMSV";
            this.lbMSV.Size = new System.Drawing.Size(91, 17);
            this.lbMSV.TabIndex = 3;
            this.lbMSV.Text = "Mã Sinh Viên";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(158, 154);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "NNA"});
            this.cbKhoa.Location = new System.Drawing.Point(158, 219);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbKhoa.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(274, 154);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // tbHVT
            // 
            this.tbHVT.Location = new System.Drawing.Point(158, 82);
            this.tbHVT.Name = "tbHVT";
            this.tbHVT.Size = new System.Drawing.Size(226, 22);
            this.tbHVT.TabIndex = 1;
            // 
            // lbHVT
            // 
            this.lbHVT.AutoSize = true;
            this.lbHVT.Location = new System.Drawing.Point(41, 87);
            this.lbHVT.Name = "lbHVT";
            this.lbHVT.Size = new System.Drawing.Size(74, 17);
            this.lbHVT.TabIndex = 3;
            this.lbHVT.Text = "Họ và Tên";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Location = new System.Drawing.Point(41, 154);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(65, 17);
            this.lbGT.TabIndex = 3;
            this.lbGT.Text = "Giới Tính";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(41, 226);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(41, 17);
            this.lbKhoa.TabIndex = 3;
            this.lbKhoa.Text = "Khoa";
            // 
            // lbDTB
            // 
            this.lbDTB.AutoSize = true;
            this.lbDTB.Location = new System.Drawing.Point(41, 287);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(36, 17);
            this.lbDTB.TabIndex = 3;
            this.lbDTB.Text = "ĐTB";
            // 
            // tbDTB
            // 
            this.tbDTB.Location = new System.Drawing.Point(158, 282);
            this.tbDTB.Name = "tbDTB";
            this.tbDTB.Size = new System.Drawing.Size(121, 22);
            this.tbDTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHVT);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.tbMSV);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.tbDTB);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbMSV);
            this.groupBox1.Controls.Add(this.lbDTB);
            this.groupBox1.Controls.Add(this.lbHVT);
            this.groupBox1.Controls.Add(this.lbKhoa);
            this.groupBox1.Controls.Add(this.lbGT);
            this.groupBox1.Location = new System.Drawing.Point(85, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 370);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(380, 20);
            this.label6.MaximumSize = new System.Drawing.Size(800, 50);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(545, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng sv Nam";
            // 
            // tbNam
            // 
            this.tbNam.Enabled = false;
            this.tbNam.Location = new System.Drawing.Point(1095, 471);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(41, 22);
            this.tbNam.TabIndex = 1;
            // 
            // tbNu
            // 
            this.tbNu.Enabled = false;
            this.tbNu.Location = new System.Drawing.Point(1196, 471);
            this.tbNu.Name = "tbNu";
            this.tbNu.Size = new System.Drawing.Size(43, 22);
            this.tbNu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nữ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.Khoa,
            this.DTB,
            this.GioiTinh});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(537, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.FillWeight = 50F;
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 70F;
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.FillWeight = 30F;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.FillWeight = 20F;
            this.DTB.HeaderText = "DTB";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.FillWeight = 30F;
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbNu);
            this.Controls.Add(this.tbNam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMSV;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.TextBox tbHVT;
        private System.Windows.Forms.Label lbHVT;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbDTB;
        private System.Windows.Forms.TextBox tbDTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.TextBox tbNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private int tongnam=0;
        private int tongnu=0;
    }
}

