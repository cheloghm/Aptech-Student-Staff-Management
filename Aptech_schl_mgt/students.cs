//using Aptech_schl_mgt.AptechClass;
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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
            hover_panel3.Width = newstud_btn.Width;
            hover_panel3.Left = newstud_btn.Left;
        }

       // A_register_class c = new A_register_class();

        string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void newstaff_btn_Click(object sender, EventArgs e)
        {

            hover_panel3.Width = newstud_btn.Width;
            hover_panel3.Left = newstud_btn.Left;

            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();

            try
            {
                bool isSuccess;

                MemoryStream ms = new MemoryStream();
                stud_picture.Image.Save(ms, stud_picture.Image.RawFormat);
                byte[] img = ms.ToArray();

                //sql Query
                string sql = "INSERT INTO student_db (First_Name, Last_Name, Email, Course, Phone, Address, Laptop, Gender, img) VALUES ('" + fname_textBox.Text + "', '" + lname_textBox.Text + "', '" + email_textBox.Text + "', '" + course_comboBox.Text + "', '" +
                    phone_textBox.Text + "', '" + address_textBox.Text + "', '" + laptop_textBox.Text + "', '" + gender_comboBox.Text + "', @img)";
                

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                    MessageBox.Show("Successful!");
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            hover_panel3.Width = update_btn.Width;
            hover_panel3.Left = update_btn.Left;

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();

            try
            {
                string sql = "UPDATE student_db SET First_Name = '" + fname_textBox.Text + "', Last_Name = '" + lname_textBox.Text + "', Email = '" + email_textBox.Text + "', Course = '" + course_comboBox.Text + "', Phone = '" + phone_textBox.Text + "', Address = '" + address_textBox.Text + "', Laptop = '" + laptop_textBox.Text + "', Gender = '" + gender_comboBox.Text + "', img = @img WHERE ID = '" + regnum_textBox.Text + "' ";

                MemoryStream ms = new MemoryStream();
                stud_picture.Image.Save(ms, stud_picture.Image.RawFormat);
                byte[] img = ms.ToArray();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                    MessageBox.Show("Successful!");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            hover_panel3.Width = delete_btn.Width;
            hover_panel3.Left = delete_btn.Left;

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();

            try
            {
                string sql = "DELETE FROM student_db WHERE ID = '" + regnum_textBox.Text + "' ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                    MessageBox.Show("Successful!");
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

            }

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            hover_panel3.Width = refresh_btn.Width;
            hover_panel3.Left = refresh_btn.Left;

            regnum_textBox.Text = "";
            fname_textBox.Text = "";
            lname_textBox.Text = "";
            email_textBox.Text = "";
            course_comboBox.Text = "";
            phone_textBox.Text = "";
            address_textBox.Text = "";
            laptop_textBox.Text = "";
            gender_comboBox.Text = "";
            stud_picture.Image = null;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM student_db";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adpter = new SqlDataAdapter(cmd);

                conn.Open();
                adpter.Fill(dt);

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

            dataGridView1.DataSource = dt;

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only.(*.jpg; *.jpeg; *.png, *.gif)| *.jpg; *.jpeg; *.png, *.gif";

            if(OpenFd.ShowDialog() == DialogResult.OK)
            {
                stud_picture.Image = Image.FromFile(OpenFd.FileName);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            regnum_textBox.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            fname_textBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            lname_textBox.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            email_textBox.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            phone_textBox.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            address_textBox.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            laptop_textBox.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            course_comboBox.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();         
            gender_comboBox.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            var data = (Byte[])(dataGridView1.Rows[rowIndex].Cells[9].Value);
            var stream = new MemoryStream(data);
            stud_picture.Image = Image.FromStream(stream);
        }

        private void students_Load(object sender, EventArgs e)
        {
            regnum_textBox.Text = "";
            fname_textBox.Text = "";
            lname_textBox.Text = "";
            email_textBox.Text = "";
            course_comboBox.Text = "";
            phone_textBox.Text = "";
            address_textBox.Text = "";
            laptop_textBox.Text = "";
            gender_comboBox.Text = "";
            stud_picture.Image = null;


            // DataBaseConnection

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM student_db";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adpter = new SqlDataAdapter(cmd);

                conn.Open();
                adpter.Fill(dt);

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

            dataGridView1.DataSource = dt;
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = search_textBox.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM student_db WHERE First_Name LIKE '%" + keyword + "%' OR Last_Name LIKE '%" + keyword + "%' OR Email LIKE '%" + keyword + "%' OR Phone LIKE '%" + keyword + "%' OR Course LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
