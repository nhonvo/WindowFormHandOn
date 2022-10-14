using System;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.Text = "QTKD";
            rbNu.Checked = true;
            tbNam.Text = "0";
            tbNu.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // kiem tra ho ten diem !=""
                if (tbMSV.Text == "" || tbHVT.Text == "" || tbDTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                // kiem tra diem 0<<10
                float diem = float.Parse(tbDTB.Text);
                if (diem < 0 || diem > 10)
                    throw new Exception("Nhập điểm vượt quá 4.0");
                // kiểm tra datagrid có msv chua
                int selectrow = -1;
                for(int i=0;i< dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["MSSV"].Value.ToString() == tbMSV.Text)
                    {
                        selectrow = i;
                        break;
                    }
                }
                String msg = "Cập Nhật Thành Công";
                // them 1 sinh vien vao datagrid
                if (selectrow == -1)
                {
                    selectrow = dataGridView1.Rows.Add();//thêm 1 dòng mới
                    msg = "Thêm Thành Công";
                }
                dataGridView1.Rows[selectrow].Cells["HoTen"].Value = tbHVT.Text;
                dataGridView1.Rows[selectrow].Cells["MSSV"].Value = tbMSV.Text;
                dataGridView1.Rows[selectrow].Cells["DTB"].Value = tbDTB.Text;
                dataGridView1.Rows[selectrow].Cells["Khoa"].Value = cbKhoa.Text;
                
                dataGridView1.Rows[selectrow].Cells["GioiTinh"].Value = (rbNam.Checked)? "Nam" : "Nữ";
                if (dataGridView1.Rows[selectrow].Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    tongnam++;
                    tbNam.Text = tongnam.ToString();
                }
                else
                {
                    tongnu++;
                    tbNu.Text = tongnu.ToString();
                }    
             
                MessageBox.Show(msg, "Thông Báo");

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectrow = e.RowIndex;// hàng được chọn 
                tbHVT.Text = dataGridView1.Rows[selectrow].Cells["HoTen"].Value.ToString();
                tbMSV.Text = dataGridView1.Rows[selectrow].Cells["MSSV"].Value.ToString();
                tbDTB.Text = dataGridView1.Rows[selectrow].Cells["DTB"].Value.ToString();
                cbKhoa.Text = dataGridView1.Rows[selectrow].Cells["Khoa"].Value.ToString();
                string sex = dataGridView1.Rows[selectrow].Cells["GioiTinh"].Value.ToString();
                if (sex == "Nam")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //tim dong can xóa
                int selectrow = -1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["MSSV"].Value.ToString() == tbMSV.Text)
                    {
                        selectrow = i;
                        break;
                    }
                }
                if (selectrow == -1)
                    throw new Exception("Không tìm thấy sv cần xóa");
                else
                {
                        if (dataGridView1.Rows[selectrow].Cells["GioiTinh"].Value.ToString() == "Nam")
                        {
                            tongnam--;
                            tbNam.Text = tongnam.ToString();
                        }
                        else
                        {
                            tongnu--;
                            tbNu.Text = tongnu.ToString();
                        }
                        dataGridView1.Rows.RemoveAt(selectrow);// xoa dòng được chọn
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

  
    }
}
