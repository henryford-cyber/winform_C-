using DuAn.Connection;
using DuAn.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
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
using Windows.UI.Xaml;

namespace DuAn.View
{
    public partial class LoginForm : Form
    {
        public static Account accLogin = new Account();
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
        public static void LoadData(string sql)
        {

            string cs = @"server=localhost;userid=root;password='';database=quanlysinhvien";
            using var con = new MySqlConnection(cs);
            con.Open();

            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                accLogin.Id = rdr.GetInt32(0);
                accLogin.fullname = rdr.GetString(1);
                accLogin.phonenumber = rdr.GetInt32(2);
                accLogin.address = rdr.GetString(3);
                accLogin.username = rdr.GetString(4);
                accLogin.password = rdr.GetString(5);
                accLogin.images = rdr.GetString(6);
                accLogin.type = rdr.GetString(7);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            sql = " SELECT* FROM account WHERE username = '" + txtusername.Text + "' and password = '" + txtpass.Text + "'";
            config.singleResult(sql);
            LoadData(sql);
            if (config.dt.Rows.Count > 0)
            {
                FormMenu home = new FormMenu();
                this.Hide();
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
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog(); 
            this.Close();
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if (txtusername.Text == string.Empty)
            {
                MessageBox.Show("Tai khoan khong duoc de trong !!","Thong bao !",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (txtpass.Text == string.Empty)
            {
                MessageBox.Show("Mat khau khong duoc de trong !!", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
