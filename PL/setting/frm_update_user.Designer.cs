namespace HIS
{
    partial class frm_update_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_update_user));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_repeat_password = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_old_pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.ts_btn_exit = new System.Windows.Forms.Button();
            this.ts_btn_clear = new System.Windows.Forms.Button();
            this.ts_btn_save = new System.Windows.Forms.Button();
            this.cb_show_new_pwd = new System.Windows.Forms.CheckBox();
            this.cb_showpassword = new System.Windows.Forms.CheckBox();
            this.btn_search_employee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 47);
            this.label1.TabIndex = 70;
            this.label1.Text = "بيانات المستخدم ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_show_new_pwd);
            this.panel1.Controls.Add(this.cb_showpassword);
            this.panel1.Controls.Add(this.txt_user_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_search_employee);
            this.panel1.Controls.Add(this.txt_emp_name);
            this.panel1.Controls.Add(this.txt_emp_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_repeat_password);
            this.panel1.Controls.Add(this.txt_user_name);
            this.panel1.Controls.Add(this.txt_old_pass);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(999, 474);
            this.panel1.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(736, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 33);
            this.label8.TabIndex = 97;
            this.label8.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(736, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 33);
            this.label5.TabIndex = 95;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(736, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "*";
            // 
            // txt_user_id
            // 
            this.txt_user_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_user_id.Location = new System.Drawing.Point(114, 64);
            this.txt_user_id.Name = "txt_user_id";
            this.txt_user_id.ReadOnly = true;
            this.txt_user_id.Size = new System.Drawing.Size(616, 30);
            this.txt_user_id.TabIndex = 77;
            this.txt_user_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "كود المستخدم";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emp_name.Location = new System.Drawing.Point(115, 342);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.ReadOnly = true;
            this.txt_emp_name.Size = new System.Drawing.Size(460, 30);
            this.txt_emp_name.TabIndex = 74;
            this.txt_emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emp_id.Location = new System.Drawing.Point(599, 342);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.ReadOnly = true;
            this.txt_emp_id.Size = new System.Drawing.Size(131, 30);
            this.txt_emp_id.TabIndex = 73;
            this.txt_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "الموظف";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Location = new System.Drawing.Point(115, 229);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(615, 30);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_repeat_password
            // 
            this.txt_repeat_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_repeat_password.Location = new System.Drawing.Point(114, 276);
            this.txt_repeat_password.Name = "txt_repeat_password";
            this.txt_repeat_password.Size = new System.Drawing.Size(616, 30);
            this.txt_repeat_password.TabIndex = 2;
            this.txt_repeat_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_repeat_password.UseSystemPasswordChar = true;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_user_name.Location = new System.Drawing.Point(114, 172);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(616, 30);
            this.txt_user_name.TabIndex = 0;
            this.txt_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_old_pass
            // 
            this.txt_old_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_old_pass.Location = new System.Drawing.Point(114, 114);
            this.txt_old_pass.Name = "txt_old_pass";
            this.txt_old_pass.Size = new System.Drawing.Size(616, 30);
            this.txt_old_pass.TabIndex = 14;
            this.txt_old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_old_pass.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(786, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "تأكيد كلمة المرور";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(793, 169);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(136, 23);
            this.label34.TabIndex = 9;
            this.label34.Text = "اسم المستخدم";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(766, 225);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(163, 23);
            this.label38.TabIndex = 8;
            this.label38.Text = "كلمة المرور الجديدة";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(759, 113);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(170, 23);
            this.lb_user.TabIndex = 4;
            this.lb_user.Text = "كلمة المرور القديمة ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.ts_btn_exit);
            this.panel2.Controls.Add(this.ts_btn_clear);
            this.panel2.Controls.Add(this.ts_btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 100);
            this.panel2.TabIndex = 69;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lb_curent_user,
            this.toolStripStatusLabel3,
            this.lblDate,
            this.toolStripStatusLabel5,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(999, 27);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 22);
            this.toolStripStatusLabel1.Text = "إسم المستخدم : ";
            // 
            // lb_curent_user
            // 
            this.lb_curent_user.Name = "lb_curent_user";
            this.lb_curent_user.Size = new System.Drawing.Size(55, 22);
            this.lb_curent_user.Text = "لا يوجد";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 22);
            this.toolStripStatusLabel3.Text = "تاريخ اليوم : ";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(100, 22);
            this.lblDate.Text = "00/00/0000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(102, 22);
            this.toolStripStatusLabel5.Text = "الوقت الحالي : ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(115, 22);
            this.lblTime.Text = "00:00:00 PM";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // ts_btn_exit
            // 
            this.ts_btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ts_btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ts_btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ts_btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ts_btn_exit.Image = global::HIS.Properties.Resources.Cancel_64;
            this.ts_btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ts_btn_exit.Location = new System.Drawing.Point(633, 3);
            this.ts_btn_exit.Name = "ts_btn_exit";
            this.ts_btn_exit.Size = new System.Drawing.Size(121, 92);
            this.ts_btn_exit.TabIndex = 70;
            this.ts_btn_exit.Text = "إلغاء";
            this.ts_btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_exit.UseVisualStyleBackColor = false;
            this.ts_btn_exit.Click += new System.EventHandler(this.ts_btn_exit_Click);
            // 
            // ts_btn_clear
            // 
            this.ts_btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ts_btn_clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ts_btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ts_btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ts_btn_clear.Image = global::HIS.Properties.Resources.edit_clear_64;
            this.ts_btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ts_btn_clear.Location = new System.Drawing.Point(753, 3);
            this.ts_btn_clear.Name = "ts_btn_clear";
            this.ts_btn_clear.Size = new System.Drawing.Size(121, 92);
            this.ts_btn_clear.TabIndex = 69;
            this.ts_btn_clear.Text = "تفريغ الخانات";
            this.ts_btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_clear.UseVisualStyleBackColor = false;
            this.ts_btn_clear.Click += new System.EventHandler(this.ts_btn_clear_Click);
            // 
            // ts_btn_save
            // 
            this.ts_btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ts_btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ts_btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ts_btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ts_btn_save.Image = global::HIS.Properties.Resources.save_64;
            this.ts_btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ts_btn_save.Location = new System.Drawing.Point(873, 3);
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.Size = new System.Drawing.Size(121, 92);
            this.ts_btn_save.TabIndex = 68;
            this.ts_btn_save.Text = "حفظ";
            this.ts_btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_save.UseVisualStyleBackColor = false;
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // cb_show_new_pwd
            // 
            this.cb_show_new_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_show_new_pwd.AutoSize = true;
            this.cb_show_new_pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_show_new_pwd.Image = global::HIS.Properties.Resources.Show_32x32;
            this.cb_show_new_pwd.Location = new System.Drawing.Point(61, 229);
            this.cb_show_new_pwd.Name = "cb_show_new_pwd";
            this.cb_show_new_pwd.Size = new System.Drawing.Size(47, 32);
            this.cb_show_new_pwd.TabIndex = 79;
            this.cb_show_new_pwd.UseVisualStyleBackColor = true;
            this.cb_show_new_pwd.CheckedChanged += new System.EventHandler(this.cb_show_new_pwd_CheckedChanged);
            // 
            // cb_showpassword
            // 
            this.cb_showpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_showpassword.AutoSize = true;
            this.cb_showpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_showpassword.Image = global::HIS.Properties.Resources.Show_32x32;
            this.cb_showpassword.Location = new System.Drawing.Point(61, 113);
            this.cb_showpassword.Name = "cb_showpassword";
            this.cb_showpassword.Size = new System.Drawing.Size(47, 32);
            this.cb_showpassword.TabIndex = 78;
            this.cb_showpassword.UseVisualStyleBackColor = true;
            this.cb_showpassword.CheckedChanged += new System.EventHandler(this.cb_showpassword_CheckedChanged);
            // 
            // btn_search_employee
            // 
            this.btn_search_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_employee.Image = global::HIS.Properties.Resources.search__2_;
            this.btn_search_employee.Location = new System.Drawing.Point(736, 327);
            this.btn_search_employee.Name = "btn_search_employee";
            this.btn_search_employee.Size = new System.Drawing.Size(67, 59);
            this.btn_search_employee.TabIndex = 75;
            this.btn_search_employee.UseVisualStyleBackColor = true;
            this.btn_search_employee.Click += new System.EventHandler(this.btn_search_employee_Click);
            // 
            // frm_update_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 580);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_update_user";
            this.Text = "إضافة مستخدمين ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_update_user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_repeat_password;
        public System.Windows.Forms.TextBox txt_user_name;
        public System.Windows.Forms.TextBox txt_old_pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lb_user;
        public System.Windows.Forms.TextBox txt_emp_name;
        public System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search_employee;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button ts_btn_save;
        public System.Windows.Forms.Button ts_btn_exit;
        public System.Windows.Forms.Button ts_btn_clear;
        public System.Windows.Forms.TextBox txt_user_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_show_new_pwd;
        private System.Windows.Forms.CheckBox cb_showpassword;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_curent_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}