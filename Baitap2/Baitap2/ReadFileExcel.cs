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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
            void LoadGridData()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("EmpNo.", typeof(int));
                dt.Columns.Add("Emp.Name", typeof(string));
                dt.Columns.Add("Hiredate", typeof(DateTime));
                dt.Columns.Add("Department", typeof(int));
                dt.Columns.Add("Salary", typeof(double));

                DataRow dr = dt.NewRow();
                dr["EmpNo."] = 1;
                dr["Emp.Name"] = "Nguyễn Thảo";
                dr["Hiredate"] = DateTime.Now;
                dr["Department"] = 20;
                dr["Salary"] = 15000;

                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["EmpNo."] = 2;
                dr["Emp.Name"] = "Trịnh Quốc Khang";
                dr["Hiredate"] = DateTime.Now.AddMinutes(1);
                dr["Department"] = 30;
                dr["Salary"] = 17000;

                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["EmpNo."] = 3;
                dr["Emp.Name"] = "Nguyễn Đình Tuyên";
                dr["Hiredate"] = DateTime.Now.AddMinutes(1);
                dr["Department"] = 30;
                dr["Salary"] = 17000;

                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["EmpNo."] = 4;
                dr["Emp.Name"] = "Hoàng Thị Thảo";
                dr["Hiredate"] = DateTime.Now.AddMinutes(1);
                dr["Department"] = 30;
                dr["Salary"] = 17000;

                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["EmpNo."] = 4;
                dr["Emp.Name"] = "Cái Trí Minh";
                dr["Hiredate"] = DateTime.Now.AddMinutes(1);
                dr["Department"] = 30;
                dr["Salary"] = 17000;

                dt.Rows.Add(dr);

                dataGridView1.DataSource = dt;
            }

        private void ReadFileExcel_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}
