using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_department : Form
    {
        frm_add_employee op = new frm_add_employee();
        public string depCode ;
        public string depName ;
      //  ToolTip tt;
      //  int VisibleTime = 1000;  //in milliseconds
        cls_validate cls_v = new cls_validate();
        public frm_department()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }
        public frm_department(frm_add_employee frm)
        {
            this.op = frm;
            InitializeComponent();
        }
        string dep_code;
        cls_department dep;
        DataView dv;
        DataTable dt = new DataTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add_department frm = new frm_add_department();
            frm.Text = "اضافة قسم جديد";
            frm.Name = "add_dep";
            frm.txt_DeptCode.Text = cls_validate.increasekey(dep_code, 4);
            frm.ShowDialog();
            this.frm_department_Load(sender, e);
        }       
        private void frm_department_Load(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblDate.Text = DateTime.Now.ToShortDateString();
                lb_curent_user.Text = Main_Form.curnt_emp;
                //this.KeyDown += new System.Windows.Forms.KeyEventHandler(KeyEvent);
                dep = new cls_department();
                dt = dep.selct_department();
                if (dt.Rows.Count > 0)
                {
                    dep_code = dt.Rows[dt.Rows.Count - 1][0].ToString();
                }
                else
                {
                    dep_code = "Dep_100";
                }
                dv = new DataView(dt);
                if (dt.Rows.Count > 0)
                {
                    dgv_department.DataSource = dv;
                    dgv_department.Columns[0].HeaderText = "كود القسم";
                    dgv_department.Columns[0].Width = 150;
                    dgv_department.Columns[1].HeaderText = "اسم القسم";
                    dgv_department.Columns[1].Width = 300;
                    dgv_department.Columns[2].HeaderText = "مكان القسم";
                    dgv_department.Columns[2].Width = 300;
                    dgv_department.Columns[3].HeaderText = "ملاحظات";
                    // dgv_department.Columns[0].Visible = false;
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
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "id like '%" + txt_search.Text + "%'";
                        dgv_department.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "Name like '%" + txt_search.Text + "%'";
                        dgv_department.DataSource = dv;
                    }
                    else if (rdb_location.Checked)
                    {
                        dv.RowFilter = "location like '%" + txt_search.Text + "%'";
                        dgv_department.DataSource = dv;
                    }
                }
                else
                {
                    dgv_department.DataSource = dv;
                }
            }
        }
        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
            if(rdb_id.Checked)
            {
                txt_search.Text = "Dep_";
                txt_search.SelectionStart = 4;
            }
            
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
        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_add_department frm = new frm_add_department();
            frm.Text = "تعديل قسم جديد";
            frm.Name = "update_dep";
            frm.txt_DeptCode.Text = dgv_department.CurrentRow.Cells[0].Value.ToString();
            frm.txt_DEPTname.Text = dgv_department.CurrentRow.Cells[1].Value.ToString();
            frm.txtDEPTplace.Text = dgv_department.CurrentRow.Cells[2].Value.ToString();
            frm.txt_DEPT_notes.Text = dgv_department.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
            this.frm_department_Load(sender, e);

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_department.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف القسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (dep.delete_patient("delete", dgv_department.CurrentRow.Cells[0].Value.ToString()))
                        {
                            this.frm_department_Load(sender, e);

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
        private void btn_accept_Click(object sender, EventArgs e)
        {
            depCode = dgv_department.CurrentRow.Cells[0].Value.ToString();
            depName = dgv_department.CurrentRow.Cells[1].Value.ToString();
            op.setDepCode(depCode, depName);
            this.Close();

        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
           // lb_curent_user.Text = Main_Form.curnt_user;
        }
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '_')
                {
                    e.Handled = true;
                }
        }
        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                // cancel the "paste" function
                e.SuppressKeyPress = true;
            }
        }

        private void rdb_location_Click(object sender, EventArgs e)
        {
            txt_search.Focus();
        }
        private void frm_department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F1||e.KeyCode==Keys.Add)
            {
                btn_add_Click(sender,(EventArgs)e);
            }  
           else if (e.KeyCode==Keys.F2)
            {
                btn_edit_Click(sender,(EventArgs)e);
            }
           else if (e.KeyCode == Keys.F3 || e.KeyCode == Keys.Delete)
            {
                btn_delete_Click(sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.F4 || e.KeyCode == Keys.Escape)
            {
                btn_delete_Click(sender, (EventArgs)e);
            }
        }

        private void dgv_department_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_add_department frm = new frm_add_department();
            frm.txt_DeptCode.Text = dgv_department.CurrentRow.Cells[0].Value.ToString();
            frm.txt_DEPTname.Text = dgv_department.CurrentRow.Cells[1].Value.ToString();
            frm.txtDEPTplace.Text = dgv_department.CurrentRow.Cells[2].Value.ToString();
            frm.txt_DEPT_notes.Text = dgv_department.CurrentRow.Cells[3].Value.ToString();
            frm.panel1.Enabled = false;
            frm.ts_btn_save.Visible = false;
            frm.ts_btn_clear.Visible = false;
            frm.ShowDialog();
            this.frm_department_Load(sender, e);

        }

        private void rdb_id_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_id.Checked)
            {
                txt_search.Text = "Dep_";
                txt_search.SelectionStart = 4;
            }

        }
    }
}