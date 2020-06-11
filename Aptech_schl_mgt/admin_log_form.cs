using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptech_schl_mgt
{
    public partial class admin_log_form : Form
    {
        public admin_log_form()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string pass = "12345";

            if((textBox1.Text == username) && (textBox2.Text == pass))
            {
                admin_form obj4 = new admin_form();
                obj4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user Name and Password!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
