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
    
    public partial class frm_add_department : Form
    {        
        public frm_add_department()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            if (e.KeyCode == Keys.F1)
            {
                ts_btn_save_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                ts_btn_clear_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ts_btn_exit_Click(sender, e);
            }
            

        }
        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool vaildate_text()
        {
            try
            {
                if (txt_DEPTname.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم القسم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_DEPTname.Focus();
                    return false;
                }
                else if(txtDEPTplace.Text=="")
                {
                    MessageBox.Show("يجب ادخال مكان القسم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDEPTplace.Focus();
                    return false;
                }
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        cls_department dep;
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            dep=new cls_department();
            try
            {
                if (vaildate_text())
                {
                    if (this.Name == "add_dep")
                    {
                        if (dep.insertdata("insert", txt_DeptCode.Text, txt_DEPTname.Text, txtDEPTplace.Text, txt_DEPT_notes.Text))
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (this.Name == "update_dep")
                    {
                        if (dep.updatedata("update", txt_DeptCode.Text, txt_DEPTname.Text, txtDEPTplace.Text, txt_DEPT_notes.Text))
                        {
                            MessageBox.Show("تمت التعديل بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_DeptCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_add_department_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp; 
        }

        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            txt_DEPT_notes.Clear();
            txt_DEPTname.Clear();
            txtDEPTplace.Clear();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_user; 
        }

        private void frm_add_department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ts_btn_save_Click(sender, e);
            }
           else if (e.KeyCode == Keys.F2)
            {
                ts_btn_clear_Click(sender, e);
            }
           else if (e.KeyCode == Keys.Escape)
            {
                ts_btn_exit_Click(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_DEPTname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
