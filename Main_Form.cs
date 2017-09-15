using System;
using System.Data;
using System.Windows.Forms;

namespace HIS
{
    public partial class Main_Form : Form
    {
        public static string curnt_user;
        public static string curnt_emp;
        public Main_Form(string user,string emp)
        {
            InitializeComponent();
            curnt_user = user;
            curnt_emp = emp;
        }
        public Main_Form()
        {
            InitializeComponent(); 
        }
        // فتح شاشة تسجيل الدخول
        private void msLogin_Click(object sender, EventArgs e)
        {
            logout = true;
            Application.Restart();

        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lb_curent_user.Text = curnt_emp;
           /* skinEngine1.SkinFile = "Skins\\" + Properties.Settings.Default.style;
            try
            {
                if (Directory.Exists("Skins"))
                    foreach (string file in Directory.GetFiles("Skins"))
                    {
                        var item = msStyles.DropDownItems.Add(Path.GetFileName(file));
                        item.Click += item_Click;
                        if (Properties.Settings.Default.style == item.Text)
                        {
                            (item as ToolStripMenuItem).Checked = true;
                            temp = item as ToolStripMenuItem;
                        }


                    }

            }
            catch { }*/
        }
        // حدث الاستايلات       
        bool logout = false;
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                DialogResult dr = MessageBox.Show("هل تريد الخروج من البرنامج ؟", "تنبيه ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.ExitThread();
                }
            }
            else
            {
                logout = false;
            }
        }
        // عرض شاشة اعدادات السيرفر
        private void msServerSetting_Click(object sender, EventArgs e)
        {
            frmServerSetting frm = new frmServerSetting();
            frm.ShowDialog();
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=9 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_department frm = new frm_department();
                frm.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=8 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_employee frm = new frm_employee();
                frm.ShowDialog();
            }
        }
        private void btn_pat_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=1 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else { 
            frm_patient frm = new frm_patient();
            frm.ShowDialog();
            }
            }
        private void btn_doc_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=10 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_user frm = new frm_user();
                frm.ShowDialog();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=2 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            { 
            frm_visit frm = new frm_visit();
            frm.Name = "add_visit";
            frm.ShowDialog();
            }
        }
        private void btn_accept_visit_Click(object sender, EventArgs e)
        {
            frm_OBSTATRIC_HISTORY frm = new frm_OBSTATRIC_HISTORY();
            frm.ShowDialog();
        }
        private void btn_report_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=3 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                rp_frm_patient_info frm = new rp_frm_patient_info();
                frm.Show();
            }
            }
        private void button2_Click_2(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=5 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_OBSTATRIC_HISTORY frm = new frm_OBSTATRIC_HISTORY();
                frm.Show();
            }
        }
        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            Log_in frm = new Log_in();
            frm.ShowDialog();
           
        }
        private void btn_patient_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=4 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }

            else
            {
            
                rp_frm_patient frm = new rp_frm_patient();
                frm.Show();
            }
        }
        private void add_ultra_report_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=7 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_Admission_ultrasound_report frm = new frm_Admission_ultrasound_report();
                frm.Show();
            }
        }
        private void btn_instructions_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_display from tb_priv where priv_screen_id=6 and priv_user_id='" + Main_Form.curnt_user + "';");

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
            }
            else
            {
                frm_Doc_Instruction frm = new frm_Doc_Instruction();
                frm.Show();
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد الخروج من البرنامج ؟", "تنبيه ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                logout = true;
                Application.Exit();
            }

        }
        private void Server_Setting_Click(object sender, EventArgs e)
        {
            frmServerSetting frm = new frmServerSetting();
            frm.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                btn_pat.Visible = true;
                btn_patient.Visible = true;
                btn_visit.Visible = true;
                btn_report.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btn_pregnant.Visible = true;
            add_ultra_report.Visible = true;
            btn_instructions.Visible = true;
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btn_user.Visible = true;
            btn_employee.Visible = true;
            btn_user.Visible = true;
            btn_department.Visible = true;
            
        }

  
    }
}
