using Lab4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class frmQuanLyKhoa : Form
    {
        public frmQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                using (StudentContextDB context = new StudentContextDB())
                {
                    List<Faculty> faculties = context.Faculties.ToList(); // Lấy danh sách khoa
                    BindGrid(faculties); // Hiển thị lên DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Faculty> faculties)
        {
            dgvFaculty.Rows.Clear();
            if (faculties != null && faculties.Count > 0) // Kiểm tra xem có dữ liệu hay không
            {
                foreach (var faculty in faculties)
                {
                    int index = dgvFaculty.Rows.Add();
                    dgvFaculty.Rows[index].Cells[0].Value = faculty.FacultyID;
                    dgvFaculty.Rows[index].Cells[1].Value = faculty.FacultyName;
                    dgvFaculty.Rows[index].Cells[2].Value = faculty.TotalProfessor;
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu khoa nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFaculty.Rows[e.RowIndex];
                txtFacultyID.Text = selectedRow.Cells[0].Value.ToString();
                txtFacultyName.Text = selectedRow.Cells[1].Value.ToString();
                txtTotalProfessor.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void btnAddnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường không được để trống
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text) ||
                    string.IsNullOrWhiteSpace(txtFacultyName.Text) ||
                    string.IsNullOrWhiteSpace(txtTotalProfessor.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã khoa, Tên khoa và Tổng giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int facultyID;
                if (int.TryParse(txtFacultyID.Text, out facultyID))
                {
                    using (StudentContextDB db = new StudentContextDB()) // Khởi tạo lại `db` bên trong hàm
                    {
                        List<Faculty> facultyList = db.Faculties.ToList();

                        // Kiểm tra nếu mã khoa tồn tại
                        var existingFaculty = facultyList.FirstOrDefault(f => f.FacultyID == facultyID);
                        if (existingFaculty != null) // Sửa khoa
                        {
                            existingFaculty.FacultyName = txtFacultyName.Text;
                            existingFaculty.TotalProfessor = int.Parse(txtTotalProfessor.Text);

                            db.SaveChanges();

                            MessageBox.Show("Chỉnh sửa thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // Thêm khoa mới
                        {
                            if (facultyList.Any(f => f.FacultyID == facultyID))
                            {
                                MessageBox.Show("Mã khoa đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var newFaculty = new Faculty
                            {
                                FacultyID = facultyID,
                                FacultyName = txtFacultyName.Text,
                                TotalProfessor = int.Parse(txtTotalProfessor.Text) // Giá trị hợp lệ cho TotalProfessor
                            };

                            db.Faculties.Add(newFaculty);
                            db.SaveChanges();

                            MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã khoa không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Hiển thị lại danh sách khoa
                using (StudentContextDB db = new StudentContextDB())
                {
                    BindGrid(db.Faculties.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường không được để trống
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã khoa để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StudentContextDB db = new StudentContextDB()) // Sử dụng `using` để quản lý tài nguyên
                {
                    List<Faculty> faculties = db.Faculties.ToList();

                    // Tìm kiếm khoa có tồn tại trong CSDL hay không
                    var faculty = faculties.FirstOrDefault(f => f.FacultyID == int.Parse(txtFacultyID.Text));

                    if (faculty != null)
                    {
                        // Xóa khoa khỏi CSDL
                        db.Faculties.Remove(faculty);
                        db.SaveChanges();

                        // Hiển thị lại danh sách
                        BindGrid(db.Faculties.ToList());

                        MessageBox.Show("Khoa đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khoa không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFaculty.Rows[e.RowIndex];
                txtFacultyID.Text = selectedRow.Cells[0].Value.ToString();
                txtFacultyName.Text = selectedRow.Cells[1].Value.ToString();
                txtTotalProfessor.Text = selectedRow.Cells[2].Value.ToString();
            }
        }
    }
}
