using DuAn.Component;
using DuAn.Model;
using DuAn.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn.View
{
    public partial class studentView : Form
    {
       private List<Student> listStudent;
        public studentView()
        {
            InitializeComponent();
            listStudent = StudentService.ListStudents();
            Load_ListClass();
        }
        void Load_ListClass()
        {
            cboClass.Items.Clear();
            var lsClass=ClassService.ListClass();
            cboClass.DataSource= lsClass;
            cboClass.DisplayMember = "className";
            

        }
        void Load_ListStudent()
        {
            var selectedClass=cboClass.SelectedItem as Class;
            var lsStudent = listStudent.Where(t =>t.class_id == selectedClass?.classId).ToList();
            lblTotal1.Text = lsStudent.Count.ToString();    
            dgvSinhvien.DataSource= lsStudent;
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            } 
            lblTotal2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            var selectedClass = cboClass.SelectedItem as Class;
            var result = listStudent.Where(e => e.class_id==selectedClass?.classId && (
            e.name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            e.address.Contains(keyword, StringComparison.OrdinalIgnoreCase))).ToList();
            dgvSinhvien.DataSource = result;
        }

        private void btnReadfile_Click(object sender, EventArgs e)
        {
            ReadfileExcel readfileExcel = new ReadfileExcel();
            readfileExcel.ShowDialog();
        }

        private void studentView_Load(object sender, EventArgs e)
        {

            LoadTheme();
        }
        

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
               Load_ListStudent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //This line of code creates a text file for the data export.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Data\ListStudent.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= dgvSinhvien.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dgvSinhvien.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dgvSinhvien.Rows[r].Cells[c].Value;
                        if (c != dgvSinhvien.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + "|";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var cs = new CreateStudent();
           if(cs.ShowDialog() == DialogResult.OK)
            {
                listStudent.Add(cs.students);
                Load_ListStudent();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


             var rs = MessageBox.Show("Ban co chac la muon xoa sinh vien nay khong hoc nay khong ?",
               "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             if (rs == DialogResult.OK)
            {
                listStudent.RemoveAt(dgvSinhvien.SelectedRows[0].Index);
            Load_ListStudent();
                MessageBox.Show("Xoa sinh vien thanh Cong", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // var chon = studentBindingSource.Current as Student;
            var selected = dgvSinhvien.SelectedRows[0].DataBoundItem as Student;
            CreateStudent createStudent = new CreateStudent(selected);
            
            if (createStudent!=null) {
               
               if (createStudent.ShowDialog()==DialogResult.OK)
                {
                    Load_ListStudent();
                }
            }
            else
            {
                MessageBox.Show("Vui long thu lai ");
            }
        }
    }
}
