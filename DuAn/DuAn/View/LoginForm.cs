using DuAn.Connection;
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
    public partial class LoginForm : Form
    {
         
        public LoginForm()
        {
            InitializeComponent(); 
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        SQLConfig config = new SQLConfig();
        string sql; 

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = " SELECT* FROM account WHERE username = '" + txtusername.Text + "' and password = '" + txtpass.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                FormMenu home = new FormMenu();
                home.ShowDialog(); 
                  this.Close();
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong dung vui long nhap lai !.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog(); 
        }
    }
}
