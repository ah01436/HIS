namespace HIS
{
    partial class frm_visit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_visit));
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_docSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_organizationSearch = new System.Windows.Forms.Button();
            this.cmb_entities = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_DiagnosisSearch = new System.Windows.Forms.Button();
            this.cb_initialDiagnosis = new System.Windows.Forms.ComboBox();
            this.txt_entry_date = new System.Windows.Forms.TextBox();
            this.txt_entry_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_emp_search = new System.Windows.Forms.Button();
            this.btn_doc_search = new System.Windows.Forms.Button();
            this.cb_visit_type = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.txt_visit_id = new System.Windows.Forms.TextBox();
            this.txt_docName = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_curent_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_patient = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_Husband_Name = new System.Windows.Forms.TextBox();
            this.txt_patientIdentity = new System.Windows.Forms.TextBox();
            this.txt_patientJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PatientAge = new System.Windows.Forms.TextBox();
            this.txt_patientAddress = new System.Windows.Forms.TextBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_PatRelativePhone = new System.Windows.Forms.TextBox();
            this.txt_PatRelativeidentity = new System.Windows.Forms.TextBox();
            this.txt_PatRelativestate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PatRelativejob = new System.Windows.Forms.TextBox();
            this.txt_PatRelativeaddress = new System.Windows.Forms.TextBox();
            this.txt_PatRelativeName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.toolStrip_controrl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grp_patient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.SteelBlue;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(12, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1318, 46);
            this.label16.TabIndex = 121;
            this.label16.Text = "بيانات خاصة بفتح زيارة مريضة\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_docSearch);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_organizationSearch);
            this.groupBox1.Controls.Add(this.cmb_entities);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_DiagnosisSearch);
            this.groupBox1.Controls.Add(this.cb_initialDiagnosis);
            this.groupBox1.Controls.Add(this.txt_entry_date);
            this.groupBox1.Controls.Add(this.txt_entry_time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_emp_search);
            this.groupBox1.Controls.Add(this.btn_doc_search);
            this.groupBox1.Controls.Add(this.cb_visit_type);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.label62);
            this.groupBox1.Controls.Add(this.textBox28);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.txt_visit_id);
            this.groupBox1.Controls.Add(this.txt_docName);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Location = new System.Drawing.Point(0, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1342, 274);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الزيارة";
            // 
            // txt_docSearch
            // 
            this.txt_docSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_docSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_docSearch.Image = global::HIS.Properties.Resources.search32;
            this.txt_docSearch.Location = new System.Drawing.Point(475, 104);
            this.txt_docSearch.Name = "txt_docSearch";
            this.txt_docSearch.Size = new System.Drawing.Size(46, 36);
            this.txt_docSearch.TabIndex = 13;
            this.txt_docSearch.UseVisualStyleBackColor = false;
            this.txt_docSearch.Click += new System.EventHandler(this.txt_docSearch_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1117, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 23);
            this.label15.TabIndex = 159;
            this.label15.Text = "الجهة المرسل منها المريض";
            // 
            // txt_organizationSearch
            // 
            this.txt_organizationSearch.Image = global::HIS.Properties.Resources.plus1;
            this.txt_organizationSearch.Location = new System.Drawing.Point(809, 206);
            this.txt_organizationSearch.Name = "txt_organizationSearch";
            this.txt_organizationSearch.Size = new System.Drawing.Size(39, 38);
            this.txt_organizationSearch.TabIndex = 158;
            this.txt_organizationSearch.UseVisualStyleBackColor = true;
            this.txt_organizationSearch.Click += new System.EventHandler(this.txt_organizationSearch_Click);
            // 
            // cmb_entities
            // 
            this.cmb_entities.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_entities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_entities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_entities.FormattingEnabled = true;
            this.cmb_entities.Location = new System.Drawing.Point(854, 211);
            this.cmb_entities.Name = "cmb_entities";
            this.cmb_entities.Size = new System.Drawing.Size(250, 31);
            this.cmb_entities.TabIndex = 157;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 23);
            this.label14.TabIndex = 156;
            this.label14.Text = "التشخيص المبدئى";
            // 
            // txt_DiagnosisSearch
            // 
            this.txt_DiagnosisSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DiagnosisSearch.Image = global::HIS.Properties.Resources.plus1;
            this.txt_DiagnosisSearch.Location = new System.Drawing.Point(158, 161);
            this.txt_DiagnosisSearch.Name = "txt_DiagnosisSearch";
            this.txt_DiagnosisSearch.Size = new System.Drawing.Size(39, 38);
            this.txt_DiagnosisSearch.TabIndex = 155;
            this.txt_DiagnosisSearch.UseVisualStyleBackColor = true;
            this.txt_DiagnosisSearch.Click += new System.EventHandler(this.txt_DiagnosisSearch_Click);
            // 
            // cb_initialDiagnosis
            // 
            this.cb_initialDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_initialDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_initialDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_initialDiagnosis.FormattingEnabled = true;
            this.cb_initialDiagnosis.Location = new System.Drawing.Point(220, 166);
            this.cb_initialDiagnosis.Name = "cb_initialDiagnosis";
            this.cb_initialDiagnosis.Size = new System.Drawing.Size(249, 31);
            this.cb_initialDiagnosis.TabIndex = 154;
            // 
            // txt_entry_date
            // 
            this.txt_entry_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_entry_date.Location = new System.Drawing.Point(854, 109);
            this.txt_entry_date.Name = "txt_entry_date";
            this.txt_entry_date.ReadOnly = true;
            this.txt_entry_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_entry_date.Size = new System.Drawing.Size(250, 30);
            this.txt_entry_date.TabIndex = 153;
            // 
            // txt_entry_time
            // 
            this.txt_entry_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_entry_time.Enabled = false;
            this.txt_entry_time.Location = new System.Drawing.Point(220, 54);
            this.txt_entry_time.Name = "txt_entry_time";
            this.txt_entry_time.ReadOnly = true;
            this.txt_entry_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_entry_time.Size = new System.Drawing.Size(249, 30);
            this.txt_entry_time.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1186, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 151;
            this.label1.Text = "كود الزيارة";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(475, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 0);
            this.button2.TabIndex = 149;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_emp_search
            // 
            this.btn_emp_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emp_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_emp_search.BackgroundImage")));
            this.btn_emp_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_emp_search.Location = new System.Drawing.Point(1133, 464);
            this.btn_emp_search.Name = "btn_emp_search";
            this.btn_emp_search.Size = new System.Drawing.Size(44, 31);
            this.btn_emp_search.TabIndex = 147;
            this.btn_emp_search.UseVisualStyleBackColor = true;
            // 
            // btn_doc_search
            // 
            this.btn_doc_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_doc_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doc_search.BackgroundImage")));
            this.btn_doc_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doc_search.Location = new System.Drawing.Point(1255, 159);
            this.btn_doc_search.Name = "btn_doc_search";
            this.btn_doc_search.Size = new System.Drawing.Size(44, 0);
            this.btn_doc_search.TabIndex = 146;
            this.btn_doc_search.UseVisualStyleBackColor = true;
            // 
            // cb_visit_type
            // 
            this.cb_visit_type.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_visit_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_visit_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_visit_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_visit_type.FormattingEnabled = true;
            this.cb_visit_type.Items.AddRange(new object[] {
            "حوامل(1)",
            "حوامل(2)",
            "حوامل(3)",
            "حوامل(4)",
            "حوامل(5)",
            "نساء (1)",
            "نساء (2)",
            "نساء (3)",
            "نساء (4)",
            "نساء (5)"});
            this.cb_visit_type.Location = new System.Drawing.Point(854, 159);
            this.cb_visit_type.Name = "cb_visit_type";
            this.cb_visit_type.Size = new System.Drawing.Size(250, 31);
            this.cb_visit_type.Sorted = true;
            this.cb_visit_type.TabIndex = 145;
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(1179, 167);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(100, 23);
            this.label61.TabIndex = 137;
            this.label61.Text = "نوع الدخول ";
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(1186, 462);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(160, 23);
            this.label62.TabIndex = 136;
            this.label62.Text = "اسم موظف الدخول";
            // 
            // textBox28
            // 
            this.textBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox28.Location = new System.Drawing.Point(854, 456);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(271, 30);
            this.textBox28.TabIndex = 138;
            // 
            // label68
            // 
            this.label68.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(1177, 112);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(105, 23);
            this.label68.TabIndex = 139;
            this.label68.Text = "تاريخ الدخول\r\n";
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(531, 62);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(116, 23);
            this.label69.TabIndex = 135;
            this.label69.Text = "ساعة الدخول\r\n";
            // 
            // txt_visit_id
            // 
            this.txt_visit_id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_visit_id.Enabled = false;
            this.txt_visit_id.Location = new System.Drawing.Point(854, 55);
            this.txt_visit_id.Name = "txt_visit_id";
            this.txt_visit_id.ReadOnly = true;
            this.txt_visit_id.Size = new System.Drawing.Size(250, 30);
            this.txt_visit_id.TabIndex = 129;
            // 
            // txt_docName
            // 
            this.txt_docName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_docName.Enabled = false;
            this.txt_docName.Location = new System.Drawing.Point(220, 108);
            this.txt_docName.Name = "txt_docName";
            this.txt_docName.Size = new System.Drawing.Size(249, 30);
            this.txt_docName.TabIndex = 128;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(527, 111);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(157, 23);
            this.label50.TabIndex = 125;
            this.label50.Text = "اسم طبيب الدخول";
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.btn_edit,
            this.btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1342, 90);
            this.toolStrip_controrl.TabIndex = 123;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::HIS.Properties.Resources.save_64;
            this.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowDropDownArrow = false;
            this.btn_save.Size = new System.Drawing.Size(68, 87);
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
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
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lb_curent_user,
            this.toolStripStatusLabel3,
            this.lblDate,
            this.toolStripStatusLabel5,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(17, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1342, 24);
            this.statusStrip1.TabIndex = 124;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 19);
            this.toolStripStatusLabel1.Text = "إسم المستخدم : ";
            // 
            // lb_curent_user
            // 
            this.lb_curent_user.Name = "lb_curent_user";
            this.lb_curent_user.Size = new System.Drawing.Size(45, 19);
            this.lb_curent_user.Text = "لا يوجد";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 19);
            this.toolStripStatusLabel3.Text = "تاريخ اليوم : ";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(81, 19);
            this.lblDate.Text = "00/00/0000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(89, 19);
            this.toolStripStatusLabel5.Text = "الوقت الحالي : ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(96, 19);
            this.lblTime.Text = "00:00:00 PM";
            // 
            // grp_patient
            // 
            this.grp_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_patient.Controls.Add(this.btn_search);
            this.grp_patient.Controls.Add(this.txt_Husband_Name);
            this.grp_patient.Controls.Add(this.txt_patientIdentity);
            this.grp_patient.Controls.Add(this.txt_patientJob);
            this.grp_patient.Controls.Add(this.label5);
            this.grp_patient.Controls.Add(this.label6);
            this.grp_patient.Controls.Add(this.label7);
            this.grp_patient.Controls.Add(this.txt_PatientAge);
            this.grp_patient.Controls.Add(this.txt_patientAddress);
            this.grp_patient.Controls.Add(this.txt_patientName);
            this.grp_patient.Controls.Add(this.label4);
            this.grp_patient.Controls.Add(this.label3);
            this.grp_patient.Controls.Add(this.label2);
            this.grp_patient.Location = new System.Drawing.Point(662, 182);
            this.grp_patient.Name = "grp_patient";
            this.grp_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_patient.Size = new System.Drawing.Size(678, 214);
            this.grp_patient.TabIndex = 125;
            this.grp_patient.TabStop = false;
            this.grp_patient.Text = "بيانات خاصة بالمريضة";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Image = global::HIS.Properties.Resources.search32;
            this.btn_search.Location = new System.Drawing.Point(559, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 36);
            this.btn_search.TabIndex = 12;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_Husband_Name
            // 
            this.txt_Husband_Name.Enabled = false;
            this.txt_Husband_Name.Location = new System.Drawing.Point(3, 154);
            this.txt_Husband_Name.Name = "txt_Husband_Name";
            this.txt_Husband_Name.Size = new System.Drawing.Size(224, 30);
            this.txt_Husband_Name.TabIndex = 11;
            // 
            // txt_patientIdentity
            // 
            this.txt_patientIdentity.Enabled = false;
            this.txt_patientIdentity.Location = new System.Drawing.Point(3, 92);
            this.txt_patientIdentity.Name = "txt_patientIdentity";
            this.txt_patientIdentity.Size = new System.Drawing.Size(224, 30);
            this.txt_patientIdentity.TabIndex = 10;
            // 
            // txt_patientJob
            // 
            this.txt_patientJob.Enabled = false;
            this.txt_patientJob.Location = new System.Drawing.Point(3, 34);
            this.txt_patientJob.Name = "txt_patientJob";
            this.txt_patientJob.Size = new System.Drawing.Size(224, 30);
            this.txt_patientJob.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "اسم الزوج";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "الرقم القومى";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "المهنة";
            // 
            // txt_PatientAge
            // 
            this.txt_PatientAge.Enabled = false;
            this.txt_PatientAge.Location = new System.Drawing.Point(349, 150);
            this.txt_PatientAge.Name = "txt_PatientAge";
            this.txt_PatientAge.Size = new System.Drawing.Size(206, 30);
            this.txt_PatientAge.TabIndex = 5;
            // 
            // txt_patientAddress
            // 
            this.txt_patientAddress.Enabled = false;
            this.txt_patientAddress.Location = new System.Drawing.Point(349, 97);
            this.txt_patientAddress.Name = "txt_patientAddress";
            this.txt_patientAddress.Size = new System.Drawing.Size(206, 30);
            this.txt_patientAddress.TabIndex = 4;
            // 
            // txt_patientName
            // 
            this.txt_patientName.Enabled = false;
            this.txt_patientName.Location = new System.Drawing.Point(344, 39);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(211, 30);
            this.txt_patientName.TabIndex = 3;
            this.txt_patientName.TextChanged += new System.EventHandler(this.txt_patientName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "السن";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_PatRelativePhone);
            this.groupBox3.Controls.Add(this.txt_PatRelativeidentity);
            this.groupBox3.Controls.Add(this.txt_PatRelativestate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_PatRelativejob);
            this.groupBox3.Controls.Add(this.txt_PatRelativeaddress);
            this.groupBox3.Controls.Add(this.txt_PatRelativeName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(42, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(617, 211);
            this.groupBox3.TabIndex = 126;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات خاصة بأقارب المريضة";
            // 
            // txt_PatRelativePhone
            // 
            this.txt_PatRelativePhone.Enabled = false;
            this.txt_PatRelativePhone.Location = new System.Drawing.Point(6, 151);
            this.txt_PatRelativePhone.Name = "txt_PatRelativePhone";
            this.txt_PatRelativePhone.Size = new System.Drawing.Size(193, 30);
            this.txt_PatRelativePhone.TabIndex = 23;
            // 
            // txt_PatRelativeidentity
            // 
            this.txt_PatRelativeidentity.Enabled = false;
            this.txt_PatRelativeidentity.Location = new System.Drawing.Point(6, 89);
            this.txt_PatRelativeidentity.Name = "txt_PatRelativeidentity";
            this.txt_PatRelativeidentity.Size = new System.Drawing.Size(193, 30);
            this.txt_PatRelativeidentity.TabIndex = 22;
            // 
            // txt_PatRelativestate
            // 
            this.txt_PatRelativestate.Enabled = false;
            this.txt_PatRelativestate.Location = new System.Drawing.Point(6, 31);
            this.txt_PatRelativestate.Name = "txt_PatRelativestate";
            this.txt_PatRelativestate.Size = new System.Drawing.Size(193, 30);
            this.txt_PatRelativestate.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "رقم الهاتف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "الرقم القومى";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "درجة القرابة";
            // 
            // txt_PatRelativejob
            // 
            this.txt_PatRelativejob.Enabled = false;
            this.txt_PatRelativejob.Location = new System.Drawing.Point(317, 152);
            this.txt_PatRelativejob.Name = "txt_PatRelativejob";
            this.txt_PatRelativejob.Size = new System.Drawing.Size(192, 30);
            this.txt_PatRelativejob.TabIndex = 17;
            // 
            // txt_PatRelativeaddress
            // 
            this.txt_PatRelativeaddress.Enabled = false;
            this.txt_PatRelativeaddress.Location = new System.Drawing.Point(317, 91);
            this.txt_PatRelativeaddress.Name = "txt_PatRelativeaddress";
            this.txt_PatRelativeaddress.Size = new System.Drawing.Size(192, 30);
            this.txt_PatRelativeaddress.TabIndex = 16;
            // 
            // txt_PatRelativeName
            // 
            this.txt_PatRelativeName.Enabled = false;
            this.txt_PatRelativeName.Location = new System.Drawing.Point(317, 34);
            this.txt_PatRelativeName.Name = "txt_PatRelativeName";
            this.txt_PatRelativeName.Size = new System.Drawing.Size(192, 30);
            this.txt_PatRelativeName.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "المهنة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(510, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "محل الاقامة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "الاسم";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 719);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_patient);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_visit";
            this.Text = "فتح زيارة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_visit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_patient.ResumeLayout(false);
            this.grp_patient.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_emp_search;
        private System.Windows.Forms.Button btn_doc_search;
        private System.Windows.Forms.ComboBox cb_visit_type;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txt_docName;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_save;
        public System.Windows.Forms.ToolStripDropDownButton btn_exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_curent_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_visit_id;
        private System.Windows.Forms.TextBox txt_entry_time;
        private System.Windows.Forms.TextBox txt_entry_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox grp_patient;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button txt_docSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button txt_organizationSearch;
        public System.Windows.Forms.ComboBox cmb_entities;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button txt_DiagnosisSearch;
        public System.Windows.Forms.ComboBox cb_initialDiagnosis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_Husband_Name;
        public System.Windows.Forms.TextBox txt_patientIdentity;
        public System.Windows.Forms.TextBox txt_patientJob;
        public System.Windows.Forms.TextBox txt_PatientAge;
        public System.Windows.Forms.TextBox txt_patientAddress;
        public System.Windows.Forms.TextBox txt_patientName;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_PatRelativePhone;
        public System.Windows.Forms.TextBox txt_PatRelativeidentity;
        public System.Windows.Forms.TextBox txt_PatRelativestate;
        public System.Windows.Forms.TextBox txt_PatRelativejob;
        public System.Windows.Forms.TextBox txt_PatRelativeaddress;
        public System.Windows.Forms.TextBox txt_PatRelativeName;
        public System.Windows.Forms.ToolStripDropDownButton btn_edit;
        private System.Windows.Forms.Timer timer1;
    }
}