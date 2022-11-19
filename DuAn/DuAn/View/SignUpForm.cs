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
            txtFullname.Focus();
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
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        void setNull()
        {
            txtFullname.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            txtPass.Text = "";
            txtAddreee.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" || txtPhone.Text == "" || txtAddreee.Text == "" || txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui long dien day du thong tin ben tren ","Th" +
                    "ong bao !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql ="insert into account (fullname,phonenumber,address,username,password,image,type)"
                    +"values('"+txtFullname.Text + "','"+txtPhone.Text + "','"+txtAddreee.Text+"','"+txtUsername.Text+"','"+txtPass.Text+ "','','user')";
                config.Execute_CUD(sql, "Dang ky khong thanh cong!! vui long thu lai ", "Chuc mung ban da dang ki thanh cong !  ");
                setNull();
            }
        }

        private void txtFullname_Validating(object sender, CancelEventArgs e)
        {
            if (txtFullname.Text == string.Empty)
            {
                MessageBox.Show("Ten khong duoc de trong !!", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
             
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                this.Focus();
                MessageBox.Show("Ten tai khoan khong duoc de trong !! Vui long nhap ten tai khoan de dang ki", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Mat khau khong duoc de trong !!", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
                return;
            }
            if (txtPass.Text.Length < 8)
            {
                this.Focus();
                MessageBox.Show("Mat khau phai tren 8 ki tu !! Vui long nhap lai!! ", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAddreee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddreee_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Dia chi khong duoc de trong !!", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Focus();
            }
        }
    }
}
