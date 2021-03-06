﻿namespace HIS
{
    partial class frmServerSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerSetting));
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoWin = new System.Windows.Forms.RadioButton();
            this.rdoSql = new System.Windows.Forms.RadioButton();
            this.RemeberSettings = new System.Windows.Forms.CheckBox();
            this.cmb_database = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_test_connection = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtServerName.Location = new System.Drawing.Point(31, 47);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(525, 27);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.Text = ".";
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(592, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "إسم السيرفر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(574, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "إسم المستخدم :";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPass.Location = new System.Drawing.Point(31, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.Size = new System.Drawing.Size(526, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Enabled = false;
            this.pnlLogin.Location = new System.Drawing.Point(14, 110);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(684, 147);
            this.pnlLogin.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUser.Location = new System.Drawing.Point(31, 35);
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.Size = new System.Drawing.Size(526, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(582, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "كلمة المرور :";
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Checked = true;
            this.rdoWin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoWin.Location = new System.Drawing.Point(183, 82);
            this.rdoWin.Name = "rdoWin";
            this.rdoWin.Size = new System.Drawing.Size(198, 23);
            this.rdoWin.TabIndex = 1;
            this.rdoWin.TabStop = true;
            this.rdoWin.Text = "Windows Authentication";
            this.rdoWin.UseVisualStyleBackColor = true;
            this.rdoWin.CheckedChanged += new System.EventHandler(this.rdoSql_CheckedChanged);
            // 
            // rdoSql
            // 
            this.rdoSql.AutoSize = true;
            this.rdoSql.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoSql.Location = new System.Drawing.Point(393, 82);
            this.rdoSql.Name = "rdoSql";
            this.rdoSql.Size = new System.Drawing.Size(163, 23);
            this.rdoSql.TabIndex = 2;
            this.rdoSql.Text = "SQL Authentication";
            this.rdoSql.UseVisualStyleBackColor = true;
            this.rdoSql.CheckedChanged += new System.EventHandler(this.rdoSql_CheckedChanged);
            // 
            // RemeberSettings
            // 
            this.RemeberSettings.AutoSize = true;
            this.RemeberSettings.Font = new System.Drawing.Font("Tahoma", 13F);
            this.RemeberSettings.Location = new System.Drawing.Point(30, 79);
            this.RemeberSettings.Name = "RemeberSettings";
            this.RemeberSettings.Size = new System.Drawing.Size(134, 26);
            this.RemeberSettings.TabIndex = 7;
            this.RemeberSettings.Text = "تذكر الإعدادات";
            this.RemeberSettings.UseVisualStyleBackColor = true;
            // 
            // cmb_database
            // 
            this.cmb_database.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmb_database.FormattingEnabled = true;
            this.cmb_database.Location = new System.Drawing.Point(31, 262);
            this.cmb_database.Name = "cmb_database";
            this.cmb_database.Size = new System.Drawing.Size(525, 31);
            this.cmb_database.TabIndex = 12;
            this.cmb_database.SelectedIndexChanged += new System.EventHandler(this.cmb_database_SelectedIndexChanged);
            this.cmb_database.Enter += new System.EventHandler(this.cmb_database_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(562, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم قاعدة البيانات ";
            // 
            // btn_test_connection
            // 
            this.btn_test_connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_test_connection.FlatAppearance.BorderSize = 0;
            this.btn_test_connection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_test_connection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_test_connection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_test_connection.ForeColor = System.Drawing.Color.Black;
            this.btn_test_connection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_test_connection.Location = new System.Drawing.Point(1, 299);
            this.btn_test_connection.Name = "btn_test_connection";
            this.btn_test_connection.Size = new System.Drawing.Size(163, 36);
            this.btn_test_connection.TabIndex = 13;
            this.btn_test_connection.Text = "Test Connection";
            this.btn_test_connection.UseVisualStyleBackColor = false;
            this.btn_test_connection.Click += new System.EventHandler(this.btn_test_connection_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancle.ForeColor = System.Drawing.Color.Black;
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancle.Location = new System.Drawing.Point(219, 323);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(101, 59);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "إلغاء";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::HIS.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(341, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 59);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 385);
            this.Controls.Add(this.btn_test_connection);
            this.Controls.Add(this.cmb_database);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemeberSettings);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.rdoSql);
            this.Controls.Add(this.rdoWin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات السيرفر";
            this.Load += new System.EventHandler(this.frmServerSetting_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoWin;
        private System.Windows.Forms.RadioButton rdoSql;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.CheckBox RemeberSettings;
        private System.Windows.Forms.ComboBox cmb_database;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_test_connection;
    }
}