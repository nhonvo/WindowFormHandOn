using Lab05.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.Forms
{
    public partial class frmStudentManagement : Form
    {
        StudentManagentDBContext context = new StudentManagentDBContext();
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void BindGrid(List<Student> listStudent)
        {
            dtgStudentManagement.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dtgStudentManagement.Rows.Add();
                dtgStudentManagement.Rows[index].Cells[0].Value = item.StudentID;
                dtgStudentManagement.Rows[index].Cells[1].Value = item.Fullname;
                dtgStudentManagement.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dtgStudentManagement.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbFaculty.DataSource = listFalcultys;
            this.cbbFaculty.DisplayMember = "FacultyName";
            this.cbbFaculty.ValueMember = "FacultyID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                if (checkidSinhVien(txtId.Text) == -1)
                {
                    Student newstudent = new Student();
                    newstudent.StudentID = txtId.Text;
                    newstudent.Fullname = txtFullName.Text;
                    newstudent.AverageScore = Convert.ToDouble(txtAverageScore.Text);
                    newstudent.FacultyID = Convert.ToInt32(cbbFaculty.SelectedValue.ToString());

                    context.Students.AddOrUpdate(newstudent);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"thêm sinh viên {newstudent.Fullname} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Sinh viên có mã số {txtId.Text} đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);

                }
            }
        }
        private void loadform()
        {
            txtId.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();

        }

        private void loadDGV()
        {
            List<Student> newListStudent = context.Students.ToList();
            BindGrid(newListStudent);
        }
        private int checkidSinhVien(string idnewStudent)
        {
            int length = dtgStudentManagement.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dtgStudentManagement.Rows[i].Cells[0].Value != null)
                    if (dtgStudentManagement.Rows[i].Cells[0].Value.ToString() == idnewStudent)
                        return i;
            }
            return -1;
        }

        private bool checkdatainput()
        {
            if (txtId.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên");
                return false;
            }
            else
            {
                if (Convert.ToInt32(txtId.TextLength) != 10)
                {
                    MessageBox.Show("MSSV đủ 10 ký tự!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
                if (Convert.ToDouble(txtAverageScore.Text) > 10 || Convert.ToDouble(txtAverageScore.Text) < 0)
                {
                    MessageBox.Show("Điểm trong khoảng 1 -> 10!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
                int mssvLength = txtId.TextLength;
                if (mssvLength < 10 || mssvLength > 10)
                {
                    MessageBox.Show("Mã số sinh viên phải 10 ký tự", "Thông Báo", MessageBoxButtons.OK);
                }
                //???
                double kq;
                bool ketqua = Double.TryParse(txtAverageScore.Text, out kq);
                if (!ketqua)
                {
                MessageBox.Show("Average score incorrect !!! ", "Notification", MessageBoxButtons.OK);
                    return false;
                }
                

            }
            return true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                //lấy ra phần tử đầu tiên để thỏa mãn dk
                Student updateStudent = context.Students.FirstOrDefault(p => p.StudentID == txtId.Text);
                if (updateStudent != null)
                {

                    updateStudent.Fullname = txtFullName.Text;
                    updateStudent.AverageScore = Convert.ToDouble(txtAverageScore.Text);
                    updateStudent.FacultyID = Convert.ToInt32(cbbFaculty.SelectedValue.ToString());

                    context.Students.AddOrUpdate(updateStudent);
                    context.SaveChanges();

                    reloadDGV();
                    reloadform();
                    MessageBox.Show($"chỉnh sữa dữ liệu sinh viên{updateStudent.Fullname} thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadform()
        {
            txtId.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();

        }

        private void reloadDGV()
        {
            List<Student> Liststudents = context.Students.ToList();
            BindGrid(Liststudents);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student deleteStudent = context.Students.FirstOrDefault(p => p.StudentID == txtId.Text);
            if (deleteStudent != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa sinh viên {deleteStudent.Fullname} không ?", "Thông báo cho bạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    context.Students.Remove(deleteStudent);
                    context.SaveChanges();

                    reloadform();
                    reloadDGV();

                    MessageBox.Show($"Xóa sinh viên {deleteStudent.Fullname} thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            frmFalculty frmFalculty = new frmFalculty();
            frmFalculty.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFalculty frmFalculty = new frmFalculty();
            frmFalculty.Show();
        }

        private void TSTimKiem_Click(object sender, EventArgs e)
        {
            frmSearch frmTimKiem = new frmSearch();
            frmTimKiem.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmTimKiem = new frmSearch();
            frmTimKiem.Show();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            cbbFaculty.SelectedItem = "Công Nghệ Thông Tin";
            try
            {
                List<Faculty> listFalcultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DTGbangthongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgStudentManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtgStudentManagement.CurrentRow.Selected = true;
                    txtId.Text = dtgStudentManagement.Rows[e.RowIndex].Cells["dgvmssv"].FormattedValue.ToString();
                    txtFullName.Text = dtgStudentManagement.Rows[e.RowIndex].Cells["dgvHoTen"].FormattedValue.ToString();
                    cbbFaculty.Text = dtgStudentManagement.Rows[e.RowIndex].Cells["dgvKhoa"].FormattedValue.ToString();
                    txtAverageScore.Text = dtgStudentManagement.Rows[e.RowIndex].Cells["dgvDTB"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void quảnLýKhoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFalculty frmFalculty = new frmFalculty();
            frmFalculty.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSearch frmTimKiem = new frmSearch();
            frmTimKiem.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.Show();
        }
    }
}
