namespace HIS
{
    partial class frm_Doc_Instruction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_treatment = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.cmb_anatomy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.ts_btn_save = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_clear = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_diagnosis = new System.Windows.Forms.ComboBox();
            this.dgv_doc_inst = new System.Windows.Forms.DataGridView();
            this.toolStrip_controrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_inst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1254, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريضة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1254, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "العلاج";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1254, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "الملاحظات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "التشخيص";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "التحاليل المطلوبة";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(920, 158);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(256, 29);
            this.txt_name.TabIndex = 5;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_treatment
            // 
            this.txt_treatment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_treatment.Location = new System.Drawing.Point(18, 209);
            this.txt_treatment.Multiline = true;
            this.txt_treatment.Name = "txt_treatment";
            this.txt_treatment.Size = new System.Drawing.Size(1220, 93);
            this.txt_treatment.TabIndex = 7;
            // 
            // txt_notes
            // 
            this.txt_notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_notes.Location = new System.Drawing.Point(18, 308);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(1220, 92);
            this.txt_notes.TabIndex = 8;
            // 
            // cmb_anatomy
            // 
            this.cmb_anatomy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_anatomy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_anatomy.FormattingEnabled = true;
            this.cmb_anatomy.Location = new System.Drawing.Point(479, 156);
            this.cmb_anatomy.Name = "cmb_anatomy";
            this.cmb_anatomy.Size = new System.Drawing.Size(293, 32);
            this.cmb_anatomy.TabIndex = 9;
            this.cmb_anatomy.SelectedIndexChanged += new System.EventHandler(this.cmb_anatomy_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::HIS.Properties.Resources.plus1;
            this.button1.Location = new System.Drawing.Point(437, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 38);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "تعليمات الطبيب / العلاج";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.toolStrip_controrl.Size = new System.Drawing.Size(1354, 90);
            this.toolStrip_controrl.TabIndex = 35;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // ts_btn_save
            // 
            this.ts_btn_save.Image = global::HIS.Properties.Resources.save_64;
            this.ts_btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_save.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.ShowDropDownArrow = false;
            this.ts_btn_save.Size = new System.Drawing.Size(68, 87);
            this.ts_btn_save.Text = "حفظ ";
            this.ts_btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
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
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Image = global::HIS.Properties.Resources.search32;
            this.btn_search.Location = new System.Drawing.Point(1192, 155);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 36);
            this.btn_search.TabIndex = 36;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button2
            // 
            this.button2.Image = global::HIS.Properties.Resources.plus1;
            this.button2.Location = new System.Drawing.Point(18, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 38);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_diagnosis
            // 
            this.cmb_diagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_diagnosis.FormattingEnabled = true;
            this.cmb_diagnosis.Location = new System.Drawing.Point(60, 155);
            this.cmb_diagnosis.Name = "cmb_diagnosis";
            this.cmb_diagnosis.Size = new System.Drawing.Size(286, 32);
            this.cmb_diagnosis.TabIndex = 37;
            this.cmb_diagnosis.SelectedIndexChanged += new System.EventHandler(this.cmb_diagnosis_SelectedIndexChanged);
            // 
            // dgv_doc_inst
            // 
            this.dgv_doc_inst.AllowUserToAddRows = false;
            this.dgv_doc_inst.AllowUserToDeleteRows = false;
            this.dgv_doc_inst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doc_inst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_doc_inst.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_doc_inst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_doc_inst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_doc_inst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc_inst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_doc_inst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_doc_inst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_doc_inst.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_doc_inst.Location = new System.Drawing.Point(0, 406);
            this.dgv_doc_inst.MultiSelect = false;
            this.dgv_doc_inst.Name = "dgv_doc_inst";
            this.dgv_doc_inst.ReadOnly = true;
            this.dgv_doc_inst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_doc_inst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_doc_inst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doc_inst.Size = new System.Drawing.Size(1354, 289);
            this.dgv_doc_inst.TabIndex = 39;
            // 
            // frm_Doc_Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1354, 695);
            this.Controls.Add(this.dgv_doc_inst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb_diagnosis);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_anatomy);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.txt_treatment);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Doc_Instruction";
            this.Text = "تعليمات الطبيب / العلاج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Doc_Instruction_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_inst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_treatment;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.ComboBox cmb_anatomy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_exit;
        private System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_diagnosis;
        private System.Windows.Forms.DataGridView dgv_doc_inst;
    }
}