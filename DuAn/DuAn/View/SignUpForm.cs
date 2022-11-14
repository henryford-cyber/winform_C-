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
    public partial class SignUpForm : Form
    {
        
        public SignUpForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SignUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" || txtPhone.Text == "" || txtAddreee.Text == "" || txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui long dien day du thong tin ben tren ","Thong bao !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql ="insert into account (fullname,phonenumber,address,username,password,type)"
                    +"values('"+txtFullname.Text + "','"+txtPhone.Text + "','"+txtAddreee.Text+"','"+txtUsername.Text+"','"+txtPass.Text+"','user')";
                config.Execute_CUD(sql, "Dang ky khong thanh cong!! vui long thu lai ", "Dang ky thanh cong ");
            }
        }
    }
}
