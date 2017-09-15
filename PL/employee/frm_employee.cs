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
    public partial class frm_employee : Form
    {
        public frm_employee()
        {
            InitializeComponent();
            loadPriv();
        }
        string emp_code;
        cls_employee emp;
        DataView dv;
        DataTable dt;
        int VisibleTime = 1000;  //in milliseconds
        ToolTip tt;
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add_employee frm = new frm_add_employee();
            frm.Text = "اضافة موظف جديد";
            frm.Name = "add_emp";
            frm.txt_id.Text = cls_validate.increasekey(emp_code,4);
            frm.ShowDialog();
            this.frm_employee_Load(sender, e);
            
        }

        private void frm_employee_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp; 
            try
            {
                Connection con=new Connection();
                if (this.Name == "search") 
                {
                    this.btn_add.Visible = false;
                    this.btn_edit.Visible = false;
                    this.btn_delete.Visible = false;
                    this.btn_ok.Visible = true;
                    emp = new cls_employee();
                    //dt = emp.select_employee();
                    dt = con.selectt("select * from employee where [dbo].[employee].[id] not in(select [emp_id]from [dbo].[users]);");
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("تم تسجيل جميع الموظفين واختيار اسم مسخدم وكلمة مرور لهم ","تنبيه ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    emp = new cls_employee();
                    dt = emp.select_employee();
                    if (dt.Rows.Count > 0)
                    {
                        emp_code = dt.Rows[dt.Rows.Count - 1][0].ToString();
                    }
                    else
                    {
                        emp_code = "Emp_100";
                    }
                }
                    dv = new DataView(dt);
                    dgv_employee.DataSource = dv;
                    dgv_employee.Columns[0].HeaderText = "كود الموظف";
                    dgv_employee.Columns[1].HeaderText = "اسم الموظف";
                    dgv_employee.Columns[2].Visible = false;
                    dgv_employee.Columns[3].HeaderText = "رقم الهاتف";
                    dgv_employee.Columns[4].HeaderText = "الحالة الاجتماعية";
                    dgv_employee.Columns[14].HeaderText = "المؤهل";
                    dgv_employee.Columns[5].Visible = false;
                    dgv_employee.Columns[6].Visible = false;
                    dgv_employee.Columns[7].Visible = false;
                    dgv_employee.Columns[8].Visible = false;
                    dgv_employee.Columns[9].Visible = false;
                    dgv_employee.Columns[10].Visible = false;
                    dgv_employee.Columns[11].Visible = false;
                    dgv_employee.Columns[12].Visible = false;
                    dgv_employee.Columns[13].Visible = false;
                    dgv_employee.Columns[15].Visible = false;
                    dgv_employee.Columns[21].Visible = false;
                    dgv_employee.Columns[22].Visible = false;
                    dgv_employee.Columns[23].Visible = false;
                    dgv_employee.Columns[24].Visible = false;
                    dgv_employee.Columns[25].Visible = false;
                    dgv_employee.Columns[16].Visible = false;
                    dgv_employee.Columns[17].Visible = false;
                    dgv_employee.Columns[18].Visible = false;
                    dgv_employee.Columns[19].Visible = false;
                    dgv_employee.Columns[20].Visible = false;
                
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
            try
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "id like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "Name like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                    else if (rdb_phone.Checked)
                    {
                        dv.RowFilter = "phone like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                }
                else
                {
                    dgv_employee.DataSource = dv;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_add_employee frm = new frm_add_employee();
            frm.Text = "تعديل بيانات موظف";
            frm.Name = "update_emp";
            frm.txt_id.Text =dgv_employee.CurrentRow.Cells[0].Value.ToString();
            frm.txt_name.Text =dgv_employee.CurrentRow.Cells[1].Value.ToString();
            frm.txt_address.Text =dgv_employee.CurrentRow.Cells[2].Value.ToString();
            frm.txt_phone.Text =dgv_employee.CurrentRow.Cells[3].Value.ToString();

            frm.cb_status.SelectedItem = dgv_employee.CurrentRow.Cells[4].Value.ToString();
            frm.txt_email.Text = dgv_employee.CurrentRow.Cells[5].Value.ToString();
            frm.cb_sex.SelectedItem= dgv_employee.CurrentRow.Cells[6].Value.ToString();
            frm.dtp_birthDate.Text = dgv_employee.CurrentRow.Cells[7].Value.ToString();

            frm.cb_religion.SelectedItem= dgv_employee.CurrentRow.Cells[8].Value.ToString();
            frm.txt_birthPlace.Text = dgv_employee.CurrentRow.Cells[9].Value.ToString();
            frm.cb_nationality.SelectedItem= dgv_employee.CurrentRow.Cells[10].Value.ToString();
            frm.txt_card_id.Text = dgv_employee.CurrentRow.Cells[11].Value.ToString();

            frm.txt_cardReleasePlace.Text = dgv_employee.CurrentRow.Cells[12].Value.ToString();
            frm.dtp_card_realease_date.Text = dgv_employee.CurrentRow.Cells[13].Value.ToString();
            frm.cb_qualification.SelectedItem = dgv_employee.CurrentRow.Cells[14].Value.ToString();
            frm.dtp_qualification_date.Text = dgv_employee.CurrentRow.Cells[15].Value.ToString();

            frm.nupd__years_of_experience.Value = int.Parse(dgv_employee.CurrentRow.Cells[16].Value.ToString());
            frm.txt_experience.Text = dgv_employee.CurrentRow.Cells[17].Value.ToString();
            frm.cb_prevoius_jobs.SelectedItem = dgv_employee.CurrentRow.Cells[18].Value.ToString();
            frm.dtp_hiring_date.Text = dgv_employee.CurrentRow.Cells[19].Value.ToString();

            frm.txt_totalSalary.Value = int.Parse(dgv_employee.CurrentRow.Cells[20].Value.ToString());
            frm.cb_career_level.SelectedItem = dgv_employee.CurrentRow.Cells[21].Value.ToString();
      //frm.c.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            frm.txt_depCode.Text = dgv_employee.CurrentRow.Cells[23].Value.ToString();
            if (dgv_employee.CurrentRow.Cells[24].Value.ToString() == "Emp")
            {
                frm.rdb_Emp.Checked = true;
                frm.cb_career_name1.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            }
            else if (dgv_employee.CurrentRow.Cells[24].Value.ToString() == "Doc")
            {
                frm.rdb_doc.Checked = true;
                frm.cb_career_name2.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            }
            frm.cb_bloodType.SelectedItem = dgv_employee.CurrentRow.Cells[25].Value.ToString();
            frm.ShowDialog();
            this.frm_employee_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_employee.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف الموظف المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (emp.deletedata("delete", dgv_employee.CurrentRow.Cells[0].Value.ToString()))
                        {
                            this.frm_employee_Load(sender, e);
                            MessageBox.Show("تم الحذف بنجاح ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تم حذف جميع الموظفين ", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string id;
        public static string name;
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            id= dgv_employee.CurrentRow.Cells[0].Value.ToString();
            name = dgv_employee.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdb_name.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
                {
                    // btnSearch.Enabled = false;
                  
                     tt = new ToolTip();
                    tt.Show("اسم الموظف " + " يجب ان يكون حروف فقط ", txt_search, 0, 0, VisibleTime);
                    //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                    e.Handled = true;
                }
            }
                else if (rdb_phone.Checked)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                    {
                        //   ts_btn_save.Enabled = false;
                        //in milliseconds
                         tt = new ToolTip();
                        tt.Show("رقم الهاتف " + " يجب ان يكون ارقام ", txt_search, 0, 0, VisibleTime);
                        //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                        e.Handled = true;
                    
                
                
                }
            
            
            
            
            
            
            }
        }

        private void dgv_employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_add_employee frm = new frm_add_employee();
            frm.txt_id.Text = dgv_employee.CurrentRow.Cells[0].Value.ToString();
            frm.txt_name.Text = dgv_employee.CurrentRow.Cells[1].Value.ToString();
            frm.txt_address.Text = dgv_employee.CurrentRow.Cells[2].Value.ToString();
            frm.txt_phone.Text = dgv_employee.CurrentRow.Cells[3].Value.ToString();

            frm.cb_status.SelectedItem = dgv_employee.CurrentRow.Cells[4].Value.ToString();
            frm.txt_email.Text = dgv_employee.CurrentRow.Cells[5].Value.ToString();
            frm.cb_sex.SelectedItem = dgv_employee.CurrentRow.Cells[6].Value.ToString();
            frm.dtp_birthDate.Text = dgv_employee.CurrentRow.Cells[7].Value.ToString();

            frm.cb_religion.SelectedItem = dgv_employee.CurrentRow.Cells[8].Value.ToString();
            frm.txt_birthPlace.Text = dgv_employee.CurrentRow.Cells[9].Value.ToString();
            frm.cb_nationality.SelectedItem = dgv_employee.CurrentRow.Cells[10].Value.ToString();
            frm.txt_card_id.Text = dgv_employee.CurrentRow.Cells[11].Value.ToString();

            frm.txt_cardReleasePlace.Text = dgv_employee.CurrentRow.Cells[12].Value.ToString();
            frm.dtp_card_realease_date.Text = dgv_employee.CurrentRow.Cells[13].Value.ToString();
            frm.cb_qualification.SelectedItem = dgv_employee.CurrentRow.Cells[14].Value.ToString();
            frm.dtp_qualification_date.Text = dgv_employee.CurrentRow.Cells[15].Value.ToString();

            frm.nupd__years_of_experience.Value = int.Parse(dgv_employee.CurrentRow.Cells[16].Value.ToString());
            frm.txt_experience.Text = dgv_employee.CurrentRow.Cells[17].Value.ToString();
            frm.cb_prevoius_jobs.SelectedItem = dgv_employee.CurrentRow.Cells[18].Value.ToString();
            frm.dtp_hiring_date.Text = dgv_employee.CurrentRow.Cells[19].Value.ToString();

            frm.txt_totalSalary.Value = int.Parse(dgv_employee.CurrentRow.Cells[20].Value.ToString());
            frm.cb_career_level.SelectedItem = dgv_employee.CurrentRow.Cells[21].Value.ToString();
            //frm.c.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            frm.txt_depCode.Text = dgv_employee.CurrentRow.Cells[23].Value.ToString();
            if (dgv_employee.CurrentRow.Cells[24].Value.ToString() == "Emp")
            {
                frm.rdb_Emp.Checked = true;
                frm.cb_career_name1.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            }
            else if (dgv_employee.CurrentRow.Cells[24].Value.ToString() == "Doc")
            {
                frm.rdb_doc.Checked = true;
                frm.cb_career_name2.SelectedItem = dgv_employee.CurrentRow.Cells[22].Value.ToString();
            }
            frm.cb_bloodType.SelectedItem = dgv_employee.CurrentRow.Cells[25].Value.ToString();

            frm.ts_btn_clear.Visible = false;
            frm.ts_btn_save.Visible = false;
            frm.groupBox1.Enabled = false;
            frm.groupBox2.Enabled = false;
            frm.groupBox3.Enabled = false;
            frm.groupBox4.Enabled = false;
            frm.groupBox5.Enabled = false;


            frm.ShowDialog();
            this.frm_employee_Load(sender, e);
       
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_user; 
        }
        void loadPriv()
        {
            Connection con = new Connection();
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=8 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                    btn_add.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                    btn_delete.Enabled = false;
                }
                if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                {
                    btn_edit.Enabled = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
       
    }
}
