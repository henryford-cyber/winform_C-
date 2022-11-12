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
    public partial class LoginForm : Form
    {
        public Account account;
        List<Account> listAccount = new List<Account>();
        public LoginForm()
        {
            listAccount = AccountService.getAllAcount();
            MessageBox.Show(listAccount.Count.ToString());
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             
        }
    }
}
