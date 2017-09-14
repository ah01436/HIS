namespace HIS
{
    partial class frm_visits_Show
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
            this.gb_patient_search = new System.Windows.Forms.GroupBox();
            this.rdb_name = new System.Windows.Forms.RadioButton();
            this.rdb_id = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_visit = new System.Windows.Forms.DataGridView();
            this.gb_patient_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_patient_search
            // 
            this.gb_patient_search.Controls.Add(this.rdb_name);
            this.gb_patient_search.Controls.Add(this.rdb_id);
            this.gb_patient_search.Controls.Add(this.txt_search);
            this.gb_patient_search.Controls.Add(this.label1);
            this.gb_patient_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_patient_search.Location = new System.Drawing.Point(0, 0);
            this.gb_patient_search.Name = "gb_patient_search";
            this.gb_patient_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_patient_search.Size = new System.Drawing.Size(904, 136);
            this.gb_patient_search.TabIndex = 24;
            this.gb_patient_search.TabStop = false;
            this.gb_patient_search.Text = "البحث عن مريض ";
            // 
            // rdb_name
            // 
            this.rdb_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_name.AutoSize = true;
            this.rdb_name.Checked = true;
            this.rdb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_name.Location = new System.Drawing.Point(147, 87);
            this.rdb_name.Name = "rdb_name";
            this.rdb_name.Size = new System.Drawing.Size(58, 28);
            this.rdb_name.TabIndex = 3;
            this.rdb_name.TabStop = true;
            this.rdb_name.Text = "الاسم";
            this.rdb_name.UseVisualStyleBackColor = true;
            this.rdb_name.CheckedChanged += new System.EventHandler(this.rdb_phone_CheckedChanged);
            // 
            // rdb_id
            // 
            this.rdb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_id.AutoSize = true;
            this.rdb_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_id.Location = new System.Drawing.Point(621, 87);
            this.rdb_id.Name = "rdb_id";
            this.rdb_id.Size = new System.Drawing.Size(104, 28);
            this.rdb_id.TabIndex = 2;
            this.rdb_id.Text = "كود المريض";
            this.rdb_id.UseVisualStyleBackColor = true;
            this.rdb_id.CheckedChanged += new System.EventHandler(this.rdb_phone_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_search.Location = new System.Drawing.Point(147, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(580, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "ادخل نص البحث ";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            this.txt_search.MouseEnter += new System.EventHandler(this.txt_search_MouseEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص البحث ";
            // 
            // dgv_visit
            // 
            this.dgv_visit.AllowUserToAddRows = false;
            this.dgv_visit.AllowUserToDeleteRows = false;
            this.dgv_visit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_visit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_visit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_visit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_visit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_visit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_visit.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_visit.Location = new System.Drawing.Point(0, 136);
            this.dgv_visit.MultiSelect = false;
            this.dgv_visit.Name = "dgv_visit";
            this.dgv_visit.ReadOnly = true;
            this.dgv_visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_visit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_visit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visit.Size = new System.Drawing.Size(904, 358);
            this.dgv_visit.TabIndex = 25;
            this.dgv_visit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_visit_CellDoubleClick);
            // 
            // frm_visits_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 494);
            this.Controls.Add(this.dgv_visit);
            this.Controls.Add(this.gb_patient_search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_visits_Show";
            this.Text = "اختيار مريض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_visits_Show_Load);
            this.gb_patient_search.ResumeLayout(false);
            this.gb_patient_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_patient_search;
        private System.Windows.Forms.RadioButton rdb_name;
        private System.Windows.Forms.RadioButton rdb_id;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_visit;
    }
}