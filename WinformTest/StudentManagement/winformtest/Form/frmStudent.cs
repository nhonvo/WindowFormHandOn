using Microsoft.SqlServer.Server;
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
using winformtest.Model;

namespace winformtest 
{
    public partial class frmStudent : Form
    {
        StudentDBContext db = new StudentDBContext();
        public frmStudent()
        {
            InitializeComponent();
        }

        public void BindGrid(List<Student> lst)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.id;
                dgvStudent.Rows[index].Cells[1].Value = item.name;
                dgvStudent.Rows[index].Cells[2].Value = item.day;
                dgvStudent.Rows[index].Cells[3].Value = item.Class.id;
            }
        }
        public void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtDate.Clear();
        }
        public void ReloadCBB()
        {
            var lst = db.Classes.ToList();

            this.cbbClass.DataSource = lst;
            this.cbbClass.DisplayMember = "name";
            this.cbbClass.ValueMember = "id";
        }
        public void ReLoadDGV()
        {
            var obj = db.Students.ToList();
            BindGrid(obj);
        }

        private bool checkdatainput()
        {
            if (txtId.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please fill all fields!!");
                return false;
            }
            else
            {
                // another condition
            }
            return true;
        }
        public bool checkId(string id) => db.Students.Any(x => x.id == id);
        private void frmStudent_Load(object sender, EventArgs e)
        {
            ReLoadDGV();
            ReloadCBB();
        }


        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true;
                    txtId.Text = dgvStudent.Rows[e.RowIndex].Cells["clId"].FormattedValue.ToString();
                    txtName.Text = dgvStudent.Rows[e.RowIndex].Cells["clName"].FormattedValue.ToString();
                    txtDate.Text = dgvStudent.Rows[e.RowIndex].Cells["clBirth"].FormattedValue.ToString();
                    cbbClass.Text = dgvStudent.Rows[e.RowIndex].Cells["clClass"].FormattedValue.ToString();
                }
                else
                {
                    MessageBox.Show("This student is null!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("This student is null!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                if (!checkId(txtId.Text))
                {
                    Student sp = new Student()
                    {
                        id = txtId.Text,
                        name = txtName.Text,
                        day = txtDate.Text,
                        classId = cbbClass.SelectedValue.ToString()
                    };
                    db.Students.Add(sp);
                    db.SaveChanges();
                    MessageBox.Show("Modify data success!!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("The id fields must be not same!!", "Notification", MessageBoxButtons.OK);
                }
            }
            ClearForm();
            ReloadCBB();
            ReLoadDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            Student sp = db.Students.FirstOrDefault(x => x.id == txtId.Text);
            if (sp != null)
            {

                sp.id = txtId.Text;
                sp.name= txtName.Text;
                sp.day= txtDate.Text;
                sp.classId= cbbClass.SelectedValue.ToString();
                db.Students.AddOrUpdate(sp);
                db.SaveChanges();
                MessageBox.Show("Modify data success!!", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Can't the product!!", "Notification", MessageBoxButtons.OK);
            }

            ClearForm();
            ReloadCBB();
            ReLoadDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student sp = db.Students.FirstOrDefault(x => x.id == txtId.Text);
            if (sp != null)
            {
                db.Students.Remove(sp);
                db.SaveChanges();
                MessageBox.Show("Modify data success!!", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Can't the product!!", "Notification", MessageBoxButtons.OK);
            }

            ClearForm();
            ReloadCBB();
            ReLoadDGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.Show();
        }
    }
}
