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
            txtCountMale.Text = "0";
            txtCountFemale.Text = "0";
        }
        private int GetSelectedRow(string studentID)
        {
            try
            {
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                    {
                        return i;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return -1;
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txt_studentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txt_studentName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = Female_rbtn.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txt_averageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmb_khoa.Text;
        }

        
        private void btn_Add_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_studentID.Text == "" || txt_studentName.Text == "" || txt_averageScore.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                if (txt_studentID.TextLength != 10 )
                    throw new Exception("Mã số sinh viên không hợp lệ.");
                string averageScoreText = txt_averageScore.Text;
                if (decimal.TryParse(averageScoreText, out decimal averageScore) && averageScore >= 0 && averageScore <= 10)
                { }
                else { throw new Exception("Điểm trung bình sinh viên không hợp lệ"); }
                String name=txt_studentName.Text;
                if (!string.IsNullOrWhiteSpace(name) && name.Length >= 3 && name.Length <= 100 && System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                { }
                else { throw new Exception("Nhập tên sai nhập lại"); }
                    int selectedRow = GetSelectedRow(txt_studentID.Text); 
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add(); 
                    InsertUpdate(selectedRow);
                    String gender = (string)dgvStudent.Rows[selectedRow].Cells[2].Value;
                    if (gender == "Nữ") { txtCountFemale.Text=$"{getcountfemale()}" ; } else {txtCountMale.Text=$"{getcountmale()}" ; }
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    String gender = (string)dgvStudent.Rows[selectedRow].Cells[2].Value;
                    if (gender == "Nữ") { getcountfemale(); } else { getcountmale(); }
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_khoa.SelectedIndex = 0;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txt_studentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {    
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        String gender= (string)dgvStudent.Rows[selectedRow].Cells[2].Value;
                        if (gender == "Nữ") { txtCountFemale.Text = $"{getcountfemale()}"; } else { txtCountMale.Text = $"{getcountmale()}"; }
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        //this is not optimize at all
        private int getcountfemale()
        {
            int count = 0;
           try
            {
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                { 
                    if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nữ")
                    {
                        count++;
                    }
                }
            }catch (NullReferenceException)
            {
                return count;
            }
            
            return count;
        }
        private int getcountmale()
        {
            int count = 0;
            try
            {
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nam")
                    {
                        count++;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return count;
            }

            return count;
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Xác nhận thoát",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
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
                if (row.Cells[2].Value.ToString() == "Male")
                {
                    Male_rbtn.Checked = true;
                }
                else
                {                    
                    Female_rbtn.Checked = true;
                }
                
                txt_averageScore.Text = row.Cells[3].Value.ToString();
                cmb_khoa.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_studentID.Text = row.Cells[0].Value.ToString();
                txt_studentName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Male")
                {
                    Male_rbtn.Checked = true;
                }
                else
                {
                    Female_rbtn.Checked = true;
                }

                txt_averageScore.Text = row.Cells[3].Value.ToString();
                cmb_khoa.Text = row.Cells[4].Value.ToString();
            }
        }

        
    }
}
