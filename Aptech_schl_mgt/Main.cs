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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            hover_panel.Height = signin_btn.Height;
            hover_panel.Top = signin_btn.Top;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if(pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }

        }

        //Not working starts here

        private void signin_btn_Click(object sender, EventArgs e)
        {
            hover_panel.Height = signin_btn.Height;
            hover_panel.Top = signin_btn.Top;
            sign_in_form obj = new sign_in_form();
            obj.Show();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            hover_panel.Height = signout_btn.Height;
            hover_panel.Top = signout_btn.Top;
            sign_out_form obj2 = new sign_out_form();
            obj2.Show();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            hover_panel.Height = help_btn.Height;
            hover_panel.Top = help_btn.Top;
            admin_log_form obj3 = new admin_log_form();
            obj3.Show();
        }

        private void visitor_btn_Click_1(object sender, EventArgs e)
        {
            hover_panel.Height = visitor_btn.Height;
            hover_panel.Top = visitor_btn.Top;
            visitors obj8 = new visitors();
            obj8.Show();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            hover_panel.Height = staff_btn.Height;
            hover_panel.Top = staff_btn.Top;
            staff_sign_in obj9 = new staff_sign_in();
            obj9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
        //Not working ends here

        private void st_sign_btn_Click(object sender, EventArgs e)
        {
            hover.Height = st_sign_btn.Height;
            hover.Top = st_sign_btn.Top;
            sign_in_form obj = new sign_in_form();
            obj.Show();
        }

        private void staff_btn_Click_1(object sender, EventArgs e)
        {
            hover.Height = staff_btn.Height;
            hover.Top = staff_btn.Top;
            staff_sign_in obj2 = new staff_sign_in();
            obj2.Show();
        }

        private void sign_out_btn_Click(object sender, EventArgs e)
        {
            hover.Height = sign_out_btn.Height;
            hover.Top = sign_out_btn.Top;
            sign_out_form obj3 = new sign_out_form();
            obj3.Show();
        }

        private void vist_btn_Click(object sender, EventArgs e)
        {
            hover.Height = vist_btn.Height;
            hover.Top = vist_btn.Top;
            visitors obj4 = new visitors();
            obj4.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            hover.Height = helpBtn.Height;
            hover.Top = helpBtn.Top;
            admin_log_form obj5 = new admin_log_form();
            obj5.Show();
        }

        private void signout2_btn_Click(object sender, EventArgs e)
        {
            hover.Height = signout2_btn.Height;
            hover.Top = signout2_btn.Top;
            staff_sign_out_form obj6 = new staff_sign_out_form();
            obj6.Show();
        }
    }
}
