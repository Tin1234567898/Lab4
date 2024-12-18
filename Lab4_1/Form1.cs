using Lab4_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
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

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Gender;
                if (item.Faculty != null)
                {
                    dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }
                else
                {
                    dgvStudent.Rows[index].Cells[3].Value = "Công nghệ thông tin"; // Giá trị mặc định
                }
                dgvStudent.Rows[index].Cells[4].Value = item.AverageScore;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường không được để trống
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin MSSV, Họ tên và Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra MSSV phải đúng 10 ký tự
                if (txtID.Text.Length != 10)
                {
                    MessageBox.Show("Mã số sinh viên phải đúng 10 ký tự. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                List<Student> studentList = db.Students.ToList();
                if (studentList.Any(s => s.StudentID == txtID.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStudent = new Student
                {
                    StudentID = txtID.Text,
                    FullName = txtName.Text,
                    Gender = rdMale.Checked ? "Male" : "Female",
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtScore.Text)
                };


                //Thêm SV vào CSDL
                db.Students.Add(newStudent);
                db.SaveChanges();

                //Hiển thị lại danh sách sinh viên
                BindGrid(db.Students.ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường không được để trống
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin MSSV, Họ tên và Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra MSSV phải đúng 10 ký tự
                if (txtID.Text.Length != 10)
                {
                    MessageBox.Show("Mã số sinh viên phải đúng 10 ký tự. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                List<Student> students = db.Students.ToList();
                var student = students.FirstOrDefault(s => s.StudentID == txtID.Text);
                if (student != null)
                {
                    if (students.Any(s => s.StudentID == txtID.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    student.FullName = txtName.Text;
                    student.Gender = rdMale.Checked ? "Male" : "Female";
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtScore.Text);

                    //Cập nhật sinh viên lưu vào CSDL 
                    db.SaveChanges();

                    //Hiển thị lại danh sách sinh viên
                    BindGrid(db.Students.ToList());

                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường không được để trống
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin MSSV, Họ tên và Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra MSSV phải đúng 10 ký tự
                if (txtID.Text.Length != 10)
                {
                    MessageBox.Show("Mã số sinh viên phải đúng 10 ký tự. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                List<Student> studentList = db.Students.ToList();

                //Tim kiếm SV có tồn tại trong CSDL hay không
                var student = studentList.FirstOrDefault(s => s.StudentID == txtID.Text);

                if (student != null)
                {
                    //Xóa sinh viên khỏi CSDL
                    db.Students.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.Students.ToList());

                    MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                string gender = selectedRow.Cells[2].Value.ToString();
                if (gender == "Male")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                cmbFaculty.Text = selectedRow.Cells[3].Value.ToString();
                txtScore.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa frmQuanLyKhoa = new frmQuanLyKhoa();
            frmQuanLyKhoa.Show();
            Hide();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
            Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
