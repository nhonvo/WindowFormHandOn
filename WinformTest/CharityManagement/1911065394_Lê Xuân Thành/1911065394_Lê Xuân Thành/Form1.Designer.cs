
namespace _1911065394_Lê_Xuân_Thành
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvthongtingiaodich = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácGiaoDịchGửiTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốDưCuốiKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.cbbstk = new System.Windows.Forms.ComboBox();
            this.cbbgiaodich = new System.Windows.Forms.ComboBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvloaigd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtingiaodich)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtnoidung);
            this.groupBox1.Controls.Add(this.cbbgiaodich);
            this.groupBox1.Controls.Add(this.cbbstk);
            this.groupBox1.Controls.Add(this.txtsotien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao dịch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số TK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "GD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung";
            // 
            // dgvthongtingiaodich
            // 
            this.dgvthongtingiaodich.AllowUserToAddRows = false;
            this.dgvthongtingiaodich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongtingiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtingiaodich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvloaigd,
            this.dgvsotien,
            this.dgvnoidung});
            this.dgvthongtingiaodich.Location = new System.Drawing.Point(358, 112);
            this.dgvthongtingiaodich.Name = "dgvthongtingiaodich";
            this.dgvthongtingiaodich.RowHeadersWidth = 51;
            this.dgvthongtingiaodich.RowTemplate.Height = 24;
            this.dgvthongtingiaodich.Size = new System.Drawing.Size(619, 390);
            this.dgvthongtingiaodich.TabIndex = 1;
            this.dgvthongtingiaodich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthongtingiaodich_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(314, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "THÔNG TIN GIAO DỊCH";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cácGiaoDịchGửiTiềnToolStripMenuItem,
            this.sốDưCuốiKỳToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // cácGiaoDịchGửiTiềnToolStripMenuItem
            // 
            this.cácGiaoDịchGửiTiềnToolStripMenuItem.Name = "cácGiaoDịchGửiTiềnToolStripMenuItem";
            this.cácGiaoDịchGửiTiềnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cácGiaoDịchGửiTiềnToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.cácGiaoDịchGửiTiềnToolStripMenuItem.Text = "Các giao dịch gửi tiền";
            this.cácGiaoDịchGửiTiềnToolStripMenuItem.Click += new System.EventHandler(this.cácGiaoDịchGửiTiềnToolStripMenuItem_Click);
            // 
            // sốDưCuốiKỳToolStripMenuItem
            // 
            this.sốDưCuốiKỳToolStripMenuItem.Name = "sốDưCuốiKỳToolStripMenuItem";
            this.sốDưCuốiKỳToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.sốDưCuốiKỳToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.sốDưCuốiKỳToolStripMenuItem.Text = "Số dư cuối kỳ";
            this.sốDưCuốiKỳToolStripMenuItem.Click += new System.EventHandler(this.sốDưCuốiKỳToolStripMenuItem_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(97, 147);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(184, 22);
            this.txtsotien.TabIndex = 5;
            // 
            // cbbstk
            // 
            this.cbbstk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbstk.FormattingEnabled = true;
            this.cbbstk.Location = new System.Drawing.Point(92, 51);
            this.cbbstk.Name = "cbbstk";
            this.cbbstk.Size = new System.Drawing.Size(188, 24);
            this.cbbstk.TabIndex = 6;
            // 
            // cbbgiaodich
            // 
            this.cbbgiaodich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbgiaodich.FormattingEnabled = true;
            this.cbbgiaodich.Items.AddRange(new object[] {
            "Nhận tiền",
            "Rút tiền"});
            this.cbbgiaodich.Location = new System.Drawing.Point(92, 96);
            this.cbbgiaodich.Name = "cbbgiaodich";
            this.cbbgiaodich.Size = new System.Drawing.Size(188, 24);
            this.cbbgiaodich.TabIndex = 7;
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(96, 197);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(184, 138);
            this.txtnoidung.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            // 
            // dgvloaigd
            // 
            this.dgvloaigd.HeaderText = "Loại GD";
            this.dgvloaigd.MinimumWidth = 6;
            this.dgvloaigd.Name = "dgvloaigd";
            // 
            // dgvsotien
            // 
            this.dgvsotien.HeaderText = "Số tiền";
            this.dgvsotien.MinimumWidth = 6;
            this.dgvsotien.Name = "dgvsotien";
            // 
            // dgvnoidung
            // 
            this.dgvnoidung.HeaderText = "Nội dung";
            this.dgvnoidung.MinimumWidth = 6;
            this.dgvnoidung.Name = "dgvnoidung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvthongtingiaodich);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý thông tin giao dịch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtingiaodich)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvthongtingiaodich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácGiaoDịchGửiTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốDưCuốiKỳToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.ComboBox cbbstk;
        private System.Windows.Forms.ComboBox cbbgiaodich;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloaigd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnoidung;
    }
}

