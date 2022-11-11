using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class SinhVienDetailForm : Form
    {
        public SinhVienDetailForm()
        {
            InitializeComponent();
            NapDanhSach();
        }
        public void setNull()
        {
            txtMaSinhVien.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            rdoNam.Checked = true;
            txtDiaChi.Text = "";
            
        }
        void NapDanhSach()
        {
            //var listLophoc = LophocService.GetFakeData();
            //cmbMaLop.DataSource = listLophoc;
            //cmbMaLop.DisplayMember = "TenLophoc";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SinhVienDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var selectLopHoc = cmbMaLop.SelectedItem as Lophoc;
           // var listSinhvien = SinhVienService.GetFakeDanhsachSV(selectLopHoc.MaLophoc);
            
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            SinhVienDetailForm sv = new SinhVienDetailForm();
            this.Close();
            
        }

        private void SinhVienDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnBoQua_Leave(object sender, EventArgs e)
        {
            
        }

        private void SinhVienDetailForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
