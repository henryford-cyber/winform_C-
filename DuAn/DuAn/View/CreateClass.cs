using DuAn.Model;
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

namespace DuAn.View
{
    public partial class CreateClass : Form
    {
        public Class classs;
        public CreateClass(Class classs = null)
        {
            InitializeComponent();
            this.classs = classs;
            txtClassName.Text = classs?.className;
            txtTeacher.Text = classs?.homeroomTeacher;
            txtTotal.Text = classs?.totalStudent.ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ctPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text == "" || txtTeacher.Text == "" || txtTotal.Text =="")
            {
                MessageBox.Show("Vui long nhap day du thong tin!! " ,"Thong bao! ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (classs == null)
            {
                
                 classs = new Class
                {
                     classId= 0,
                     className=txtClassName.Text,
                     homeroomTeacher= txtTeacher.Text,
                     totalStudent=Convert.ToInt32(txtTotal.Text)
                 };
                DialogResult = DialogResult.OK;
            }
            else
            {
                //chinh sua
                classs.className = txtClassName.Text;
                classs.homeroomTeacher = txtTeacher.Text;
                classs.totalStudent = Convert.ToInt32(txtTotal.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void txtTeacher__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClassName__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
