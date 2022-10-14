using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1_Caculator
{
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float Number1 = float.Parse(tbNumber1.Text);
                float Number2 = float.Parse(tbNumber2.Text);
                float result = Number1 + Number2;
                tbAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban phai nhap so!!!", "Loi");
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            try
            {
                float Number1 = float.Parse(tbNumber1.Text);
                float Number2 = float.Parse(tbNumber2.Text);
                float result = Number1 - Number2;
                tbAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban phai nhap so!!!", "Loi");
            }
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            try
            {
                float Number1 = float.Parse(tbNumber1.Text);
                float Number2 = float.Parse(tbNumber2.Text);
                float result = Number1 * Number2;
                tbAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban phai nhap so!!!", "Loi");
            }
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            try
            {
                float Number1 = float.Parse(tbNumber1.Text);
                float Number2 = float.Parse(tbNumber2.Text);
                float result = (Number1 / Number2);
                tbAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban phai nhap so!!!", "Loi");
            }
        }

    }
}
