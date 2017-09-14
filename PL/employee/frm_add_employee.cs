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
    public partial class frm_add_employee : Form
    {
        cls_validate cls_v = new cls_validate();
         int VisibleTime = 1000;
         ToolTip tt;
        public frm_add_employee()
        {
            InitializeComponent();
        }

        cls_employee emp;
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            emp = new cls_employee();
            string EmpType = "";
            string career_name = "";
            if (rdb_Emp.Checked)
            {
                EmpType += "Emp";
                career_name += cb_career_name1.SelectedItem.ToString();
            }
            else if ((rdb_doc.Checked))
            {
                EmpType += "Doc";
                career_name += cb_career_name2.SelectedItem.ToString();
            }

            try
            {
                if (vaildate_text())
                {
                    if (this.Name == "add_emp")
                    {
                        if (emp.insertdata("insert", txt_id.Text, txt_name.Text, txt_address.Text, txt_phone.Text, cb_status.SelectedItem.ToString(),
                            txt_email.Text, cb_sex.SelectedItem.ToString(), dtp_birthDate.Value.ToShortDateString(),
                            cb_religion.SelectedItem.ToString(), txt_birthPlace.Text, cb_nationality.Text, txt_card_id.Text,
                            txt_cardReleasePlace.Text, dtp_card_realease_date.Value.ToShortDateString(), cb_qualification.SelectedItem.ToString(),
                            dtp_qualification_date.Value.ToShortDateString(), nupd__years_of_experience.Value.ToString(), txt_experience.Text,
                            cb_prevoius_jobs.SelectedItem.ToString(), dtp_hiring_date.Value.ToShortDateString(),
                            txt_totalSalary.Text, cb_career_level.SelectedItem.ToString(), career_name,
                            txt_depCode.Text, EmpType, cb_bloodType.SelectedItem.ToString()))
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (this.Name == "update_emp")
                    {
                        if (emp.updatedata("update", txt_id.Text, txt_name.Text, txt_address.Text, txt_phone.Text, cb_status.SelectedItem.ToString(),
                            txt_email.Text, cb_sex.SelectedItem.ToString(), dtp_birthDate.Value.ToShortDateString(),
                            cb_religion.SelectedItem.ToString(), txt_birthPlace.Text, cb_nationality.Text, txt_card_id.Text,
                            txt_cardReleasePlace.Text, dtp_card_realease_date.Value.ToShortDateString(), cb_qualification.SelectedItem.ToString(),
                            dtp_qualification_date.Value.ToShortDateString(), nupd__years_of_experience.Value.ToString(), txt_experience.Text,
                            cb_prevoius_jobs.SelectedItem.ToString(), dtp_hiring_date.Value.ToShortDateString(),
                            txt_totalSalary.Text, cb_career_level.SelectedItem.ToString(), career_name,
                            txt_depCode.Text, EmpType, cb_bloodType.SelectedItem.ToString()))
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


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cb_religion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            frm_department frm = new frm_department();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_department frm = new frm_department();
            frm.ShowDialog();
        }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool vaildate_text()
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم الموظف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_name.Focus();
                    return false;
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("يجب ادخال عنوان الموظف  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_address.Focus();
                    return false;
                }

                else if (txt_card_id.Text == "" || !cls_v.IsValidNationalID(txt_card_id.Text))
                {
                    MessageBox.Show("يجب ادخال الرقم القومي للموظف بشكل صحيح  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_card_id.Focus();
                    return false;
                }

                else if (txt_depCode.Text == "")
                {
                    MessageBox.Show("يجب ادخال القسم الذي سيعمل به الموظف  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_depCode.Focus();
                    return false;
                }
                else if (txt_phone.Text !="")
                {
                    if (!cls_v.IsvalidPhone(txt_phone.Text))
                    {
                        MessageBox.Show("يجب ادخال رقم الهاتف للموظف بشكل صحيح  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_phone.Focus();
                        return false;
                    }
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        private void cb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_dep_search_Click(object sender, EventArgs e)
        {
            frm_department frm = new frm_department(this);
            frm.btn_add.Visible = false;
            frm.btn_delete.Visible = false;
            frm.btn_edit.Visible = false;
            frm.btn_exit.Visible = false;
            frm.btn_accept.Visible = true;
            frm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_doc_CheckedChanged(object sender, EventArgs e)
        {
            //  var point = new Point(316,44);

            cb_career_name2.Visible = true;
            cb_career_name1.Visible = false;
            //  this.cb_career_name2.Location = point;


        }

        private void rdb_Emp_CheckedChanged(object sender, EventArgs e)
        {
            cb_career_name2.Visible = false;
            cb_career_name1.Visible = true;
        }

        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            frm_add_employee f = new frm_add_employee();
            f.txt_id.Text = this.txt_id.Text;
            f.ShowDialog();
            this.Close();

        }

        private void frm_add_employee_Load(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp;
        }
        public void setDepCode(String dep_code, string dep_name)
        {
            txt_depCode.Text = dep_code;
            Dep_Name.Text = dep_name;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_user;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (!cls_v.IsValidNationalID(txt_phone.Text))
            {
                MessageBox.Show("عفوا رقم الهاتف الذى ادخلته غير صحيح");
            }

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (!cls_v.IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("عفوا البريد الالكترونى الذى ادخلته غير صحيح");
            }
        }

        private void txt_card_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_card_id_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_card_id_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
             //   ts_btn_save.Enabled = false;
                 //in milliseconds
                 tt = new ToolTip();
                tt.Show("الرقم القومى " + " يجب ان يكون ارقام ", txt_card_id, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
              //  ts_btn_save.Enabled = true;
            }

        }

        private void txt_card_id_Leave(object sender, EventArgs e)
        {
            if (txt_card_id.Text != "")
            {
                if (!cls_v.IsValidNationalID(txt_card_id.Text))
                {
                     tt = new ToolTip();
                    tt.Show("عفوا الرقم القومى الذى ادخلته غير صحيح", txt_card_id, 0, 0, VisibleTime);
      
                    txt_card_id.Focus();
                }
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                ToolTip tt = new ToolTip();
                tt.Show("رقم الهاتف " + " يجب ان يكون ارقام ", txt_phone, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
                //  ts_btn_save.Enabled = true;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text != "")
            {
                if (!cls_v.IsvalidPhone(txt_phone.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا رقم الهاتف الذى ادخلته غير صحيح", txt_phone, 0, 0, VisibleTime);

                    txt_phone.Focus();
                }
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text != "")
            {
                if (!cls_v.IsValidEmail(txt_email.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا البريد الالكترونى الذى ادخلته غير صحيح", txt_email, 0, 0, VisibleTime);

                    txt_email.Focus();

                }
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
            {
               // btnSearch.Enabled = false;
                int VisibleTime = 1000;  //in milliseconds
                ToolTip tt = new ToolTip();
                tt.Show("اسم الموظف " + " يجب ان يكون حروف فقط ", txt_name, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
              //  btnSearch.Enabled = true;

            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (!cls_v.letterValidation(txt_name.Text))
            {
                MessageBox.Show("اسم الموظف يجب ان يكون حروف فقط");
                txt_name.Focus();
            }
            else if (!cls_v.HasArabicCharacters(txt_name.Text))
            {
                MessageBox.Show("اسم الموظف يجب ان يكون حروف عربية فقط");
                txt_name.Focus();
            }

        }

        private void txt_cardReleasePlace_Leave(object sender, EventArgs e)
        {
            if (!cls_v.letterValidation(txt_cardReleasePlace.Text))
            {
                MessageBox.Show("جهه اصدار البطاقة يجب ان تكون حروف فقط");
                txt_cardReleasePlace.Focus();
            }
        }

        private void txt_birthPlace_Leave(object sender, EventArgs e)
        {
            if (!cls_v.letterValidation(txt_birthPlace.Text))
            {

                MessageBox.Show("محل الميلاد يجب ان تكون حروف فقط");
                txt_birthPlace.Focus();
            }
        }
    }
}