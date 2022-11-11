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
    public partial class LopHocForm : Form
    {
        List<Lophoc> dsLopHoc = new List<Lophoc>();
        public LopHocForm()
        {
            InitializeComponent();
            dsLopHoc = LophocService.danhsachlophoc();
            //Lấy ds lớp học 1 lần khi chạy
            NapDanhSachLopHoc();
        }
        void NapDanhSachLopHoc()
        {
            lophocBindingSource.DataSource = null;
            lophocBindingSource.DataSource = dsLopHoc;
            lblSolophoc.Text = $"{dsLopHoc.Count}";
            dgvLopHoc.DataSource = lophocBindingSource;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedLopHoc = lophocBindingSource.Current as Lophoc;
            if (selectedLopHoc != null)
            {
                var rs = MessageBox.Show("Ban co chac lka muon xoa lop hoc nay khong ?", 
                    "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(rs == DialogResult.OK)
                {
                    // var lopHocCanXoa = dsLopHoc.Where(t => t.MaLophoc == selectedLopHoc.MaLophoc).FirstOrDefault();
                    lophocBindingSource.RemoveCurrent();
                    NapDanhSachLopHoc();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var selectedLopHoc = lophocBindingSource.Current as Lophoc;
            if (selectedLopHoc != null)
            {
                var f = new ChiTietLopHop(selectedLopHoc);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    NapDanhSachLopHoc();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new ChiTietLopHop();
            if (f.ShowDialog() == DialogResult.OK)
            {
                dsLopHoc.Add(f.lopHoc);
                NapDanhSachLopHoc();
            }
        }
    }
}
