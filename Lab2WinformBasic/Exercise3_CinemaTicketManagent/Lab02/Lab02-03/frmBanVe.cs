using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class frmBanVe : Form
    {
        const int SEAT_NUM = 15;
        const int ROW_NUM = 5;
        const int COL_NUM = SEAT_NUM / ROW_NUM;
        int[] prices = { 5000,6500,8000 };
        int total = 0;
        Color DEFAULT_COLOR = Color.White;
        public frmBanVe()
        {
            InitializeComponent();
            txtThanhTien.ReadOnly = true;
        }
        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor != Color.Yellow)
            {
                int seatIndex = int.Parse(btn.Text) - 1;
                if (btn.BackColor != Color.Blue) { 
                    btn.BackColor = Color.Blue;
                    total += prices[seatIndex / 5];
                }
                else
                {
                    btn.BackColor = DEFAULT_COLOR;
                    total -= prices[seatIndex / 5];
                }
                txtThanhTien.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Đã có người mua chỗ này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmBanVe_Load(object sender, EventArgs e)
        {
            txtThanhTien.Focus();
            
            int btnSeatSize = 120;
            Button btn;
            int btnIndex = 0;
            Control lastControl= null;
            for (int i = 0; i < COL_NUM; i++)
            {
                for (int j = 0; j < ROW_NUM; j++)
                {
                    string btnText = (btnIndex + 1).ToString();
                    btn = new Button();
                    btn.BackColor = DEFAULT_COLOR;
                    btn.TabIndex = btnIndex;
                    btn.Click += new EventHandler(btnSeat_Click);
                    btn.Size = new Size(btnSeatSize, btnSeatSize);
                    btn.Text = btnText;
                    flpChoNgoi.Controls.Add(btn);
                    btnIndex++;
                    lastControl = btn;
                }
                flpChoNgoi.SetFlowBreak(lastControl, true);
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flpChoNgoi.Controls.OfType<Button>().Where(b => b.BackColor == Color.Blue))
                btn.BackColor = Color.Yellow;
            total = 0;
            txtThanhTien.Text = total.ToString();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flpChoNgoi.Controls.OfType<Button>().Where(b => b.BackColor == Color.Blue))
                btn.BackColor = DEFAULT_COLOR;
            total = 0;
            txtThanhTien.Text = total.ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
