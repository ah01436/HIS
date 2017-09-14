namespace HIS
{
    partial class docSearch
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
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.btn_accept = new System.Windows.Forms.ToolStripDropDownButton();
            this.dgv_doc = new System.Windows.Forms.DataGridView();
            this.gb_employee_search = new System.Windows.Forms.GroupBox();
            this.rdb_card = new System.Windows.Forms.RadioButton();
            this.rdb_name = new System.Windows.Forms.RadioButton();
            this.rdb_id = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip_controrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).BeginInit();
            this.gb_employee_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_accept});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1005, 58);
            this.toolStrip_controrl.TabIndex = 124;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // btn_accept
            // 
            this.btn_accept.Image = global::HIS.Properties.Resources.Apply_32x32;
            this.btn_accept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_accept.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.ShowDropDownArrow = false;
            this.btn_accept.Size = new System.Drawing.Size(46, 55);
            this.btn_accept.Text = "موافق";
            this.btn_accept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_accept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // dgv_doc
            // 
            this.dgv_doc.AllowUserToAddRows = false;
            this.dgv_doc.AllowUserToDeleteRows = false;
            this.dgv_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_doc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_doc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_doc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_doc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_doc.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_doc.Location = new System.Drawing.Point(0, 195);
            this.dgv_doc.MultiSelect = false;
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.ReadOnly = true;
            this.dgv_doc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_doc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doc.Size = new System.Drawing.Size(1000, 517);
            this.dgv_doc.TabIndex = 126;
            // 
            // gb_employee_search
            // 
            this.gb_employee_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_employee_search.Controls.Add(this.rdb_card);
            this.gb_employee_search.Controls.Add(this.rdb_name);
            this.gb_employee_search.Controls.Add(this.rdb_id);
            this.gb_employee_search.Controls.Add(this.txt_search);
            this.gb_employee_search.Controls.Add(this.label1);
            this.gb_employee_search.Location = new System.Drawing.Point(12, 61);
            this.gb_employee_search.Name = "gb_employee_search";
            this.gb_employee_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_employee_search.Size = new System.Drawing.Size(981, 117);
            this.gb_employee_search.TabIndex = 125;
            this.gb_employee_search.TabStop = false;
            this.gb_employee_search.Text = "البحث عن دكتور";
            // 
            // rdb_card
            // 
            this.rdb_card.AutoSize = true;
            this.rdb_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_card.Location = new System.Drawing.Point(147, 87);
            this.rdb_card.Name = "rdb_card";
            this.rdb_card.Size = new System.Drawing.Size(130, 27);
            this.rdb_card.TabIndex = 4;
            this.rdb_card.Text = "الرقم القومى";
            this.rdb_card.UseVisualStyleBackColor = true;
            this.rdb_card.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // rdb_name
            // 
            this.rdb_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_name.AutoSize = true;
            this.rdb_name.Checked = true;
            this.rdb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_name.Location = new System.Drawing.Point(432, 87);
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
            this.rdb_id.Location = new System.Drawing.Point(682, 87);
            this.rdb_id.Name = "rdb_id";
            this.rdb_id.Size = new System.Drawing.Size(120, 27);
            this.rdb_id.TabIndex = 2;
            this.rdb_id.Text = "كود الموظف";
            this.rdb_id.UseVisualStyleBackColor = true;
            this.rdb_id.CheckedChanged += new System.EventHandler(this.rdb_name_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.ForeColor = System.Drawing.Color.LightGray;
            this.txt_search.Location = new System.Drawing.Point(147, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(657, 30);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "ادخل نص البحث ";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص البحث ";
            // 
            // docSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 741);
            this.Controls.Add(this.dgv_doc);
            this.Controls.Add(this.gb_employee_search);
            this.Controls.Add(this.toolStrip_controrl);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "docSearch";
            this.Text = "docSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.docSearch_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).EndInit();
            this.gb_employee_search.ResumeLayout(false);
            this.gb_employee_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_accept;
        private System.Windows.Forms.DataGridView dgv_doc;
        private System.Windows.Forms.GroupBox gb_employee_search;
        private System.Windows.Forms.RadioButton rdb_card;
        private System.Windows.Forms.RadioButton rdb_name;
        private System.Windows.Forms.RadioButton rdb_id;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
    }
}