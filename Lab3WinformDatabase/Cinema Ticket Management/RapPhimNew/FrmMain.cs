using RapChieuNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimNew
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            SetMenu(false);
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.dangNhapToolStripMenuItem.PerformClick();
        }

        private void SetMenu(bool status)
        {
            this.dangXuatToolStripMenuItem.Enabled = status;
            this.banVeToolStripMenuItem.Enabled = status;
            this.hoaDonToolStripMenuItem.Enabled = status;
            this.khachHangToolStripMenuItem.Enabled = status;
            this.dangNhapToolStripMenuItem.Enabled = !status;
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenChildForm("frmDangNhap"))
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.delegateDangNhap += FrmDangNhap_delegateDangNhap;
                frmDangNhap.StartPosition = FormStartPosition.CenterScreen;
                frmDangNhap.Show();
            }
        }

        private void FrmDangNhap_delegateDangNhap(object sender)
        {
            string quyen = (string)sender;
            if (quyen=="admin")
            {
                SetMenu(true);
            }
            else if (quyen=="nhanvien")
            {
                this.hoaDonToolStripMenuItem.Enabled = true;
            }
        }

        private bool OpenChildForm(string formName)
        {
            if (this.MdiChildren.Any(x => x.Name == formName))
            {
                this.MdiChildren.FirstOrDefault(x => x.Name == formName).Activate();
                return true;
            }
            return false;
        }

        private void banVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenChildForm("frmRapPhim"))
            {
                frmRapPhim frmRapPhim = new frmRapPhim();
                frmRapPhim.MdiParent = this;
                frmRapPhim.StartPosition = FormStartPosition.CenterScreen;
                frmRapPhim.Show();
            }
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenChildForm("frmHoaDon"))
            {
                FrmHoaDon frmHoaDon = new FrmHoaDon();
                frmHoaDon.MdiParent = this;
                frmHoaDon.StartPosition = FormStartPosition.CenterParent;
                frmHoaDon.Show();
            }
        }
    }
}
