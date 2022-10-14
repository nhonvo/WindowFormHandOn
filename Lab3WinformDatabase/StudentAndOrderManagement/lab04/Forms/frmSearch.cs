using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04.models;
using System.Configuration;
using lab04.Forms;

namespace lab04
{
    public partial class frmSearch : Form
    {
        StudentManagentDBContext context = new StudentManagentDBContext();
        public frmSearch()
        {

            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFullName.Clear();
            txtId.Focus();
        }


        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            List<Faculty> listFalcultys = context.Faculties.ToList();
            List<Student> listStudent = context.Students.ToList();
            FillFalcultyCombobox(listFalcultys);
            BindGrid(listStudent);
            txtResult.Text = "0";

        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvSearch.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvSearch.Rows.Add();
                dgvSearch.Rows[index].Cells[0].Value = item.StudentID;
                dgvSearch.Rows[index].Cells[1].Value = item.Fullname;
                dgvSearch.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvSearch.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }


        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbFaculty.DataSource = listFalcultys;
            this.cbbFaculty.DisplayMember = "FacultyName";
            this.cbbFaculty.ValueMember = "FacultyID";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTKMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Student> listStudent = context.Students.ToList();
            if (txtId.Text == "" || txtFullName.Text == "")
            {
                List<Student> listFindStudent = (from s in listStudent
                                                 where
                            s.Faculty.FacultyID == Convert.ToInt32(cbbFaculty.SelectedValue)
                                                 select s).ToList();
                txtResult.Text = (listFindStudent.Count).ToString();
                BindGrid(listFindStudent);
            }
            if (txtId.Text != "" || txtFullName.Text != "")
            {
                List<Student> listFindStudent2 = (from s in listStudent
                                                  where
                            (s.StudentID.Contains(txtId.Text) ||
                            s.Fullname.ToLower().Contains(txtFullName.Text.ToLower())) &&
                            s.Faculty.FacultyID == Convert.ToInt32(cbbFaculty.SelectedValue)

                                                  select s).ToList();
                txtResult.Text = (listFindStudent2.Count).ToString();
                BindGrid(listFindStudent2);
            }

        }
        private void txtTKHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }
    }
}
