namespace HIS
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.gr_login = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.cb_showpassword = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gr_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_login
            // 
            this.gr_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_login.BackColor = System.Drawing.SystemColors.Menu;
            this.gr_login.Controls.Add(this.label4);
            this.gr_login.Controls.Add(this.label7);
            this.gr_login.Controls.Add(this.label3);
            this.gr_login.Controls.Add(this.cmbStyle);
            this.gr_login.Controls.Add(this.btn_exit);
            this.gr_login.Controls.Add(this.btn_login);
            this.gr_login.Controls.Add(this.cb_showpassword);
            this.gr_login.Controls.Add(this.txt_password);
            this.gr_login.Controls.Add(this.txt_username);
            this.gr_login.Controls.Add(this.label2);
            this.gr_login.Controls.Add(this.label1);
            this.gr_login.Location = new System.Drawing.Point(32, 125);
            this.gr_login.Name = "gr_login";
            this.gr_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gr_login.Size = new System.Drawing.Size(445, 210);
            this.gr_login.TabIndex = 0;
            this.gr_login.TabStop = false;
            this.gr_login.Text = "تسجيل الدخول ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(267, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(269, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 33);
            this.label7.TabIndex = 93;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "إستايل البرنامج";
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(25, 166);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(203, 31);
            this.cmbStyle.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbStyle, "اختيار شكل الثيم ");
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Image = global::HIS.Properties.Resources.Close_32x32;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(56, 121);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(172, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "إلغاء";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip2.SetToolTip(this.btn_exit, "الخروج من البرنامج ");
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_login.Image = global::HIS.Properties.Resources.Apply_32x32;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.Location = new System.Drawing.Point(238, 121);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(172, 39);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "تسجيل الدخول ";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btn_login, "تسجيل الدخول ");
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cb_showpassword
            // 
            this.cb_showpassword.AutoSize = true;
            this.cb_showpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_showpassword.Image = global::HIS.Properties.Resources.Show_32x32;
            this.cb_showpassword.Location = new System.Drawing.Point(25, 80);
            this.cb_showpassword.Name = "cb_showpassword";
            this.cb_showpassword.Size = new System.Drawing.Size(47, 32);
            this.cb_showpassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cb_showpassword, "إظهار كلمة المرور");
            this.cb_showpassword.UseVisualStyleBackColor = true;
            this.cb_showpassword.CheckedChanged += new System.EventHandler(this.cb_showpassword_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(78, 80);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(189, 30);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "asd";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_password, "الرجاء ادخال كلمة المرور");
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(78, 30);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(189, 30);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "asd";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_username, "الرجاء ادخال اسم المستخدم");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(321, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
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
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::HIS.Properties.Resources.design1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 119);
            this.panel1.TabIndex = 1;
            // 
            // Log_in
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(511, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gr_login);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_in_FormClosing);
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.gr_login.ResumeLayout(false);
            this.gr_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_showpassword;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}