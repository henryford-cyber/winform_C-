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
    public partial class ChiTietLopHop : Form
    {
        public Lophoc lopHoc;
        public ChiTietLopHop(Lophoc lopHoc = null)
        {
            InitializeComponent();
            this.lopHoc = lopHoc;
            txtTenLop.Text = lopHoc?.TenLophoc;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lopHoc == null)
            {
                //theem moi
                lopHoc = new Lophoc
                {
                    MaLophoc = 0,
                    TenLophoc = txtTenLop.Text
                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                //chinh sua
                lopHoc.TenLophoc = txtTenLop.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
