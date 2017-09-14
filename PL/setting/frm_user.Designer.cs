namespace HIS
{
    partial class frm_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gb_patient_search = new System.Windows.Forms.GroupBox();
            this.rdb_user_name = new System.Windows.Forms.RadioButton();
            this.rdb_emp_name = new System.Windows.Forms.RadioButton();
            this.rdb_emp_id = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btn_add = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip_controrl.SuspendLayout();
            this.gb_patient_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.toolStripSeparator2,
            this.btn_edit,
            this.toolStripSeparator1,
            this.btn_delete,
            this.toolStripSeparator3,
            this.btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1060, 90);
            this.toolStrip_controrl.TabIndex = 28;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 90);
            // 
            // gb_patient_search
            // 
            this.gb_patient_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_patient_search.Controls.Add(this.rdb_user_name);
            this.gb_patient_search.Controls.Add(this.rdb_emp_name);
            this.gb_patient_search.Controls.Add(this.rdb_emp_id);
            this.gb_patient_search.Controls.Add(this.txt_search);
            this.gb_patient_search.Controls.Add(this.label1);
            this.gb_patient_search.Location = new System.Drawing.Point(0, 91);
            this.gb_patient_search.Name = "gb_patient_search";
            this.gb_patient_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_patient_search.Size = new System.Drawing.Size(1060, 117);
            this.gb_patient_search.TabIndex = 29;
            this.gb_patient_search.TabStop = false;
            this.gb_patient_search.Text = "البحث عن قسم ";
            // 
            // rdb_user_name
            // 
            this.rdb_user_name.AutoSize = true;
            this.rdb_user_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_user_name.Location = new System.Drawing.Point(149, 76);
            this.rdb_user_name.Name = "rdb_user_name";
            this.rdb_user_name.Size = new System.Drawing.Size(160, 27);
            this.rdb_user_name.TabIndex = 4;
            this.rdb_user_name.Text = "اسم المستخدم ";
            this.rdb_user_name.UseVisualStyleBackColor = true;
            this.rdb_user_name.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // rdb_emp_name
            // 
            this.rdb_emp_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_emp_name.AutoSize = true;
            this.rdb_emp_name.Checked = true;
            this.rdb_emp_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_emp_name.Location = new System.Drawing.Point(474, 76);
            this.rdb_emp_name.Name = "rdb_emp_name";
            this.rdb_emp_name.Size = new System.Drawing.Size(131, 27);
            this.rdb_emp_name.TabIndex = 3;
            this.rdb_emp_name.TabStop = true;
            this.rdb_emp_name.Text = "اسم الموظف";
            this.rdb_emp_name.UseVisualStyleBackColor = true;
            this.rdb_emp_name.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // rdb_emp_id
            // 
            this.rdb_emp_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_emp_id.AutoSize = true;
            this.rdb_emp_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_emp_id.Location = new System.Drawing.Point(763, 76);
            this.rdb_emp_id.Name = "rdb_emp_id";
            this.rdb_emp_id.Size = new System.Drawing.Size(120, 27);
            this.rdb_emp_id.TabIndex = 2;
            this.rdb_emp_id.Text = "كود الموظف";
            this.rdb_emp_id.UseVisualStyleBackColor = true;
            this.rdb_emp_id.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_search.Location = new System.Drawing.Point(147, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(736, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "ادخل نص البحث ";
            this.toolTip1.SetToolTip(this.txt_search, "ادخل نص البحث");
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص البحث ";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_user.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_user.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_user.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_user.Location = new System.Drawing.Point(0, 214);
            this.dgv_user.MultiSelect = false;
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(1060, 413);
            this.dgv_user.TabIndex = 30;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1060, 27);
            this.statusStrip1.TabIndex = 31;
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
            // btn_add
            // 
            this.btn_add.Image = global::HIS.Properties.Resources.if_Add_Male_User_49576;
            this.btn_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowDropDownArrow = false;
            this.btn_add.Size = new System.Drawing.Size(68, 87);
            this.btn_add.Text = "إضافة";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::HIS.Properties.Resources.edit_profile_;
            this.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edit.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShowDropDownArrow = false;
            this.btn_edit.Size = new System.Drawing.Size(68, 87);
            this.btn_edit.Text = "تعديل ";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::HIS.Properties.Resources._1_04_64;
            this.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowDropDownArrow = false;
            this.btn_delete.Size = new System.Drawing.Size(68, 87);
            this.btn_delete.Text = "حذف ";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::HIS.Properties.Resources.Cancel_64;
            this.btn_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_exit.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShowDropDownArrow = false;
            this.btn_exit.Size = new System.Drawing.Size(68, 87);
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.gb_patient_search);
            this.Controls.Add(this.dgv_user);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_user";
            this.Text = "المستخدمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.gb_patient_search.ResumeLayout(false);
            this.gb_patient_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripDropDownButton btn_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton btn_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripDropDownButton btn_exit;
        private System.Windows.Forms.GroupBox gb_patient_search;
        private System.Windows.Forms.RadioButton rdb_user_name;
        private System.Windows.Forms.RadioButton rdb_emp_name;
        private System.Windows.Forms.RadioButton rdb_emp_id;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_curent_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrTime;
    }
}