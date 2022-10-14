using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add(String stt, String stk, String hvt, String dc, String tien)
        {
            String[] row = { stt, stk, hvt, dc, tien };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                // kiem tra day du thong tin
                if (tbSTK.Text == "" || tbHVT.Text == "" || tbDC.Text == "" || tbTien.Text == "")
                    throw new Exception("Nhập đầy đủ thông tin");
                // kiem tra so tai khoan
                int selectrow = -1;
                for(int i=0; i< listView1.Items.Count; i++)
                {
                    if(listView1.Items[i].SubItems[1].Text == tbSTK.Text)
                    {
                        selectrow = i;
                        break;
                    }    
                }
                //them tai khoan
                String msg = "Thêm Thành Công";
                if (selectrow == -1)
                {
                    
                    add(stt.ToString(), tbSTK.Text, tbHVT.Text, tbDC.Text, tbTien.Text);
                    stt++;
                    tong = tong + int.Parse(tbTien.Text);//tinh tong tien
                    tbTTien.Text = tong.ToString();
                    tbSTK.Text = "";
                    tbHVT.Text = "";
                    tbDC.Text = "";
                    tbTien.Text = "";
                }
                else
                {
                    // cap nhat tai khoan
                    tong = tong - int.Parse(listView1.Items[selectrow].SubItems[4].Text);// tru so tien trc khi cap nhat
                    listView1.Items[selectrow].SubItems[1].Text = tbSTK.Text;
                    listView1.Items[selectrow].SubItems[2].Text = tbHVT.Text;
                    listView1.Items[selectrow].SubItems[3].Text = tbDC.Text;
                    listView1.Items[selectrow].SubItems[4].Text = tbTien.Text;
                    tong = tong + int.Parse(tbTien.Text);//tinh lai tong tien
                    tbTTien.Text = tong.ToString();
                    tbSTK.Text = "";
                    tbHVT.Text = "";
                    tbDC.Text = "";
                    tbTien.Text = "";
                    msg = "Cập Nhật Thành Công";
                }
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //tim tai khaon can xoa
                int selectrow = -1;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[1].Text == tbSTK.Text)
                    {
                        selectrow = i;
                        break;
                    }
                }
                if (selectrow == -1)
                {
                    MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                }
                else
                {
                    //xoa tai khoan
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        //cap nhay stt truoc khi xoa
                        for (int i = int.Parse(listView1.Items[selectrow].SubItems[0].Text); i < listView1.Items.Count; i++)
                        {
                            listView1.Items[i].SubItems[0].Text = (int.Parse(listView1.Items[i].SubItems[0].Text) - 1).ToString();
                        }
                        stt--;
                        listView1.Items[selectrow].Remove();
                        tong = tong - int.Parse(tbTien.Text);//cap nhat tong tien
                        tbTTien.Text = tong.ToString(); 
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    }    

                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbSTK.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbHVT.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbDC.Text = listView1.SelectedItems[0].SubItems[3].Text;
                tbTien.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
