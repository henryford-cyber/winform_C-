using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormOclock : Form
    {
        public FormOclock()
        {
            InitializeComponent(); 
        }
        int count = 0;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {  
            timer1.Start(); 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                var path = Path.Combine(Application.StartupPath, "amthanh", "ok.wav");
                var soud = new SoundPlayer(path);
                soud.Play();


                timer1.Stop();
               
            }
            lblTime.Text = convert(count);
        }
        private void numPhut_Value_ValueChanged(object sender, EventArgs e)
        {
            
        }
        string convert(int second)
        { 
            var p = second / 60;
            var s = second % 60;
            return Convert.ToString($"{p:0#}:{s:0#}"); 
        }

        private void contextMenu_Click(object sender, EventArgs e)
        {
            var f = new settingForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                count = f.minutes * 60;
                lblTime/**/.Text = convert(count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            count = 0;
            lblTime.Text = convert(count);
        }
    }
}
