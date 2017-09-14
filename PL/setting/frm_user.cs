using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_user : Form
    {
        public frm_user()
        {
            InitializeComponent();
        }

        string user_id;
        cls_user user;
        DataView dv;
        DataTable dt;

        private void frm_user_Load(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp; 
            try
            {
                user = new cls_user();
                dt = user.select();
                if (dt.Rows.Count > 0)
                {
                    user_id = dt.Rows[dt.Rows.Count - 1][0].ToString();
                }
                else
                {
                    user_id = "user_100";
                }
                dv = new DataView(dt);
                dgv_user.DataSource = dv;
                dgv_user.Columns[0].HeaderText = "كود المستخدم";
                dgv_user.Columns[1].HeaderText = "اسم المستخدم";
                dgv_user.Columns[2].Visible= false;
                dgv_user.Columns[3].HeaderText = "كود الموظف";
                dgv_user.Columns[4].HeaderText = "اسم الموظف";
                // dgv_user.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_emp_id.Checked)
                    {
                        dv.RowFilter = "emp_id like '%" + txt_search.Text + "%'";
                        dgv_user.DataSource = dv;
                    }
                    else if (rdb_emp_name.Checked)
                    {
                        dv.RowFilter = "Name like '%" + txt_search.Text + "%'";
                        dgv_user.DataSource = dv;
                    }
                    else if (rdb_user_name.Checked)
                    {
                        dv.RowFilter = "user_name like '%" + txt_search.Text + "%'";
                        dgv_user.DataSource = dv;
                    }
                }
                else
                {
                    dgv_user.DataSource = dv;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }
        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "ادخل نص البحث";
                txt_search.ForeColor = Color.LightGray;
            }
        }
        private void rdb_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "ادخل نص البحث";
            dv.RowFilter = string.Empty;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add_user frm = new frm_add_user();
            frm.Text = "اضافة مستخدم جديد";
            frm.Name = "add_user";
            frm.txt_user_id.Text = cls_validate.increasekey(user_id, 5);
            frm.ShowDialog();
            this.frm_user_Load(sender, e);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_update_user frm = new frm_update_user();
            frm.Text = "تعديل قسم جديد";
            frm.Name = "update_user";
            frm.password = dgv_user.CurrentRow.Cells[2].Value.ToString();
            frm.txt_user_id.Text = dgv_user.CurrentRow.Cells[0].Value.ToString();
            frm.txt_user_name.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
            frm.txt_emp_id.Text = dgv_user.CurrentRow.Cells[3].Value.ToString();
            frm.txt_emp_name.Text = dgv_user.CurrentRow.Cells[4].Value.ToString();
            
            frm.ShowDialog();
            this.frm_user_Load(sender, e);

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_user.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف القسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (user.delete("delete", dgv_user.CurrentRow.Cells[0].Value.ToString()))
                        {
                            this.frm_user_Load(sender, e);

                            MessageBox.Show("تم الحذف بنجاح ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تم حذف جميع الاقسام ", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_user; 
        }
    }
}
