using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptech_schl_mgt
{
    public partial class staff_sign_in : Form
    {
        public staff_sign_in()
        {
            InitializeComponent();
        }

        string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //Default return type
            bool isSuccess = false;

            //connect DataBase
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                bool success = true;
                //sql Query
                string sql = "INSERT INTO staff_sign_in_db (regnum, class) VALUES ('" + regnum_textBox.Text + "', '" + class_comboBox.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                    // MessageBox.Show("Successful!");

                    try
                    {
                        // sql query
                        string sql2 = "SELECT First_Name + ' ' + Last_Name AS [NAME] FROM Staff_db WHERE ID = '" + regnum_textBox.Text + "'";

                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        SqlDataAdapter adpter = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        adpter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT img FROM staff_db WHERE ID = '" + regnum_textBox.Text + "' ", conn));
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] data = new Byte[0];
                            data = (Byte[])(dataSet.Tables[0].Rows[0]["img"]);
                            MemoryStream mem = new MemoryStream(data);
                            signin_pictureBox.Image = Image.FromStream(mem);
                        }

                        textBox2.Text = "You're Welcome!";


                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        Console.WriteLine(msg);
                    }
                    finally
                    {
                        conn.Close();
                    }


                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            regnum_textBox.Text = "";
            class_comboBox.Text = "";
            textBox2.Text = "";
            dataGridView1.DataSource = "";
            signin_pictureBox.Image = null;
        }
    }
}
