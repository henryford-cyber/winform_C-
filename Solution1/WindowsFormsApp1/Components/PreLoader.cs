using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Components
{
    public partial class PreLoader : Form
    {
        Thread threadLoading;
        public PreLoader()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ShowLoader()
        {
            threadLoading = new Thread(new ThreadStart(delegate ()
            {
                Application.Run(this);
            }));
            threadLoading.SetApartmentState(ApartmentState.STA);
            threadLoading.Start();
        }

        public void CloseLoader()
        {
            if (this != null)
            {
                this.BeginInvoke(new Action(() => this.Close()));
                threadLoading.Join();
            }
        }
    }
}
