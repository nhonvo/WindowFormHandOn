using RapChieuNew.Models;
using RapPhimNew.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RapPhimNew
{
    public partial class frmRapPhim : Form
    {
        RapChieuPhimContext data = new RapChieuPhimContext();
        private const int SEAT_NUMS = 15;
        private const int SEATS_COL = 5;
        private const int SEATS_ROW = 3;
        double sum = 0;
        public frmRapPhim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button;
            for (int i = 0; i < SEAT_NUMS; i++)
            {
                button = new Button();
                int width = 60;
                int height = 60;
                bool daMua = data.ChiTietHoaDons.Any(x => x.SoGhe == (i + 1));
                if (daMua)
                {
                    button.BackColor = Color.Yellow;
                }
                else
                {
                    button.BackColor = Color.White;
                }
                button.Text = (i + 1).ToString();
                button.Size = new Size(width, height);
                button.Click += new EventHandler(button_Click);
                flowPanelSeats.Controls.Add(button);
            }
            cbxKhachHang.DataSource = data.KhachHangs.ToList();
            cbxKhachHang.ValueMember = "MaKhachHang";
            cbxKhachHang.DisplayMember = "TenKhachHang";
        }

        private bool isChoosen = false;
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Da co nguoi dat cho rui :((");
                return;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                sum -= TinhTien(int.Parse(btn.Text));
            }
            else if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                sum += TinhTien(int.Parse(btn.Text));
            }

            //foreach (Control ctr in flowPanelSeats.Controls.OfType<Button>().Where(x => x.BackColor == Color.Blue))
            //    {
            //    sum += TinhTien(int.Parse(ctr.Text));
            //    }
            textBoxPrice.Text = sum.ToString();
        }

        private double TinhTien(int soGhe)
        {
            if (soGhe <= 5)
            {
                return 5000;
            }
            else if (soGhe <= 10)
            {
                return 6500;
            }
            else
            {
                return 8000;
            }
        }
        private void dapGhe(Color c1, Color c2)
        {
            foreach (Control ctr in flowPanelSeats.Controls.OfType<Button>().Where(x => x.BackColor == c1))
            {
                ctr.BackColor = c2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowPanelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dapGhe(Color.Yellow, Color.White);
        }
        private void themChiTiet(int maHoaDon, int soGhe, double giaVe)
        {
            ChiTietHoaDon newCTHD = new ChiTietHoaDon();
            newCTHD.MaHoaDon = maHoaDon;
            newCTHD.SoGhe = soGhe;
            newCTHD.GiaVe = giaVe;
            data.ChiTietHoaDons.Add(newCTHD);
        }
        private int themHoaDon(int maKhachHang, double tongTien)
        {
            try
            {
                HoaDon newHoaDon = new HoaDon();
                newHoaDon.MaKhachHang = maKhachHang;
                newHoaDon.TongTien = tongTien;
                newHoaDon.NgayLap = DateTime.Now;
                data.HoaDons.Add(newHoaDon);
                data.SaveChanges();
                return newHoaDon.MaHoaDon;
            }
            catch (Exception ex)
            {
                throw new Exception("loi them HD " + ex.Message);
            }



        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int maKhachHang = Convert.ToInt32(cbxKhachHang.SelectedValue);
            double tongTien = sum;

            int maHoaDon;
            try
            {
                maHoaDon = themHoaDon(maKhachHang, tongTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            foreach (Button choNgoi in flowPanelSeats.Controls.OfType<Button>().Where(x => x.BackColor == Color.Blue))
            {
                int soGhe = Convert.ToInt32(choNgoi.Text);
                double giaVe = TinhTien(soGhe);
                themChiTiet(maHoaDon, soGhe, giaVe);
            }
            data.SaveChanges();
            dapGhe(Color.Blue, Color.Yellow);
            sum = 0;
            textBoxPrice.Text = "0";
        }
    }
}