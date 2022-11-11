using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    
    public partial class QLSVForm : Form
    {
        string sinhvienPath = "";
        List<Sinhvien> dsSV;
        public QLSVForm()
        {
            InitializeComponent();
            sinhvienPath = Path.Combine(Application.StartupPath, "sinhvien.txt");
            dsSV = SinhVienService.danhsahsinhvienDocFile(sinhvienPath);
            NapDanhSachLopHoc();
        }
        public int GetSelectedRow(string MaSinhVien)
        {
            for (int i = 0; i < dgvSinhvien.Rows.Count; i++)
            {
                if (dgvSinhvien.Rows[i].Cells[0].Value.ToString() == MaSinhVien)
                {
                    return i;
                }
            }
               
                return -1;
        }
       void NapDanhSachSinhvien()
        {
            var selectLopHoc = cbbLophoc.SelectedItem as Lophoc;
            var lsSinhVien = dsSV.Where(t => t.MaLopHoc == selectLopHoc?.MaLophoc).ToList();
           //.DataSource = lsSinhVien;
            dgvSinhvien.DataSource = lsSinhVien;
        }
        void NapDanhSachLopHoc()
        {
            var listLophoc = LophocService.danhsachlophoc(); 
            cbbLophoc.DataSource = listLophoc;
            cbbLophoc.DisplayMember = "TenLophoc";

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbbLophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDanhSachSinhvien();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs t)
        {
            if (t.KeyChar == 13)
            {
                var keyWord = txtTimKiem.Text;
                var selectedLopHoc = cbbLophoc.SelectedItem as Lophoc;
                //var lsSinhvien = SinhVienService.GetFakeDanhSachsinhvien(selectedLopHoc.MaLophoc,txtTimKiem.Text);
                //dgvSinhvien.DataSource = lsSinhvien;
                var result = dsSV.Where(e =>
                    e.MaLopHoc == selectedLopHoc?.MaLophoc && 
                 ( e.HovaTen.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) > 0 ||
                 e.MaSinhVien.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) > 0)
                 ).ToList();
                dgvSinhvien.DataSource = result;
            }
        }

        private void lblTongsosinhvien_Click(object sender, EventArgs e)
        {

        }

        private void QLSVForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new SinhVienDetailForm();
            f.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //string content = "";
            // foreach(var sv in dsSV)
            // {
            //    content += sv.ToString()+ "\r\n";
            //}
            string json = JsonConvert.SerializeObject(dsSV);

            File.WriteAllText(Path.Combine(Application.StartupPath, "sinhvien.txt"),json);
            MessageBox.Show("Da luu du lieu thanh cong ","Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvSinhvien.SelectedRows.Count > 0)
            {
                var rs = MessageBox.Show("Ban co chan muon xoa khong",
                    "Chu y", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    var sinhvien = dgvSinhvien.SelectedRows[0].DataBoundItem as Sinhvien;
                    if (sinhvien != null)
                    {
                        var _sv = dsSV.Where(t => t.Id == sinhvien.Id).FirstOrDefault();
                        if (_sv != null)
                        {
                            dsSV.Remove(_sv);
                            NapDanhSachSinhvien();
                            MessageBox.Show("Da xoa sinh vien thanh cong", "Thong Bao",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
                            
                        }
                    }
                }

            }
            
        }

        private void QLSVForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
