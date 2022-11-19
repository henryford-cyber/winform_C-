using DuAn.Component;
using DuAn.Model;
using DuAn.Service;
using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace DuAn.View
{
    public partial class classView : Form
    {   
        List<Class> listClass = new List<Class>();
        public classView()
        {
            InitializeComponent();
            listClass = ClassService.ListClass();
            LoadDataClass();

        }
        void LoadDataClass() 
        {
            classBindingSource.DataSource = null;
            classBindingSource.DataSource = listClass;
            lblTotal1.Text = $"{listClass.Count}";
            dgvLophoc.DataSource = classBindingSource;
        }
        private void classView_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (System.Windows.Forms.Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            } 
            lblTotal2.ForeColor = ThemeColor.PrimaryColor;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var create = new CreateClass();
            if(create.ShowDialog() == DialogResult.OK)
            {
                listClass.Add(create.classs);
                LoadDataClass();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
                var rs = MessageBox.Show("Ban co chac la muon xoa lop hoc nay khong ?",
                    "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                listClass.RemoveAt(dgvLophoc.SelectedRows[0].Index);
                LoadDataClass();
                    MessageBox.Show("Xoa Lop Hoc Thanh Cong","Thong bao ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     
                

            }
        }

        private void dgvLophoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedClass = classBindingSource.Current as Class;
            if (selectedClass != null)
            {
                var form = new CreateClass(selectedClass);
                if (form.ShowDialog() == DialogResult.OK)
                { 
                    LoadDataClass();
                    
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs t)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
             var keyword =txtSearch.Text;
             var result= listClass.Where(e =>(
             e.className.Contains(keyword,StringComparison.OrdinalIgnoreCase)||
             e.homeroomTeacher.Contains(keyword,StringComparison.OrdinalIgnoreCase))).ToList();
             dgvLophoc.DataSource = result;
                        
        }

        private void btnReadfile_Click(object sender, EventArgs e) 
        {   
          ReadfileExcel readfileExcel = new ReadfileExcel();
            readfileExcel.ShowDialog();


        }
 
        private void btnExport_Click(object sender, EventArgs e)
        {
            //This line of code creates a text file for the data export.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Data\ListClass.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= dgvLophoc.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dgvLophoc.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dgvLophoc.Rows[r].Cells[c].Value;
                        if (c != dgvLophoc.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + "|";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void dgvLophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
