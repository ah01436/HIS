namespace HIS
{
    partial class frm_add_department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_department));
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDEPTplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DEPT_notes = new System.Windows.Forms.TextBox();
            this.txt_DEPTname = new System.Windows.Forms.TextBox();
            this.txt_DeptCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.ts_btn_save = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_btn_clear = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip_controrl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_save,
            this.toolStripSeparator2,
            this.ts_btn_clear,
            this.toolStripSeparator1,
            this.ts_btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.ShowItemToolTips = false;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1352, 90);
            this.toolStrip_controrl.TabIndex = 27;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDEPTplace);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DEPT_notes);
            this.panel1.Controls.Add(this.txt_DEPTname);
            this.panel1.Controls.Add(this.txt_DeptCode);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1352, 538);
            this.panel1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1154, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 33);
            this.label3.TabIndex = 72;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1145, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 33);
            this.label2.TabIndex = 71;
            this.label2.Text = "*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDEPTplace
            // 
            this.txtDEPTplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDEPTplace.Location = new System.Drawing.Point(533, 187);
            this.txtDEPTplace.Name = "txtDEPTplace";
            this.txtDEPTplace.Size = new System.Drawing.Size(615, 30);
            this.txtDEPTplace.TabIndex = 1;
            this.txtDEPTplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1350, 47);
            this.label1.TabIndex = 70;
            this.label1.Text = "بيانات الأقسام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DEPT_notes
            // 
            this.txt_DEPT_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DEPT_notes.Location = new System.Drawing.Point(533, 234);
            this.txt_DEPT_notes.Multiline = true;
            this.txt_DEPT_notes.Name = "txt_DEPT_notes";
            this.txt_DEPT_notes.Size = new System.Drawing.Size(616, 213);
            this.txt_DEPT_notes.TabIndex = 2;
            // 
            // txt_DEPTname
            // 
            this.txt_DEPTname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DEPTname.Location = new System.Drawing.Point(533, 130);
            this.txt_DEPTname.Name = "txt_DEPTname";
            this.txt_DEPTname.Size = new System.Drawing.Size(616, 30);
            this.txt_DEPTname.TabIndex = 0;
            this.txt_DEPTname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DEPTname.TextChanged += new System.EventHandler(this.txt_DEPTname_TextChanged);
            // 
            // txt_DeptCode
            // 
            this.txt_DeptCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DeptCode.Location = new System.Drawing.Point(533, 72);
            this.txt_DeptCode.Name = "txt_DeptCode";
            this.txt_DeptCode.ReadOnly = true;
            this.txt_DeptCode.Size = new System.Drawing.Size(616, 30);
            this.txt_DeptCode.TabIndex = 14;
            this.txt_DeptCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DeptCode.TextChanged += new System.EventHandler(this.txt_DeptCode_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1194, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "ملاحظات";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1181, 130);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(106, 23);
            this.label34.TabIndex = 9;
            this.label34.Text = "اسم القسم";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1190, 187);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 23);
            this.label38.TabIndex = 8;
            this.label38.Text = "مكان القسم";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(1181, 79);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 23);
            this.label42.TabIndex = 4;
            this.label42.Text = "كود القسم";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1352, 27);
            this.statusStrip1.TabIndex = 66;
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
            // ts_btn_save
            // 
            this.ts_btn_save.Image = global::HIS.Properties.Resources.save_64;
            this.ts_btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_save.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.ShowDropDownArrow = false;
            this.ts_btn_save.Size = new System.Drawing.Size(68, 87);
            this.ts_btn_save.Text = "حفظ   ";
            this.ts_btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // ts_btn_clear
            // 
            this.ts_btn_clear.Image = global::HIS.Properties.Resources.edit_clear_64;
            this.ts_btn_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_clear.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_clear.Name = "ts_btn_clear";
            this.ts_btn_clear.ShowDropDownArrow = false;
            this.ts_btn_clear.Size = new System.Drawing.Size(87, 87);
            this.ts_btn_clear.Text = "تفريغ الخانات ";
            this.ts_btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_clear.Click += new System.EventHandler(this.ts_btn_clear_Click);
            // 
            // ts_btn_exit
            // 
            this.ts_btn_exit.Image = global::HIS.Properties.Resources.Cancel_64;
            this.ts_btn_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_exit.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_exit.Name = "ts_btn_exit";
            this.ts_btn_exit.ShowDropDownArrow = false;
            this.ts_btn_exit.Size = new System.Drawing.Size(68, 87);
            this.ts_btn_exit.Text = "خروج";
            this.ts_btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_exit.Click += new System.EventHandler(this.ts_btn_exit_Click);
            // 
            // frm_add_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 628);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip_controrl);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_add_department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_add_department_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_add_department_KeyDown);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_exit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_DeptCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        public System.Windows.Forms.TextBox txtDEPTplace;
        public System.Windows.Forms.TextBox txt_DEPT_notes;
        public System.Windows.Forms.TextBox txt_DEPTname;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_curent_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;

    }
}