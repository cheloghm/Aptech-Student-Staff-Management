using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptech_schl_mgt
{
    public partial class visitors_db : Form
    {
        public visitors_db()
        {
            InitializeComponent();
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter ada = new SqlDataAdapter("SELECT First_Name +' ' + Last_Name AS[Full Name], Email, Phone, time FROM visitors_db ORDER BY time DESC ", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void visitors_db_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter ada = new SqlDataAdapter("SELECT First_Name +' ' + Last_Name AS[Full Name], Email, Phone, time FROM visitors_db ORDER BY time DESC ", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM visitors_db WHERE First_Name LIKE '%" + keyword + "%' OR Last_Name LIKE '%" + keyword + "%' OR Email LIKE '%" + keyword + "%' OR Phone LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
           /* Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvCityDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvCityDetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCityDetails.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCityDetails.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }*/

        }
    }
}
