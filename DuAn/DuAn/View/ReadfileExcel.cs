using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn.View
{
    public partial class ReadfileExcel : Form
    {
        public ReadfileExcel()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string path = fil.FileName.ToString();
            // MessageBox.Show(path);
            ExcelFileReader(path);

        }
        public void ExcelFileReader(string path)
        {
            txtPath.Text = path;
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);

            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table in tables)
            {
                dataGridView1.DataSource = table;
            }
            MessageBox.Show("Doc file thanh cong ","Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
