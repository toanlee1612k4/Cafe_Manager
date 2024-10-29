using CafeManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DKVMEntities context = new DKVMEntities();
                List<Student> listdkmonhoc = context.Student.ToList();
                List<Subject> subjects = context.Subject.ToList();
                BindGrid(listdkmonhoc);
                FillSubjectCombobox(subjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FillSubjectCombobox(List<Subject> subjects)
        {
            this.cmbSubject.DataSource = subjects;
            this.cmbSubject.DisplayMember = "SubjectName";
            this.cmbSubject.ValueMember = "SubjectID";
        }
        private void BindGrid(List<Student> listdkmonhoc)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listdkmonhoc)
            {
                {
                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                    dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                    dgvStudent.Rows[index].Cells[3].Value = item.NgaySinh;
                    dgvStudent.Rows[index].Cells[2].Value = item.Subject.SubjectID;

                }
            }
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null && dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = dateTimePicker1.Text;
            dgvStudent.Rows[selectedRow].Cells[3].Value = cmbSubject.Text;
  
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtName.Text == "" )
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!!!");
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xoá!!!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoá sinh viên thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}