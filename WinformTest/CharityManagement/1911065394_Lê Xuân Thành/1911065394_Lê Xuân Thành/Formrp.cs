using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911065394_Lê_Xuân_Thành
{
    public partial class Formrp : Form
    {
        public Formrp()
        {
            InitializeComponent();
        }

        private void Formrp_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
