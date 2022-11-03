using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhantram_Click(object sender, EventArgs e)
        {

        }
        string s1 = "";
        private void number_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var value = btn.Tag as string;
            s1 += value;
            var d = Convert.ToDouble(s1);
            lblScreen.Text = $"{d:N0}";
             
              
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            s1 = "0";
            lblScreen.Text = "0";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(s1))
            { 
                s1 = s1.Substring(0, s1.Length - 1);
                decimal d = Convert.ToDecimal(s1);
                lblScreen.Text = $"{d:N0}";
            }
        }
    }
}
