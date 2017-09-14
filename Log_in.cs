using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace HIS
{
    public partial class Log_in : Form
    {
        DataTable dt = new DataTable();
      //  DialogResult dr = new DialogResult();
        public Log_in()
        {
            InitializeComponent();
           // skinEngine1.SkinFile = "Skins\\" + Properties.Settings.Default.style;
            //------------------------------------------------------------------------
           try
            {
                if (Directory.Exists("Skins"))
                    foreach (string file in Directory.GetFiles("Skins"))
                       cmbStyle.Items.Add(Path.GetFileName(file));
                //cmbStyle.Text = Properties.Settings.Default.style;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //-----------------------------------------------------------------------------------------------
        }
        
        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                cb_showpassword.Image = global::HIS.Properties.Resources.Hide_32x32;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                cb_showpassword.Image = global::HIS.Properties.Resources.Show_32x32;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------ Mohamed Moafa Code For Change styles  ----------------
            try
            {
               // Properties.Settings.Default.style = cmbStyle.Text;
                //Properties.Settings.Default.Save();
               // skinEngine1.SkinFile = "Skins\\" + cmbStyle.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //-----------------------------------------------------------------------------------------------
        
        }
        public string curnet_user ;
        private void btn_login_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[0].Value = txt_username.Text;
               
            dt = con.ReadData("select_user",param);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("اسم المستخدم خطأ رجاء ادخال الاسم الصحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (dt.Rows[0][2].ToString() == txt_password.Text)
                {
                    string emp = "";
                    emp = (con.selectt("select employee.Name from employee where id='" + dt.Rows[0][3].ToString() + "';")).Rows[0][0].ToString();
                    curnet_user = dt.Rows[0][0].ToString();
                    Main_Form frm = new Main_Form(curnet_user, emp);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("كلمةالمرور خطأ رجاء ادخال كلمة المرور الصحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //if (txt_username.Text == "asd")
            //{
            //    if (txt_password.Text == "asd")
            //    {
            //        curnet_user = txt_username.Text;
            //        Main_Form frm = new Main_Form(curnet_user);
            //        frm.Show();
            //        this.Hide();

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("اسم المستخدم خطأ رجاء ادخال الاسم الصحيح","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }
        
        private void Log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
           
        }
    }
}
