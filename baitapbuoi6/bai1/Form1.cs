using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
            
        }
        
        private void btn_Add_Edit_Click(object sender, EventArgs e)
        {
            try 
            {
                StudentContextDB db = new StudentContextDB();
                List<Student> studentLst = db.Students.ToList();
                if (studentLst.Any(s => s.StudentID == txt_studentID.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newStudent = new Student
                {
                    StudentID = txt_studentID.Text,
                    FullName = txt_studentName.Text,
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = double.Parse(txt_averageScore.Text)
                };
                db.Students.Add(newStudent);
                db.SaveChanges();
                BindGrid(db.Students.ToList());
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
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
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyNme"; 
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
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyNme; 
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB db = new StudentContextDB();
                List<Student> studentList = db.Students.ToList();
                var student = studentList.FirstOrDefault(s => s.StudentID == txt_studentID.Text);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    BindGrid(db.Students.ToList());
                    MessageBox.Show("Sinh viên đã được xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

     
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Xác nhận thoát",
            //    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void txt_averageScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
             if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_studentID.Text = row.Cells[0].Value.ToString();
                txt_studentName.Text = row.Cells[1].Value.ToString();
                txt_averageScore.Text = row.Cells[3].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_studentID.Text = row.Cells[0].Value.ToString();
                txt_studentName.Text = row.Cells[1].Value.ToString();
                txt_averageScore.Text = row.Cells[3].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            try 
            {
                StudentContextDB db = new StudentContextDB();
                List<Student> students = db.Students.ToList();
                var student = students.FirstOrDefault(s => s.StudentID == txt_studentID.Text);
                if (student != null)
                {
                    List<Student> studentLst = db.Students.ToList();
                    if (studentLst.Any(s => s.StudentID == txt_studentID.Text))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    student.FullName = txt_studentName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txt_averageScore.Text);
                    db.SaveChanges();
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
    }
}
