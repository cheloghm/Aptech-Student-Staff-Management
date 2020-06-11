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
    public partial class visitors : Form
    {
        public visitors()
        {
            InitializeComponent();
        }

        string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void v_signin_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // bool success = true;
                //sql Query
                string sql = "INSERT INTO visitors_db (First_Name, Last_Name, Email, Phone) VALUES ('" + fname_textBox.Text + "', '" + lname_textBox.Text + "', '" + email_textBox.Text + "', '" + phone_textBox.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Successful!");
                }
                else
                {
                    // isSuccess = false;
                    MessageBox.Show("Declined!");
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
            fname_textBox.Text = "";
            lname_textBox.Text = "";
            email_textBox.Text = "";
            phone_textBox.Text = "";
        }
    }
}
