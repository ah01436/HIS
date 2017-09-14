namespace HIS
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_pat = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_visit = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_pregnant = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.add_ultra_report = new System.Windows.Forms.Button();
            this.btn_instructions = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتالسرفرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1362, 27);
            this.statusStrip1.TabIndex = 21;
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
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_department.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_department.Location = new System.Drawing.Point(47, 158);
            this.btn_department.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(157, 75);
            this.btn_department.TabIndex = 22;
            this.btn_department.Text = "الأقسام";
            this.btn_department.UseVisualStyleBackColor = false;
            this.btn_department.Visible = false;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_employee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Location = new System.Drawing.Point(47, 77);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(157, 75);
            this.btn_employee.TabIndex = 23;
            this.btn_employee.Text = "الموظفين";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Visible = false;
            this.btn_employee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pat
            // 
            this.btn_pat.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_pat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pat.Location = new System.Drawing.Point(1144, 74);
            this.btn_pat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_pat.Name = "btn_pat";
            this.btn_pat.Size = new System.Drawing.Size(157, 75);
            this.btn_pat.TabIndex = 24;
            this.btn_pat.Text = "تسجيل مريض";
            this.btn_pat.UseVisualStyleBackColor = false;
            this.btn_pat.Visible = false;
            this.btn_pat.Click += new System.EventHandler(this.btn_pat_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_user.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.Location = new System.Drawing.Point(47, 239);
            this.btn_user.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(157, 75);
            this.btn_user.TabIndex = 24;
            this.btn_user.Text = "المستخدمين ";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Visible = false;
            this.btn_user.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // btn_visit
            // 
            this.btn_visit.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_visit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visit.Location = new System.Drawing.Point(1144, 155);
            this.btn_visit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_visit.Name = "btn_visit";
            this.btn_visit.Size = new System.Drawing.Size(157, 75);
            this.btn_visit.TabIndex = 25;
            this.btn_visit.Text = "فتح زيارة";
            this.btn_visit.UseVisualStyleBackColor = false;
            this.btn_visit.Visible = false;
            this.btn_visit.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_report.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(1144, 236);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(157, 75);
            this.btn_report.TabIndex = 27;
            this.btn_report.Text = "تقرير فتح زيارة ";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Visible = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_pregnant
            // 
            this.btn_pregnant.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_pregnant.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pregnant.Location = new System.Drawing.Point(562, 75);
            this.btn_pregnant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_pregnant.Name = "btn_pregnant";
            this.btn_pregnant.Size = new System.Drawing.Size(194, 75);
            this.btn_pregnant.TabIndex = 28;
            this.btn_pregnant.Text = "قسم الحوامل";
            this.btn_pregnant.UseVisualStyleBackColor = false;
            this.btn_pregnant.Visible = false;
            this.btn_pregnant.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_patient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.Location = new System.Drawing.Point(1144, 317);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(157, 75);
            this.btn_patient.TabIndex = 30;
            this.btn_patient.Text = "عرض المرضى المسجلين";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Visible = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // add_ultra_report
            // 
            this.add_ultra_report.BackColor = System.Drawing.Color.AliceBlue;
            this.add_ultra_report.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ultra_report.Location = new System.Drawing.Point(562, 237);
            this.add_ultra_report.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_ultra_report.Name = "add_ultra_report";
            this.add_ultra_report.Size = new System.Drawing.Size(194, 75);
            this.add_ultra_report.TabIndex = 31;
            this.add_ultra_report.Text = "Admission Ultrasound Report";
            this.add_ultra_report.UseVisualStyleBackColor = false;
            this.add_ultra_report.Visible = false;
            this.add_ultra_report.Click += new System.EventHandler(this.add_ultra_report_Click);
            // 
            // btn_instructions
            // 
            this.btn_instructions.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_instructions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instructions.Location = new System.Drawing.Point(562, 156);
            this.btn_instructions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_instructions.Name = "btn_instructions";
            this.btn_instructions.Size = new System.Drawing.Size(194, 75);
            this.btn_instructions.TabIndex = 32;
            this.btn_instructions.Text = "تعليمات الطبيب / العلاج";
            this.btn_instructions.UseVisualStyleBackColor = false;
            this.btn_instructions.Visible = false;
            this.btn_instructions.Click += new System.EventHandler(this.btn_instructions_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1178, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 23);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "الاستقبال";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(905, 37);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 23);
            this.linkLabel2.TabIndex = 34;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "النساء ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(623, 34);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(80, 23);
            this.linkLabel3.TabIndex = 35;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "الحوامل";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(355, 38);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(66, 23);
            this.linkLabel4.TabIndex = 36;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "الولادة";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(94, 40);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(59, 23);
            this.linkLabel6.TabIndex = 38;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "ادارى";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعداداتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 29);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اعداداتToolStripMenuItem
            // 
            this.اعداداتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالخروجToolStripMenuItem,
            this.اعداداتالسرفرToolStripMenuItem});
            this.اعداداتToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.اعداداتToolStripMenuItem.Name = "اعداداتToolStripMenuItem";
            this.اعداداتToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.اعداداتToolStripMenuItem.Text = "اعدادات";
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click);
            // 
            // اعداداتالسرفرToolStripMenuItem
            // 
            this.اعداداتالسرفرToolStripMenuItem.Name = "اعداداتالسرفرToolStripMenuItem";
            this.اعداداتالسرفرToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.اعداداتالسرفرToolStripMenuItem.Text = "اعدادات السرفر";
            this.اعداداتالسرفرToolStripMenuItem.Click += new System.EventHandler(this.اعداداتالسرفرToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::HIS.Properties.Resources.Hospital2;
            this.ClientSize = new System.Drawing.Size(1362, 733);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_instructions);
            this.Controls.Add(this.add_ultra_report);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_pregnant);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_visit);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_pat);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_department);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسة ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        //  private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_curent_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_pat;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_visit;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_pregnant;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Button add_ultra_report;
        private System.Windows.Forms.Button btn_instructions;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اعداداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعداداتالسرفرToolStripMenuItem;
        //private System.Windows.Forms.Button btnPatinet;

    }
}