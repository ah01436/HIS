using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace HIS
{
    public partial class frm_priv_user : Form
    {
        Connection con = new Connection();
        public frm_priv_user()
        {
            InitializeComponent();
            loadData();
            loadPriv(); 
           // this.list_user.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
            this.list_lists.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
        }
        private void frm_priv_user_Load(object sender, EventArgs e)
        {
           
           list_user_SelectedIndexChanged(sender, e);
        }
        void loadData()
        {
            DataTable dt2 = new DataTable();
            dt2 = con.selectt("select * from tb_lists;");
     
            list_lists.DataSource = dt2;
            list_lists.DisplayMember = "list_name";
            list_lists.ValueMember = "list_id";          
        }
        DataTable dts;
        private void list_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dts = new DataTable();
                dts = con.selectt(@"select priv_screen_id,screen_name,priv_display,priv_add,priv_delete,priv_edit 
                                   from tb_priv,tb_screen where tb_priv.priv_screen_id=tb_screen.screen_id and 
                                   tb_screen.list_id=(select list_id from tb_lists where list_id=" + list_lists.SelectedValue + " ) and priv_user_id='" + frm_user.user_code + "';");
                dgv_priv.DataSource = dts;
                dgv_priv.Columns[0].HeaderText = "رقم الشاشة";
                dgv_priv.Columns[1].ReadOnly=true;
                dgv_priv.Columns[0].Visible = false;
                dgv_priv.Columns[1].HeaderText = "اسم الشاشة";
                dgv_priv.Columns[2].HeaderText = "عرض";
                dgv_priv.Columns[3].HeaderText = "اضافة";
                dgv_priv.Columns[4].HeaderText = "حذف";
                dgv_priv.Columns[5].HeaderText = "تعديل";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool ch = false;
            string user_code = frm_user.user_code;
            for (int i = 0; i < dgv_priv.Rows.Count; i++)
            {
                int dis1, add1, edit1, delete1;
                int screen_num =Convert.ToInt32(dgv_priv.Rows[i].Cells[0].Value);
                Boolean dis = dgv_priv.Rows[i].Cells[2].Value.Equals(true || false); if (dis == true) dis1 = 1; else dis1 = 0;
                Boolean add = dgv_priv.Rows[i].Cells[3].Value.Equals(true || false); if (add == true) add1 = 1; else add1 = 0;
                Boolean edit = dgv_priv.Rows[i].Cells[4].Value.Equals(true || false); if (edit == true) edit1 = 1; else edit1 = 0;
                Boolean delete = dgv_priv.Rows[i].Cells[5].Value.Equals(true || false); if (delete == true) delete1 = 1; else delete1 = 0;
                if (con.ExecuteQueries("update tb_priv set priv_display=" + dis1 + ",priv_add=" + add1 + ",priv_delete=" + delete1 + ",priv_edit=" + edit1
                    + " where priv_user_id='"+user_code+"' and priv_screen_id="+screen_num+" ;"))
                {
                    ch = true;
                }
                else
                {
                    ch = false;
                    break;
                }
            }
            if (ch==true)
            {
                 MessageBox.Show("تم الحفظ بنجاح");
            }
            
        }
        void loadPriv()
        {
            Connection con = new Connection();
            DataTable dt;
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=11 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                    btn_save.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                   // btn_delete.Enabled = false;
                }
                if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                {
                    dgv_priv.Enabled = true ;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
