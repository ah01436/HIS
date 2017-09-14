namespace HIS
{
    partial class frm_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employee));
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_search = new System.Windows.Forms.TextBox();
            this.gb_employee_search = new System.Windows.Forms.GroupBox();
            this.rdb_phone = new System.Windows.Forms.RadioButton();
            this.rdb_name = new System.Windows.Forms.RadioButton();
            this.rdb_id = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btn_ok = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_add = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip_controrl.SuspendLayout();
            this.gb_employee_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ok,
            this.btn_add,
            this.btn_edit,
            this.btn_delete,
            this.btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1156, 90);
            this.toolStrip_controrl.TabIndex = 28;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_search.Location = new System.Drawing.Point(147, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(820, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "ادخل نص البحث ";
            this.toolTip1.SetToolTip(this.txt_search, "ادخل نص البحث");
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // gb_employee_search
            // 
            this.gb_employee_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_employee_search.Controls.Add(this.rdb_phone);
            this.gb_employee_search.Controls.Add(this.rdb_name);
            this.gb_employee_search.Controls.Add(this.rdb_id);
            this.gb_employee_search.Controls.Add(this.txt_search);
            this.gb_employee_search.Controls.Add(this.label1);
            this.gb_employee_search.Location = new System.Drawing.Point(0, 111);
            this.gb_employee_search.Name = "gb_employee_search";
            this.gb_employee_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_employee_search.Size = new System.Drawing.Size(1144, 117);
            this.gb_employee_search.TabIndex = 29;
            this.gb_employee_search.TabStop = false;
            this.gb_employee_search.Text = "البحث عن موظف";
            // 
            // rdb_phone
            // 
            this.rdb_phone.AutoSize = true;
            this.rdb_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_phone.Location = new System.Drawing.Point(147, 87);
            this.rdb_phone.Name = "rdb_phone";
            this.rdb_phone.Size = new System.Drawing.Size(110, 27);
            this.rdb_phone.TabIndex = 4;
            this.rdb_phone.Text = "رقم الهاتف";
            this.rdb_phone.UseVisualStyleBackColor = true;
            this.rdb_phone.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // rdb_name
            // 
            this.rdb_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_name.AutoSize = true;
            this.rdb_name.Checked = true;
            this.rdb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_name.Location = new System.Drawing.Point(514, 87);
            this.rdb_name.Name = "rdb_name";
            this.rdb_name.Size = new System.Drawing.Size(77, 27);
            this.rdb_name.TabIndex = 3;
            this.rdb_name.TabStop = true;
            this.rdb_name.Text = "الاسم";
            this.rdb_name.UseVisualStyleBackColor = true;
            this.rdb_name.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // rdb_id
            // 
            this.rdb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_id.AutoSize = true;
            this.rdb_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_id.Location = new System.Drawing.Point(845, 87);
            this.rdb_id.Name = "rdb_id";
            this.rdb_id.Size = new System.Drawing.Size(120, 27);
            this.rdb_id.TabIndex = 2;
            this.rdb_id.Text = "كود الموظف";
            this.rdb_id.UseVisualStyleBackColor = true;
            this.rdb_id.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(973, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص البحث ";
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_employee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_employee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_employee.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_employee.Location = new System.Drawing.Point(12, 234);
            this.dgv_employee.MultiSelect = false;
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(1132, 196);
            this.dgv_employee.TabIndex = 30;
            this.dgv_employee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_CellDoubleClick);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1156, 27);
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
            // btn_ok
            // 
            this.btn_ok.Image = global::HIS.Properties.Resources.download;
            this.btn_ok.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ok.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.ShowDropDownArrow = false;
            this.btn_ok.Size = new System.Drawing.Size(52, 87);
            this.btn_ok.Text = "موافق";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_Ok_Click);
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
            // frm_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1156, 432);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.gb_employee_search);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_employee";
            this.Text = "الموظفين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_employee_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.gb_employee_search.ResumeLayout(false);
            this.gb_employee_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_add;
        public System.Windows.Forms.ToolStripDropDownButton btn_edit;
        public System.Windows.Forms.ToolStripDropDownButton btn_delete;
        public System.Windows.Forms.ToolStripDropDownButton btn_exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox gb_employee_search;
        private System.Windows.Forms.RadioButton rdb_phone;
        private System.Windows.Forms.RadioButton rdb_name;
        private System.Windows.Forms.RadioButton rdb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_employee;
        public System.Windows.Forms.ToolStripDropDownButton btn_ok;
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