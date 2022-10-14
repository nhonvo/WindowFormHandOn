using System.Windows.Forms;

namespace RapPhimNew
{
    partial class frmRapPhim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScreen = new System.Windows.Forms.Label();
            this.flowPanelSeats = new System.Windows.Forms.FlowLayoutPanel();
            this.tablePanelFunction = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKhachHang = new System.Windows.Forms.ComboBox();
            this.tablePanelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScreen
            // 
            this.labelScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelScreen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelScreen.Location = new System.Drawing.Point(0, 0);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(799, 50);
            this.labelScreen.TabIndex = 0;
            this.labelScreen.Text = "MÀN ẢNH";
            this.labelScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPanelSeats
            // 
            this.flowPanelSeats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanelSeats.Location = new System.Drawing.Point(0, 50);
            this.flowPanelSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowPanelSeats.Name = "flowPanelSeats";
            this.flowPanelSeats.Size = new System.Drawing.Size(799, 240);
            this.flowPanelSeats.TabIndex = 1;
            this.flowPanelSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelSeats_Paint);
            // 
            // tablePanelFunction
            // 
            this.tablePanelFunction.ColumnCount = 3;
            this.tablePanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tablePanelFunction.Controls.Add(this.buttonExit, 1, 1);
            this.tablePanelFunction.Controls.Add(this.labelPrice, 0, 0);
            this.tablePanelFunction.Controls.Add(this.textBoxPrice, 1, 0);
            this.tablePanelFunction.Controls.Add(this.button1, 2, 1);
            this.tablePanelFunction.Controls.Add(this.buttonCancel, 0, 1);
            this.tablePanelFunction.Controls.Add(this.label1, 0, 2);
            this.tablePanelFunction.Controls.Add(this.cbxKhachHang, 1, 2);
            this.tablePanelFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelFunction.Location = new System.Drawing.Point(0, 290);
            this.tablePanelFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanelFunction.Name = "tablePanelFunction";
            this.tablePanelFunction.RowCount = 3;
            this.tablePanelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tablePanelFunction.Size = new System.Drawing.Size(799, 414);
            this.tablePanelFunction.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonExit.Location = new System.Drawing.Point(449, 229);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 63);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Mua";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPrice.Location = new System.Drawing.Point(100, 72);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(132, 30);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Thành tiền:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrice.Location = new System.Drawing.Point(427, 70);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(144, 34);
            this.textBoxPrice.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(682, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kết thúc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(116, 233);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 56);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khach Hang";
            // 
            // cbxKhachHang
            // 
            this.cbxKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhachHang.FormattingEnabled = true;
            this.cbxKhachHang.Location = new System.Drawing.Point(336, 367);
            this.cbxKhachHang.Name = "cbxKhachHang";
            this.cbxKhachHang.Size = new System.Drawing.Size(324, 33);
            this.cbxKhachHang.TabIndex = 5;
            // 
            // frmRapPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 704);
            this.Controls.Add(this.tablePanelFunction);
            this.Controls.Add(this.flowPanelSeats);
            this.Controls.Add(this.labelScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRapPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Bán Vé Rạp Phim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablePanelFunction.ResumeLayout(false);
            this.tablePanelFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelScreen;
        private FlowLayoutPanel flowPanelSeats;
        private TableLayoutPanel tablePanelFunction;
        private Button buttonExit;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button buttonCancel;
        private Button button1;
        private Label label1;
        private ComboBox cbxKhachHang;
    }
}