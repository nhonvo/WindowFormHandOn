namespace Finaltest
{
    partial class frmXetNghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXetNghiem));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.danhSáchNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCtyĐãTestTheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.cbbCompany = new System.Windows.Forms.ComboBox();
            this.cbNegative = new System.Windows.Forms.CheckBox();
            this.cbPositive = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvXetNghiem = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plInfor = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).BeginInit();
            this.plInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNVToolStripMenuItem,
            this.danhSáchCtyĐãTestTheoToolStripMenuItem,
            this.toolStripSeparator1,
            this.xuấtBáoCáoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 24);
            this.toolStripDropDownButton1.Text = "Chức năng";
            // 
            // danhSáchNVToolStripMenuItem
            // 
            this.danhSáchNVToolStripMenuItem.Name = "danhSáchNVToolStripMenuItem";
            this.danhSáchNVToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.danhSáchNVToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.danhSáchNVToolStripMenuItem.Text = "Danh sách NV Dương Tính";
            this.danhSáchNVToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNVToolStripMenuItem_Click);
            // 
            // danhSáchCtyĐãTestTheoToolStripMenuItem
            // 
            this.danhSáchCtyĐãTestTheoToolStripMenuItem.Name = "danhSáchCtyĐãTestTheoToolStripMenuItem";
            this.danhSáchCtyĐãTestTheoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.danhSáchCtyĐãTestTheoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.danhSáchCtyĐãTestTheoToolStripMenuItem.Text = "Danh sách Cty đã test theo Y/C";
            this.danhSáchCtyĐãTestTheoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCtyĐãTestTheoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CCCD/CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin xét nghiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "SLXN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "KQ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Công ty";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 148);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(172, 22);
            this.txtId.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(148, 111);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(172, 22);
            this.txtSLXN.TabIndex = 10;
            this.txtSLXN.Text = "1";
            // 
            // cbbCompany
            // 
            this.cbbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompany.FormattingEnabled = true;
            this.cbbCompany.Location = new System.Drawing.Point(148, 219);
            this.cbbCompany.Name = "cbbCompany";
            this.cbbCompany.Size = new System.Drawing.Size(165, 24);
            this.cbbCompany.TabIndex = 11;
            // 
            // cbNegative
            // 
            this.cbNegative.AutoSize = true;
            this.cbNegative.Checked = true;
            this.cbNegative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNegative.Location = new System.Drawing.Point(155, 164);
            this.cbNegative.Name = "cbNegative";
            this.cbNegative.Size = new System.Drawing.Size(72, 20);
            this.cbNegative.TabIndex = 12;
            this.cbNegative.Text = "Âm tính";
            this.cbNegative.UseVisualStyleBackColor = true;
            // 
            // cbPositive
            // 
            this.cbPositive.AutoSize = true;
            this.cbPositive.Location = new System.Drawing.Point(156, 190);
            this.cbPositive.Name = "cbPositive";
            this.cbPositive.Size = new System.Drawing.Size(92, 20);
            this.cbPositive.TabIndex = 13;
            this.cbPositive.Text = "Dương tính";
            this.cbPositive.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(331, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 42);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thông tin xét nghiệm";
            // 
            // dgvXetNghiem
            // 
            this.dgvXetNghiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXetNghiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvXetNghiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXetNghiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clSLXN,
            this.clResult});
            this.dgvXetNghiem.Location = new System.Drawing.Point(497, 110);
            this.dgvXetNghiem.Name = "dgvXetNghiem";
            this.dgvXetNghiem.RowHeadersWidth = 51;
            this.dgvXetNghiem.RowTemplate.Height = 24;
            this.dgvXetNghiem.Size = new System.Drawing.Size(526, 406);
            this.dgvXetNghiem.TabIndex = 17;
            this.dgvXetNghiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXetNghiem_CellClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "CMND/CCCD";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            // 
            // clName
            // 
            this.clName.HeaderText = "Họ và tên";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            // 
            // clSLXN
            // 
            this.clSLXN.HeaderText = "Số lần XN";
            this.clSLXN.MinimumWidth = 6;
            this.clSLXN.Name = "clSLXN";
            // 
            // clResult
            // 
            this.clResult.HeaderText = "Kết quả";
            this.clResult.MinimumWidth = 6;
            this.clResult.Name = "clResult";
            // 
            // plInfor
            // 
            this.plInfor.Controls.Add(this.cbbCompany);
            this.plInfor.Controls.Add(this.label3);
            this.plInfor.Controls.Add(this.label4);
            this.plInfor.Controls.Add(this.btnUpdate);
            this.plInfor.Controls.Add(this.label5);
            this.plInfor.Controls.Add(this.label6);
            this.plInfor.Controls.Add(this.cbPositive);
            this.plInfor.Controls.Add(this.label7);
            this.plInfor.Controls.Add(this.cbNegative);
            this.plInfor.Controls.Add(this.txtName);
            this.plInfor.Controls.Add(this.txtSLXN);
            this.plInfor.Location = new System.Drawing.Point(24, 198);
            this.plInfor.Name = "plInfor";
            this.plInfor.Size = new System.Drawing.Size(396, 318);
            this.plInfor.TabIndex = 18;
            // 
            // frmXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 537);
            this.Controls.Add(this.plInfor);
            this.Controls.Add(this.dgvXetNghiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmXetNghiem";
            this.Text = "Quản lý xét nghiệm";
            this.Load += new System.EventHandler(this.frmXetNghiem_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).EndInit();
            this.plInfor.ResumeLayout(false);
            this.plInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCtyĐãTestTheoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.ComboBox cbbCompany;
        private System.Windows.Forms.CheckBox cbNegative;
        private System.Windows.Forms.CheckBox cbPositive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvXetNghiem;
        private System.Windows.Forms.Panel plInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clResult;
    }
}