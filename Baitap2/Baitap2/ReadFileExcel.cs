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
using ExcelDataReader;


namespace Baitap2
{
    public partial class ReadFileExcel : Form
    {
        public ReadFileExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string path = fil.FileName.ToString();
           // MessageBox.Show(path);
            ExcelFileReader(path);

        }
        public void ExcelFileReader(string path)
        {     
            var stream = File.Open(path, FileMode.Open, FileAccess.Read); 
                var reader = ExcelReaderFactory.CreateReader(stream);   
                  
                    var result = reader.AsDataSet();
                    var tables = result.Tables.Cast<DataTable>();
                    foreach (DataTable table in tables)
                    {
                        dataGridView1.DataSource = table;
                    }


        }

    }
}
