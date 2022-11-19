using DuAn.Component;
using DuAn.Component.ImageUtils;
using DuAn.Connection;
using DuAn.Model;
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
    public partial class ProfileView : Form

    {   
        public string pathImage;
        public ProfileView()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void ProfileView_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDataProfile();
        }
        private void LoadDataProfile()
        {
            sql = "SELECT * FROM account where id = '" + lblId.Text + "'";
            LoginForm.LoadData(sql);
            lblId.Text = LoginForm.accLogin.Id.ToString();
            txtFullname.Text = LoginForm.accLogin.fullname;
            txtPhone.Text = LoginForm.accLogin.phonenumber.ToString();
            txtUsername.Text = LoginForm.accLogin.username;
            txtPass.Text = LoginForm.accLogin.password;
            txtAddress.Text = LoginForm.accLogin.address;
            txtType.Text = LoginForm.accLogin.type;

            if (!string.IsNullOrEmpty(LoginForm.accLogin.images))
            {
                pictureBox1.Image = ImageUtils.ResizeImage($"{ImageUtils.AppPathImage}{LoginForm.accLogin.images}", 185, 178);
            }
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
            lblId.ForeColor = ThemeColor.PrimaryColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pathImage = ImageUtils.Store(openFileDialog.FileName, openFileDialog.SafeFileName);
                pictureBox1.Image = ImageUtils.ResizeImage($"{ImageUtils.AppPathImage}{pathImage}", 423, 308);

               
                   ///MessageBox.Show(pathImage);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            sql = "UPDATE account set `fullname`='" + txtFullname.Text + "',`phonenumber`='" + txtPhone.Text + "',`address`='" + txtAddress.Text + "',`username`='" + txtUsername.Text + "',`password`='" +txtPass.Text + "',`image`='" + pathImage + "',`type`='" + txtType.Text + "' WHERE id ='" + lblId.Text + "'";
            config.Execute_CUD(sql,  "Cap nhap that bai vui long thu lai sau !","Cap nhap thanh cong ! ");
            LoadDataProfile();  
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
