using Project.Utils;
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
    public partial class ForgotPassword : Form
    {
        public string emailForgot { get; set; }
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Email.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email chưa đúng định dạng !");
                return;
            }
            this.emailForgot = txtEmail.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
