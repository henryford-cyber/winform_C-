using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class SliderShow : Form
    {
        public SliderShow()
        {
            InitializeComponent();
        }
         
        List<string> listImagesPath;
        int imgNumber = 0;
        private void lnkChonThuMuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fodelName = dialog.SelectedPath;
               var listFile =  Directory.GetFiles(fodelName);
                //Hàm lấy các file trong thư mục được chọn
               
               foreach(var file in listFile)
                {
                    if (isImage(file))
                    {
                        if (listImagesPath == null)
                         
                            listImagesPath = new List<string>();
                        listImagesPath.Add(file);
                    }
                }
               foreach(var images in listImagesPath)
                {
                    PictureBox p = new PictureBox();
                    p.ImageLocation = images;
                    p.Height = 250;
                    p.Width = 250;
                    p.SizeMode = PictureBoxSizeMode.Zoom;
                    p.Click += P_Click;
                    flowLayoutPanel1.Controls.Add(p);
                    
                }

            }
        }
       
        bool isImage(string fileName)
        {
            try
            {
                Image image = Image.FromFile(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
       // bool isImages(string pathFile)
       // {
          //  FileInfo fileInfo = new FileInfo(pathFile);
          //  var ext = fileInfo.Extension.ToLower();
           // var lsAccept = new string[] { ".jpg", ".png", ".jpeg" };

      //  }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             picImages.ImageLocation = listImagesPath[imgNumber];
            if(imgNumber == listImagesPath.Count -1)
            {
                imgNumber = 0;
                return;
            }
            imgNumber++;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void picImages_Click(object sender, EventArgs e)
        {
            picImages.ImageLocation = listImagesPath[imgNumber];
            if (imgNumber == listImagesPath.Count - 1)
            {
                imgNumber = 0;
                return;
            }
            imgNumber++;
        }

        private void P_Click(object sender, EventArgs e)
        {
            PictureBox p =(PictureBox)sender;
            picImages.ImageLocation = p.ImageLocation;
            timer1.Stop();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void picImages_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
             
        }
    }
}
