namespace HIS
{
    partial class frm_department
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
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_search = new System.Windows.Forms.TextBox();
            this.gb_patient_search = new System.Windows.Forms.GroupBox();
            this.rdb_phone = new System.Windows.Forms.RadioButton();
            this.rdb_name = new System.Windows.Forms.RadioButton();
            this.rdb_id = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_department = new System.Windows.Forms.DataGridView();
            this.toolStrip_controrl.SuspendLayout();
            this.gb_patient_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department)).BeginInit();
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
            this.toolStrip_controrl.Size = new System.Drawing.Size(954, 90);
            this.toolStrip_controrl.TabIndex = 24;
            this.toolStrip_controrl.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 90);
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
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_search.Location = new System.Drawing.Point(147, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(630, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "ادخل نص البحث ";
            this.toolTip1.SetToolTip(this.txt_search, "ادخل نص البحث");
            // 
            // gb_patient_search
            // 
            this.gb_patient_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_patient_search.Controls.Add(this.rdb_phone);
            this.gb_patient_search.Controls.Add(this.rdb_name);
            this.gb_patient_search.Controls.Add(this.rdb_id);
            this.gb_patient_search.Controls.Add(this.txt_search);
            this.gb_patient_search.Controls.Add(this.label1);
            this.gb_patient_search.Location = new System.Drawing.Point(0, 84);
            this.gb_patient_search.Name = "gb_patient_search";
            this.gb_patient_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_patient_search.Size = new System.Drawing.Size(954, 117);
            this.gb_patient_search.TabIndex = 26;
            this.gb_patient_search.TabStop = false;
            this.gb_patient_search.Text = "البحث عن مريض ";
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
            // 
            // rdb_name
            // 
            this.rdb_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_name.AutoSize = true;
            this.rdb_name.Checked = true;
            this.rdb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_name.Location = new System.Drawing.Point(419, 87);
            this.rdb_name.Name = "rdb_name";
            this.rdb_name.Size = new System.Drawing.Size(77, 27);
            this.rdb_name.TabIndex = 3;
            this.rdb_name.TabStop = true;
            this.rdb_name.Text = "الاسم";
            this.rdb_name.UseVisualStyleBackColor = true;
            // 
            // rdb_id
            // 
            this.rdb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_id.AutoSize = true;
            this.rdb_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_id.Location = new System.Drawing.Point(658, 87);
            this.rdb_id.Name = "rdb_id";
            this.rdb_id.Size = new System.Drawing.Size(117, 27);
            this.rdb_id.TabIndex = 2;
            this.rdb_id.Text = "كود المريض";
            this.rdb_id.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص البحث ";
            // 
            // dgv_department
            // 
            this.dgv_department.AllowUserToAddRows = false;
            this.dgv_department.AllowUserToDeleteRows = false;
            this.dgv_department.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_department.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_department.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_department.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_department.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_department.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_department.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_department.Location = new System.Drawing.Point(0, 207);
            this.dgv_department.MultiSelect = false;
            this.dgv_department.Name = "dgv_department";
            this.dgv_department.ReadOnly = true;
            this.dgv_department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_department.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_department.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_department.Size = new System.Drawing.Size(954, 255);
            this.dgv_department.TabIndex = 27;
            // 
            // frm_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 462);
            this.Controls.Add(this.dgv_department);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.gb_patient_search);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_department_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.gb_patient_search.ResumeLayout(false);
            this.gb_patient_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox gb_patient_search;
        private System.Windows.Forms.RadioButton rdb_phone;
        private System.Windows.Forms.RadioButton rdb_name;
        private System.Windows.Forms.RadioButton rdb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_department;
    }
}