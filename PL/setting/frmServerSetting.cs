using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HIS
{
    public partial class frmServerSetting : Form
    {
        public frmServerSetting()
        {
            InitializeComponent();
        }
        string server;
        string database;
        string uid;
        string pwd;
        bool wind=true;

        private void frmServerSetting_Load(object sender, EventArgs e)
        {
            var p = Properties.Settings.Default;
            MessageBox.Show(p.Server + "\t" + p.database + "\t" + p.uid + "\t" + p.password + "\t" + p.IsWinAuth.ToString());
            if (p.Server == "")
            {
                txtServerName.Text = ".";
            }
            else
            {
                txtServerName.Text = p.Server;
            }
            if (!p.IsWinAuth)
            {
                rdoSql.Checked = true;
                txtUser.Text = p.uid;
                txtPass.Text = p.password;               
            }
            server = p.Server;
            database = p.database;
            uid = p.uid;
            pwd = p.password;
            wind = p.IsWinAuth;
        }
        private void rdoSql_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSql.Checked)
            {
                wind = false;
                pnlLogin.Enabled = true;               
                txtUser.Focus();
            }
            else
            {
                wind = true;
                pnlLogin.Enabled = false;
                btnSave.Focus();                
            }     
        }     
        private void btnSave_Click(object sender, EventArgs e)
        {
            CLS_ServerSettings Serverconn = new CLS_ServerSettings();
            if (cmb_database.SelectedIndex>0)
           {
                if (Serverconn.TestConnection(server, database, uid, pwd, wind) == true)
                {
                    if (RemeberSettings.Checked == true)
                    {
                        var p = Properties.Settings.Default;
                        p.Server = txtServerName.Text;
                        p.IsWinAuth = rdoWin.Checked;
                        p.uid = txtUser.Text;
                        p.password = txtPass.Text;
                        p.database = database;
                        MessageBox.Show(database);
                        p.Save();
                        MessageBox.Show("تم الحفظ بنجاح ");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
           }
            else
            {
                MessageBox.Show("برجاء اختيار قاعدة البيانات ");
                cmb_database.Focus();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int index;
        private void cmb_database_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cmb_database.SelectedIndex;
            if (index > 0)
            {
                database = cmb_database.Text.ToString();
                //MessageBox.Show(database);
            }
        }


        private void btn_test_connection_Click(object sender, EventArgs e)
        {
            CLS_ServerSettings s = new CLS_ServerSettings();
            if (cmb_database.SelectedIndex <0) 
            {
                MessageBox.Show("برجاء اختيار قاعدة البيانات ");
                cmb_database.Focus();
            }
            else
            {
                if (s.TestConnection(server, database, uid, pwd, wind))
                    MessageBox.Show("sucess");
            }
        }

        DataTable dt;
        Connection con;
        private void cmb_database_Enter(object sender, EventArgs e)
        {
            dt=new DataTable();
            if (rdoWin.Checked)
            {
                wind = true;
                server = txtServerName.Text;
               con= new Connection(server, uid, pwd, wind);
                if (con.OpenConnection())
                {
                    dt = con.selectt("SELECT name FROM sys.databases ;");
                    cmb_database.DataSource = dt;
                    cmb_database.DisplayMember = "name";
                    cmb_database.ValueMember = "name";
                }
                else { MessageBox.Show("لا استطيع فتح السيرفر"); }
            }
            else
            {
                wind = false;
                server = txtServerName.Text;
                uid = txtUser.Text;
                pwd = txtPass.Text;
                con = new Connection(server, uid, pwd, wind);
                if (con.OpenConnection())
                {
                    dt = con.selectt("SELECT name FROM sys.databases ;");
                    cmb_database.DataSource = dt;
                    cmb_database.DisplayMember = "name";
                    cmb_database.ValueMember = "name";
                }
                else { MessageBox.Show("لا استطيع فتح السيرفر"); }
            }
        }

    }
}
