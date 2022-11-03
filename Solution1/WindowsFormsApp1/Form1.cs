using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elasticsearch.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        ErrorProvider error;
        bool Validation()
        {
            try
            {
                if (error == null)
                    error = new ErrorProvider();
                error.Clear();
                var _soThuNhat = txt1.Text;
                var _soThuHai = txt2.Text;
                if (string.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txt1, "Vui lòng nhập số !");
                    return false;
                }

                if (string.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txt2, "vui lòng nhập số !!");
                    return false;
                }
                double temp = 0;
                if (!double.TryParse(_soThuNhat, out temp))
                {
                    error.SetError(txt1, "Vui lòng nhập số thứ nhất");
                    return false;
                }
                if (!double.TryParse(_soThuHai, out temp))
                {
                    error.SetError(txt2, "Vui lòng nhập số thứ hai");
                    return false;
                }
                var soThuNhat = double.Parse(_soThuNhat);
                var soThuHai = double.Parse(_soThuHai);
                var ketqua = soThuNhat + soThuHai;
                lblKetqua.Text = ketqua.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("ok");
            }
            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
           try
            {
                Validation();
                var _soThuNhat = txt1.Text;
                var _soThuHai = txt2.Text; 
                var soThuNhat = double.Parse(_soThuNhat);
                var soThuHai = double.Parse(_soThuHai);
                var ketqua = soThuNhat + soThuHai;
                lblKetqua.Text = ketqua.ToString();
            }
            catch(Exception ex) { }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            var _soThuNhat = txt1.Text;
            var _soThuHai = txt2.Text;
            var soThuNhat = double.Parse(_soThuNhat);
            var soThuHai = double.Parse(_soThuHai);
            var ketqua = soThuNhat - soThuHai;
            lblKetqua.Text = ketqua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            var _soThuNhat = txt1.Text;
            var _soThuHai = txt2.Text;
            var soThuNhat = double.Parse(_soThuNhat);
            var soThuHai = double.Parse(_soThuHai);
            var ketqua = soThuNhat * soThuHai;
            lblKetqua.Text = ketqua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            var _soThuNhat = txt1.Text;
            var _soThuHai = txt2.Text;
            var soThuNhat = double.Parse(_soThuNhat);
            var soThuHai = double.Parse(_soThuHai);
            var ketqua = soThuNhat / soThuHai;
            lblKetqua.Text = ketqua.ToString();
        }

        private void lblTacgia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new FormTacgia();
            f.ShowDialog();
        }
    }
}
