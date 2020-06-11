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
    public partial class staff_sign_out_form : Form
    {
        public staff_sign_out_form()
        {
            InitializeComponent();
        }

        string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void submit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();

            try
            {
                string sql = "UPDATE staff_sign_in_db SET time_out = GETDATE() Where regnum = '" + regnum_textBox.Text + "' AND day = day(getdate()) AND month = MONTH(getdate()) AND year = year(getdate())";

                SqlCommand cmd = new SqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // isSuccess = true;
                    MessageBox.Show("Successful!");
                }
                else
                {
                    //isSuccess = false;
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
        }
    }
}
