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
    public partial class FormQLSinhVien : Form
    {
        public FormQLSinhVien()
        {
            InitializeComponent();
        }

        private void FormQLSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSinhvien.Student' table. You can move, or remove it, as needed.
            this.StudentTableAdapter.Fill(this.DataSetSinhvien.Student);

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
    }
}
