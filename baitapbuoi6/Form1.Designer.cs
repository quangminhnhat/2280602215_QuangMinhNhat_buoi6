namespace bai2
{
    partial class frmManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_khoa = new System.Windows.Forms.ComboBox();
            this.txt_averageScore = new System.Windows.Forms.TextBox();
            this.Female_rbtn = new System.Windows.Forms.RadioButton();
            this.Male_rbtn = new System.Windows.Forms.RadioButton();
            this.txt_studentName = new System.Windows.Forms.TextBox();
            this.txt_studentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountMale = new System.Windows.Forms.TextBox();
            this.txtCountFemale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_khoa);
            this.groupBox1.Controls.Add(this.txt_averageScore);
            this.groupBox1.Controls.Add(this.Female_rbtn);
            this.groupBox1.Controls.Add(this.Male_rbtn);
            this.groupBox1.Controls.Add(this.txt_studentName);
            this.groupBox1.Controls.Add(this.txt_studentID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên ";
            // 
            // cmb_khoa
            // 
            this.cmb_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_khoa.FormattingEnabled = true;
            this.cmb_khoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmb_khoa.Location = new System.Drawing.Point(110, 152);
            this.cmb_khoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_khoa.Name = "cmb_khoa";
            this.cmb_khoa.Size = new System.Drawing.Size(200, 21);
            this.cmb_khoa.TabIndex = 10;
            // 
            // txt_averageScore
            // 
            this.txt_averageScore.Location = new System.Drawing.Point(110, 121);
            this.txt_averageScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_averageScore.Name = "txt_averageScore";
            this.txt_averageScore.Size = new System.Drawing.Size(116, 20);
            this.txt_averageScore.TabIndex = 9;
            this.txt_averageScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_averageScore_KeyPress);
            // 
            // Female_rbtn
            // 
            this.Female_rbtn.Checked = true;
            this.Female_rbtn.Location = new System.Drawing.Point(166, 85);
            this.Female_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Female_rbtn.Name = "Female_rbtn";
            this.Female_rbtn.Size = new System.Drawing.Size(46, 20);
            this.Female_rbtn.TabIndex = 8;
            this.Female_rbtn.TabStop = true;
            this.Female_rbtn.Text = "Nữ";
            this.Female_rbtn.UseVisualStyleBackColor = true;
            // 
            // Male_rbtn
            // 
            this.Male_rbtn.Location = new System.Drawing.Point(104, 85);
            this.Male_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(58, 20);
            this.Male_rbtn.TabIndex = 7;
            this.Male_rbtn.Text = "Nam";
            this.Male_rbtn.UseVisualStyleBackColor = true;
            // 
            // txt_studentName
            // 
            this.txt_studentName.Location = new System.Drawing.Point(110, 58);
            this.txt_studentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.Size = new System.Drawing.Size(200, 20);
            this.txt_studentName.TabIndex = 6;
            // 
            // txt_studentID
            // 
            this.txt_studentID.Location = new System.Drawing.Point(110, 25);
            this.txt_studentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.Size = new System.Drawing.Size(116, 20);
            this.txt_studentID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // btn_Add_Edit
            // 
            this.btn_Add_Edit.Location = new System.Drawing.Point(62, 297);
            this.btn_Add_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add_Edit.Name = "btn_Add_Edit";
            this.btn_Add_Edit.Size = new System.Drawing.Size(76, 20);
            this.btn_Add_Edit.TabIndex = 1;
            this.btn_Add_Edit.Text = "Thêm / Sửa";
            this.btn_Add_Edit.UseVisualStyleBackColor = true;
            this.btn_Add_Edit.Click += new System.EventHandler(this.btn_Add_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(185, 297);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 20);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colNAME,
            this.colGender,
            this.colAverageScore,
            this.colKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(352, 67);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(510, 283);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.ReadOnly = true;
            // 
            // colNAME
            // 
            this.colNAME.HeaderText = "họ tên";
            this.colNAME.MinimumWidth = 6;
            this.colNAME.Name = "colNAME";
            this.colNAME.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "giới tính";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colAverageScore
            // 
            this.colAverageScore.HeaderText = "ĐTB";
            this.colAverageScore.MinimumWidth = 6;
            this.colAverageScore.Name = "colAverageScore";
            this.colAverageScore.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(607, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "tổng SV";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(771, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nữ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(664, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nam";
            // 
            // txtCountMale
            // 
            this.txtCountMale.Location = new System.Drawing.Point(708, 362);
            this.txtCountMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountMale.Name = "txtCountMale";
            this.txtCountMale.ReadOnly = true;
            this.txtCountMale.Size = new System.Drawing.Size(50, 20);
            this.txtCountMale.TabIndex = 14;
            // 
            // txtCountFemale
            // 
            this.txtCountFemale.Location = new System.Drawing.Point(799, 362);
            this.txtCountFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountFemale.Name = "txtCountFemale";
            this.txtCountFemale.ReadOnly = true;
            this.txtCountFemale.Size = new System.Drawing.Size(52, 20);
            this.txtCountFemale.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(861, 43);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quản Lý Thông Tin Sinh Viên";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 390);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCountFemale);
            this.Controls.Add(this.txtCountMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add_Edit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManagement";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Female_rbtn;
        private System.Windows.Forms.RadioButton Male_rbtn;
        private System.Windows.Forms.TextBox txt_studentName;
        private System.Windows.Forms.TextBox txt_studentID;
        private System.Windows.Forms.TextBox txt_averageScore;
        private System.Windows.Forms.ComboBox cmb_khoa;
        private System.Windows.Forms.Button btn_Add_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountMale;
        private System.Windows.Forms.TextBox txtCountFemale;
        private System.Windows.Forms.Label label9;
    }
}

