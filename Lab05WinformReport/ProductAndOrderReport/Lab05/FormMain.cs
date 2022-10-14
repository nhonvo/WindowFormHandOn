using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void bÁOCÁOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dANHSÁCHSINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSinhVien f = new FormQLSinhVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
