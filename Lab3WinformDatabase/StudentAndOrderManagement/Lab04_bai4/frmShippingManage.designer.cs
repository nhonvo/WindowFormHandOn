
namespace Lab04_Bai4
{
    partial class frmShippingManage
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
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbShowAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvOrderManagement = new System.Windows.Forms.DataGridView();
            this.dgvstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngaygiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeEnd);
            this.groupBox1.Controls.Add(this.dateTimeStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbShowAll);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy/MM/dd";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(395, 98);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(158, 22);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy/MM/dd";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(199, 98);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(146, 22);
            this.dateTimeStart.TabIndex = 1;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // cbbShowAll
            // 
            this.cbbShowAll.AutoSize = true;
            this.cbbShowAll.Location = new System.Drawing.Point(47, 43);
            this.cbbShowAll.Name = "cbbShowAll";
            this.cbbShowAll.Size = new System.Drawing.Size(160, 20);
            this.cbbShowAll.TabIndex = 0;
            this.cbbShowAll.Text = "Xem tất cả trong tháng";
            this.cbbShowAll.UseVisualStyleBackColor = true;
            this.cbbShowAll.CheckedChanged += new System.EventHandler(this.CBxemtatca_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng cộng :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(691, 462);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(62, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // dgvOrderManagement
            // 
            this.dgvOrderManagement.AllowUserToAddRows = false;
            this.dgvOrderManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvstt,
            this.dgvSohd,
            this.dgvngaydat,
            this.dgvngaygiao,
            this.dgvthanhtien});
            this.dgvOrderManagement.Location = new System.Drawing.Point(33, 160);
            this.dgvOrderManagement.Name = "dgvOrderManagement";
            this.dgvOrderManagement.RowHeadersWidth = 51;
            this.dgvOrderManagement.RowTemplate.Height = 24;
            this.dgvOrderManagement.Size = new System.Drawing.Size(720, 286);
            this.dgvOrderManagement.TabIndex = 4;
            // 
            // dgvstt
            // 
            this.dgvstt.HeaderText = "STT";
            this.dgvstt.MinimumWidth = 6;
            this.dgvstt.Name = "dgvstt";
            // 
            // dgvSohd
            // 
            this.dgvSohd.HeaderText = "Số hóa đơn";
            this.dgvSohd.MinimumWidth = 6;
            this.dgvSohd.Name = "dgvSohd";
            // 
            // dgvngaydat
            // 
            this.dgvngaydat.HeaderText = "Ngày đặt hàng";
            this.dgvngaydat.MinimumWidth = 6;
            this.dgvngaydat.Name = "dgvngaydat";
            // 
            // dgvngaygiao
            // 
            this.dgvngaygiao.HeaderText = "Ngày giao hàng";
            this.dgvngaygiao.MinimumWidth = 6;
            this.dgvngaygiao.Name = "dgvngaygiao";
            // 
            // dgvthanhtien
            // 
            this.dgvthanhtien.HeaderText = "Thành tiền";
            this.dgvthanhtien.MinimumWidth = 6;
            this.dgvthanhtien.Name = "dgvthanhtien";
            // 
            // frmQldonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.dgvOrderManagement);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQldonhang";
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.frmQldonhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbbShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvOrderManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngaygiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvthanhtien;
    }
}

