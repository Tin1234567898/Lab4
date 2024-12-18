using Lab4_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); // Lấy các khoa
                List<Student> listStudent = context.Students.ToList(); // Lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> students)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in students)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[1].Value = item.FullName;
                dgvStudents.Rows[index].Cells[2].Value = item.Gender;
                if (item.Faculty != null)
                {
                    dgvStudents.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }
                else
                {
                    dgvStudents.Rows[index].Cells[3].Value = "Công nghệ thông tin"; // Giá trị mặc định
                }
                dgvStudents.Rows[index].Cells[4].Value = item.AverageScore;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();

                // Lấy điều kiện tìm kiếm từ các TextBox và ComboBox
                string studentID = txtID.Text.Trim();
                string fullName = txtName.Text.Trim();
                int? facultyID = cmbFaculty.SelectedIndex > -1 ? (int?)cmbFaculty.SelectedValue : null;

                // Tìm kiếm với điều kiện
                var query = context.Students.AsQueryable();

                if (!string.IsNullOrEmpty(studentID))
                    query = query.Where(s => s.StudentID.Contains(studentID));
                if (!string.IsNullOrEmpty(fullName))
                    query = query.Where(s => s.FullName.Contains(fullName));
                if (facultyID.HasValue)
                    query = query.Where(s => s.FacultyID == facultyID.Value);

                List<Student> students = query.ToList();
                BindGrid(students);

                // Hiển thị số lượng kết quả tìm kiếm
                txtResult.Text = ($"{students.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            cmbFaculty.SelectedIndex = -1;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Hiển thị lại frmQuanLySinhVien nếu cần
            var mainForm = (frmStudentManagement)Application.OpenForms["frmQuanLySinhVien"];
            if (mainForm != null)
            {
                mainForm.Show();
            }
        }
    }
}
