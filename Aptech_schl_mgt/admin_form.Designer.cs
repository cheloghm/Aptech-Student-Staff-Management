namespace Aptech_schl_mgt
{
    partial class admin_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attend_btn = new System.Windows.Forms.Button();
            this.stud_btn = new System.Windows.Forms.Button();
            this.staff_btn = new System.Windows.Forms.Button();
            this.visitor_btn = new System.Windows.Forms.Button();
            this.staffatend_btn = new System.Windows.Forms.Button();
            this.hover_panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // attend_btn
            // 
            this.attend_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attend_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attend_btn.Location = new System.Drawing.Point(75, 71);
            this.attend_btn.Name = "attend_btn";
            this.attend_btn.Size = new System.Drawing.Size(127, 51);
            this.attend_btn.TabIndex = 0;
            this.attend_btn.Text = "Student\r\nAttendance";
            this.attend_btn.UseVisualStyleBackColor = true;
            this.attend_btn.Click += new System.EventHandler(this.attend_btn_Click);
            // 
            // stud_btn
            // 
            this.stud_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stud_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_btn.Location = new System.Drawing.Point(75, 190);
            this.stud_btn.Name = "stud_btn";
            this.stud_btn.Size = new System.Drawing.Size(127, 51);
            this.stud_btn.TabIndex = 2;
            this.stud_btn.Text = "Students";
            this.stud_btn.UseVisualStyleBackColor = true;
            this.stud_btn.Click += new System.EventHandler(this.stud_btn_Click);
            // 
            // staff_btn
            // 
            this.staff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_btn.Location = new System.Drawing.Point(75, 247);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(127, 51);
            this.staff_btn.TabIndex = 3;
            this.staff_btn.Text = "Staff";
            this.staff_btn.UseVisualStyleBackColor = true;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // visitor_btn
            // 
            this.visitor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_btn.Location = new System.Drawing.Point(75, 304);
            this.visitor_btn.Name = "visitor_btn";
            this.visitor_btn.Size = new System.Drawing.Size(127, 51);
            this.visitor_btn.TabIndex = 4;
            this.visitor_btn.Text = "Visitors";
            this.visitor_btn.UseVisualStyleBackColor = true;
            this.visitor_btn.Click += new System.EventHandler(this.visitor_btn_Click);
            // 
            // staffatend_btn
            // 
            this.staffatend_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffatend_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffatend_btn.Location = new System.Drawing.Point(75, 128);
            this.staffatend_btn.Name = "staffatend_btn";
            this.staffatend_btn.Size = new System.Drawing.Size(127, 56);
            this.staffatend_btn.TabIndex = 1;
            this.staffatend_btn.Text = "Staff\r\nAttendance";
            this.staffatend_btn.UseVisualStyleBackColor = true;
            this.staffatend_btn.Click += new System.EventHandler(this.staffatend_btn_Click);
            // 
            // hover_panel2
            // 
            this.hover_panel2.BackColor = System.Drawing.Color.Brown;
            this.hover_panel2.Location = new System.Drawing.Point(75, 71);
            this.hover_panel2.Name = "hover_panel2";
            this.hover_panel2.Size = new System.Drawing.Size(14, 51);
            this.hover_panel2.TabIndex = 7;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(284, 436);
            this.Controls.Add(this.hover_panel2);
            this.Controls.Add(this.staffatend_btn);
            this.Controls.Add(this.visitor_btn);
            this.Controls.Add(this.staff_btn);
            this.Controls.Add(this.stud_btn);
            this.Controls.Add(this.attend_btn);
            this.MaximizeBox = false;
            this.Name = "admin_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attend_btn;
        private System.Windows.Forms.Button stud_btn;
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Button visitor_btn;
        private System.Windows.Forms.Button staffatend_btn;
        private System.Windows.Forms.Panel hover_panel2;
    }
}