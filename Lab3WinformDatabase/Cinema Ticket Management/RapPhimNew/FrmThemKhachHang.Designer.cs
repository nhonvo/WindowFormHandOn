namespace RapPhimNew
{
    partial class FrmThemKhachHang
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
            System.Windows.Forms.Label tenKhachHangLabel;
            this.tenKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            tenKhachHangLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenKhachHangLabel
            // 
            tenKhachHangLabel.AutoSize = true;
            tenKhachHangLabel.Location = new System.Drawing.Point(16, 26);
            tenKhachHangLabel.Name = "tenKhachHangLabel";
            tenKhachHangLabel.Size = new System.Drawing.Size(106, 16);
            tenKhachHangLabel.TabIndex = 3;
            tenKhachHangLabel.Text = "Tên khách hàng:";
            // 
            // tenKhachHangTextBox
            // 
            this.tenKhachHangTextBox.Location = new System.Drawing.Point(132, 23);
            this.tenKhachHangTextBox.Name = "tenKhachHangTextBox";
            this.tenKhachHangTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenKhachHangTextBox.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(132, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmThemKhachHang
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 113);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(tenKhachHangLabel);
            this.Controls.Add(this.tenKhachHangTextBox);
            this.Name = "FrmThemKhachHang";
            this.Text = "FrmThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tenKhachHangTextBox;
        private System.Windows.Forms.Button btnThem;
    }
}