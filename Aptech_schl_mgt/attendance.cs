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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void attendance_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter ada = new SqlDataAdapter("SELECT First_Name +' ' + Last_Name AS[Full Name], Laptop, time_in, class, faculty, time_Out FROM student_db JOIN sign_in_db ON student_db.ID = sign_in_db.regnnum ORDER BY time_in DESC ", conn);
            DataTable dt = new DataTable();
            //ada.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter ada = new SqlDataAdapter("SELECT First_Name +' ' + Last_Name AS[Full Name], Laptop, time_in, class, faculty, time_Out FROM student_db JOIN sign_in_db ON student_db.ID = sign_in_db.regnnum ORDER BY time_in DESC ", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
