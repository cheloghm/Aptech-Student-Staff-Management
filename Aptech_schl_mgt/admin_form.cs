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
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
            hover_panel2.Height = attend_btn.Height;
            hover_panel2.Top = attend_btn.Top;
        }

        private void attend_btn_Click(object sender, EventArgs e)
        {
            hover_panel2.Height = attend_btn.Height;
            hover_panel2.Top = attend_btn.Top;
            attendance obj5 = new attendance();
            obj5.Show();
        }

        private void stud_btn_Click(object sender, EventArgs e)
        {
            hover_panel2.Height = stud_btn.Height;
            hover_panel2.Top = stud_btn.Top;
            students obj6 = new students();
            obj6.Show();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            hover_panel2.Height = staff_btn.Height;
            hover_panel2.Top = staff_btn.Top;
            staff obj7 = new staff();
            obj7.Show();
        }

        private void visitor_btn_Click(object sender, EventArgs e)
        {
            hover_panel2.Height = visitor_btn.Height;
            hover_panel2.Top = visitor_btn.Top;
            visitors_db obj9 = new visitors_db();
            obj9.Show();
        }

        private void staffatend_btn_Click(object sender, EventArgs e)
        {
            hover_panel2.Height = staffatend_btn.Height;
            hover_panel2.Top = staffatend_btn.Top;
            staff_attend_form obj9 = new staff_attend_form();
            obj9.Show();
        }
    }
}
