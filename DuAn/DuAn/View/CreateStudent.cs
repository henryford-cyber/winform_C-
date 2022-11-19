using DuAn.Model;
using DuAn.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DuAn.Model.Student;

namespace DuAn.View
{
    public partial class CreateStudent : Form
    {
        public Student students;
        public CreateStudent(Student students = null)
        {
            InitializeComponent();
            
            this.students = students; 
            txtName.Text = students?.name;
            txtSex.Text = students?.sex.ToString();
            dtBirtDay.Text = students?.birthDay.ToString();
            txtAddess.Text = students?.address;
            cboClass.Text = students?.class_id.ToString(); 
            Load_ListClass();
            

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void Load_ListClass()
        {
            cboClass.Items.Clear();
            var lsClass = ClassService.ListClass();
            cboClass.DataSource = lsClass;
            cboClass.DisplayMember = "className";


        }
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "" ||
           txtAddess.Text == "" ||
           txtSex.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin de them sinh vien ", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (students == null)
            {
                
                Random random = new Random();
                students = new Student
                {
                    id = random.Next(5, 100),
                    name = txtName.Text,
                    sex =  txtSex.Text,
                    birthDay= dtBirtDay.Value,
                    address = txtAddess.Text,
                    class_id=cboClass.SelectedIndex+1,

                    
                };
                DialogResult = DialogResult.OK;
            }
            else
            { 
                students.class_id = Convert.ToInt32(cboClass.SelectedIndex+1);
                students.name = txtName.Text;   
                students.sex = txtSex.Text;
                students.address = txtAddess.Text;
                students.birthDay = dtBirtDay.Value;
               

                DialogResult = DialogResult.OK;
            }
        }

        private void CreateForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
