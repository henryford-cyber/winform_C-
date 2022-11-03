using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class imagesForm : Form
    {
        public imagesForm()
        {
            InitializeComponent();
            cmbCheDo.SelectedIndex = 2;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbCheDo.SelectedIndex;
             
            switch (index)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            } 
        }
        

        private void btnRight_Click(object sender, EventArgs e)
        {
            Image image = pictureBox1.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = image;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Image image = pictureBox1.Image;
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = image;
        }

        private void lnkChonFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chon file anh ";
            var rs =openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureBox1.ImageLocation = fileName;
            }

        }

        private void lnkChonThuMuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog(); 
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true; 
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
               
            }
        }
    }
}
