
namespace Lab02_04
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
            this.lbSTK = new System.Windows.Forms.Label();
            this.tbSTK = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hovaten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.tbHVT = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.lbHVT = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTTien = new System.Windows.Forms.TextBox();
            this.lbTTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Location = new System.Drawing.Point(140, 88);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(87, 17);
            this.lbSTK.TabIndex = 0;
            this.lbSTK.Text = "Số tài khoản";
            // 
            // tbSTK
            // 
            this.tbSTK.Location = new System.Drawing.Point(251, 85);
            this.tbSTK.Name = "tbSTK";
            this.tbSTK.Size = new System.Drawing.Size(468, 22);
            this.tbSTK.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Location = new System.Drawing.Point(387, 243);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 27);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm/Sửa";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.STK,
            this.Hovaten,
            this.Diachi,
            this.Sodu});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 276);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(752, 254);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 41;
            // 
            // STK
            // 
            this.STK.Text = "Số tài khoản";
            this.STK.Width = 101;
            // 
            // Hovaten
            // 
            this.Hovaten.Text = "Tên khách hàng";
            this.Hovaten.Width = 136;
            // 
            // Diachi
            // 
            this.Diachi.Text = "Địa chỉ";
            this.Diachi.Width = 202;
            // 
            // Sodu
            // 
            this.Sodu.Text = "Số dư";
            this.Sodu.Width = 79;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(494, 243);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 27);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(600, 243);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 27);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // tbHVT
            // 
            this.tbHVT.Location = new System.Drawing.Point(251, 123);
            this.tbHVT.Name = "tbHVT";
            this.tbHVT.Size = new System.Drawing.Size(468, 22);
            this.tbHVT.TabIndex = 1;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(251, 164);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(468, 22);
            this.tbDC.TabIndex = 1;
            // 
            // tbTien
            // 
            this.tbTien.Location = new System.Drawing.Point(251, 202);
            this.tbTien.Name = "tbTien";
            this.tbTien.Size = new System.Drawing.Size(468, 22);
            this.tbTien.TabIndex = 1;
            // 
            // lbHVT
            // 
            this.lbHVT.AutoSize = true;
            this.lbHVT.Location = new System.Drawing.Point(116, 123);
            this.lbHVT.Name = "lbHVT";
            this.lbHVT.Size = new System.Drawing.Size(111, 17);
            this.lbHVT.TabIndex = 0;
            this.lbHVT.Text = "Tên khách hàng";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Location = new System.Drawing.Point(98, 164);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(129, 17);
            this.lbDC.TabIndex = 0;
            this.lbDC.Text = "Địa chỉ khách hàng";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Location = new System.Drawing.Point(68, 202);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(159, 17);
            this.lbTien.TabIndex = 0;
            this.lbTien.Text = "Số tiền trong tài khoảng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(123, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // tbTTien
            // 
            this.tbTTien.Enabled = false;
            this.tbTTien.Location = new System.Drawing.Point(607, 540);
            this.tbTTien.Name = "tbTTien";
            this.tbTTien.Size = new System.Drawing.Size(169, 22);
            this.tbTTien.TabIndex = 1;
            // 
            // lbTTien
            // 
            this.lbTTien.AutoSize = true;
            this.lbTTien.Location = new System.Drawing.Point(533, 543);
            this.lbTTien.Name = "lbTTien";
            this.lbTTien.Size = new System.Drawing.Size(68, 17);
            this.lbTTien.TabIndex = 0;
            this.lbTTien.Text = "Tổng tiền";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 574);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTTien);
            this.Controls.Add(this.tbTien);
            this.Controls.Add(this.tbDC);
            this.Controls.Add(this.tbHVT);
            this.Controls.Add(this.tbSTK);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbDC);
            this.Controls.Add(this.lbHVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTTien);
            this.Controls.Add(this.lbSTK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.TextBox tbSTK;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox tbHVT;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.Label lbHVT;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader STK;
        private System.Windows.Forms.ColumnHeader Hovaten;
        private System.Windows.Forms.ColumnHeader Diachi;
        private System.Windows.Forms.ColumnHeader Sodu;
        private System.Windows.Forms.TextBox tbTTien;
        private System.Windows.Forms.Label lbTTien;
        private int stt = 1;
        private int tong = 0;

    }
}

