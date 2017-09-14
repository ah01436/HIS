using System;
using System.Data;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_Add_Patient : Form
    {
        ToolTip tt;
        int VisibleTime = 1000;  //in milliseconds
        cls_validate cls_v = new cls_validate();
        Connection con = new Connection();
        public frm_Add_Patient()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        private void Add_Patient_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp;
            cmb_patient_Relative_state.SelectedItem = patient_relatve_state;
            DataTable dt = new DataTable();
            if (this.Name == "add_patient")
            {
                dt = con.selectt("select * from Patient_relarive;");
                cmb_patient_Relative_state.DataSource = dt;
                cmb_patient_Relative_state.ValueMember = "id";
                cmb_patient_Relative_state.DisplayMember = "name";
            }
           
            
        }

        public bool vaildate_text()
        {
            try
            {
                if (txt_patientName.Text == "")
                { MessageBox.Show("من فضلك ادخل اسم المريضة"); return false; }
                else if (Num_Age.Value == 1)
                {MessageBox.Show("من فضلك ادخل عمر المريضة"); return false;}
                else if (txt_resident_address.Text == "")
                {MessageBox.Show("من فضلك ادخل محل اقامة المريضة");return false;}
                else if (txt_patient_Relative_name.Text == "")
                {MessageBox.Show("من فضلك ادخل اسم شخص من اقارب المريضة ");return false;}
                else if (txt_patient_Relative_identity.Text == ""||!cls_v.IsValidNationalID(txt_patient_Relative_identity.Text))
                {MessageBox.Show("من فضلك ادخل الرقم القومى للشخص القريب للمريضة ");return false;}
                else if (txt_patient_Relative_phone.Text == "" || !cls_v.IsvalidPhone(txt_patient_Relative_phone.Text))
                { MessageBox.Show("من فضلك ادخل رقم الهاتف لقريب المريضة "); return false; }
                else if (txt_identity.Text != "")
                { 
                    if(!cls_v.IsValidNationalID(txt_identity.Text))
                    {
                    MessageBox.Show("من فضلك ادخل الرقم القومى للمريضة بشكل صحيح ");
                    
                    return false;}
                }
                else if (txt_HusbandIdentity.Text != "" || cls_v.IsValidNationalID(txt_HusbandIdentity.Text))

                { MessageBox.Show("من فضلك ادخل الرقم القومى لزوج المريضة بشكل صحيح "); return false; }
                else if (txt_phone.Text != "" || cls_v.IsvalidPhone(txt_phone.Text))

                { MessageBox.Show("من فضلك ادخل رقم هاتف المريضة بشكل صحيح "); return false; }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        
        private void empty_fields()
        {
            txt_patientName.Text="";
            txt_addressWorking.Text = "";
            txt_HusbandIdentity.Text = "";
            txt_husbandName.Text = "";
            txt_identity.Text = "";
            txt_resident_address.Text = "";
            txt_identity_state.Text = "";
            txt_patient_Relative_address.Text = "";
            txt_patient_Relative_identity.Text = "";
            txt_patient_Relative_name.Text = "";
            txt_patient_Relative_phone.Text = "";
            txt_phone.Text = "";
            Num_Age.ResetText();
            Nu_duration_year.ResetText();
            cmb_job.ResetText();
            cmb_Nationality.ResetText();
            cmb_patient_Relative_job.ResetText();
            cmb_patient_Relative_state.ResetText();
            cmb_status.ResetText();
        }
        public string patient_relatve_state;
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            string regis_date = DateTime.Now.Date.ToShortDateString();
            string user = Main_Form.curnt_user;
            cls_patient p = new cls_patient();
         
                try
                {  
                    if (vaildate_text())
                    {
                        if (this.Name == "add_patient")
                        {
                            if (p.insertdata("insert", txt_PatCode.Text, txt_patientName.Text, txt_resident_address.Text,
                                txt_phone.Text,cmb_status.SelectedItem.ToString(),Num_Age.Value.ToString(),
                                cmb_job.SelectedItem.ToString(), cmb_Nationality.SelectedItem.ToString(),  txt_addressWorking.Text,
                                txt_identity.Text, txt_identity_state.Text, Nu_duration_year.Value.ToString(), txt_husbandName.Text,
                                txt_HusbandIdentity.Text,txt_patient_Relative_name.Text,patient_relatve_state,
                                cmb_patient_Relative_job.SelectedItem.ToString(),
                                txt_patient_Relative_address.Text,txt_patient_Relative_identity.Text,
                                txt_patient_Relative_phone.Text,regis_date,user
                               ))
                            {
                                MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                             
                            }
                        }
                        else if (this.Name == "update_Pat")
                        {
                           if (p.updatedata("update", txt_PatCode.Text, txt_patientName.Text, txt_resident_address.Text,
                                txt_phone.Text, cmb_status.SelectedItem.ToString(), Num_Age.Value.ToString(),
                                cmb_job.SelectedItem.ToString(), cmb_Nationality.SelectedItem.ToString(), txt_addressWorking.Text,
                                txt_identity.Text, txt_identity_state.Text, Nu_duration_year.Value.ToString(), txt_husbandName.Text,
                                txt_HusbandIdentity.Text, txt_patient_Relative_name.Text, patient_relatve_state,
                                cmb_patient_Relative_job.SelectedItem.ToString(),
                                txt_patient_Relative_address.Text, txt_patient_Relative_identity.Text,
                                txt_patient_Relative_phone.Text, regis_date, user
                               ))
                            {
                                MessageBox.Show("تمت التعديل بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            empty_fields();
        }

        private void cmb_patient_Relative_state_SelectedIndexChanged(object sender, EventArgs e)
        {
           patient_relatve_state = cmb_patient_Relative_state.SelectedValue.ToString();            
        }

        //private void cmb_patient_Relative_state_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (cmb_patient_Relative_state.SelectedItem == "غير ذلك")
        //    {
        //        txt_other.Visible = true;
              
        //    }
        //}

        private void frm_Add_Patient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ts_btn_save_Click(sender, e);
            }

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_user; 
        }

        private void txt_patientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // btnSearch.Enabled = false;

                 tt = new ToolTip();
                tt.Show("اسم المريض " + " يجب ان يكون حروف فقط ", txt_patientName, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
                txt_patientName.Focus();
            }
           
        }

        private void txt_identity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                tt = new ToolTip();
                tt.Show("الرقم القومى " + " يجب ان يكون ارقام ", txt_identity, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
                //  ts_btn_save.Enabled = true;
            }
        }

        private void txt_identity_Leave(object sender, EventArgs e)
        {
            if (txt_identity.Text != "")
            {
                if (!cls_v.IsValidNationalID(txt_identity.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا الرقم القومى الذى ادخلته غير صحيح", txt_identity, 0, 0, VisibleTime);

                    txt_identity.Focus();
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

        private void txt_HusbandIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                tt = new ToolTip();
                tt.Show("الرقم القومى " + " يجب ان يكون ارقام ", txt_HusbandIdentity, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
                //  ts_btn_save.Enabled = true;
            }
        }

        private void txt_HusbandIdentity_Leave(object sender, EventArgs e)
        {
            if (txt_HusbandIdentity.Text != "")
            {
                if (!cls_v.IsValidNationalID(txt_HusbandIdentity.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا الرقم القومى الذى ادخلته غير صحيح", txt_HusbandIdentity, 0, 0, VisibleTime);

                    txt_HusbandIdentity.Focus();
                }
            }

        }

        private void txt_husbandName_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_husbandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // btnSearch.Enabled = false;

                tt = new ToolTip();
                tt.Show("اسم الزوج " + " يجب ان يكون حروف فقط ", txt_husbandName, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
                txt_husbandName.Focus();
            }
        }

        private void txt_patient_Relative_identity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                tt = new ToolTip();
                tt.Show("الرقم القومى " + " يجب ان يكون ارقام ", txt_patient_Relative_identity, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
                //  ts_btn_save.Enabled = true;
            }
        }

        private void txt_patient_Relative_identity_Leave(object sender, EventArgs e)
        {
            if (txt_patient_Relative_identity.Text != "")
            {
                if (!cls_v.IsValidNationalID(txt_patient_Relative_identity.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا الرقم القومى الذى ادخلته غير صحيح", txt_patient_Relative_identity, 0, 0, VisibleTime);

                    txt_patient_Relative_identity.Focus();
                }
            }
        }

        private void txt_patient_Relative_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                 tt = new ToolTip();
                tt.Show("رقم الهاتف " + " يجب ان يكون ارقام ", txt_patient_Relative_phone, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
            else
            {
                //  ts_btn_save.Enabled = true;
            }
        }

        private void txt_patient_Relative_phone_Leave(object sender, EventArgs e)
        {
            if (txt_patient_Relative_phone.Text != "")
            {
                if (!cls_v.IsvalidPhone(txt_patient_Relative_phone.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا رقم الهاتف الذى ادخلته غير صحيح", txt_patient_Relative_phone, 0, 0, VisibleTime);

                    txt_patient_Relative_phone.Focus();
                }
            }
        }

        private void txt_patient_Relative_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // btnSearch.Enabled = false;

                tt = new ToolTip();
                tt.Show("اسم القريب " + " يجب ان يكون حروف فقط ", txt_patient_Relative_name, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
                txt_patient_Relative_name.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Add_Patient_Relative frm = new frm_Add_Patient_Relative();
            frm.ShowDialog();
            DataTable dt = new DataTable();
            dt = con.selectt("select * from Patient_relarive");
            cmb_patient_Relative_state.DataSource = dt;
            cmb_patient_Relative_state.ValueMember = "id";
            cmb_patient_Relative_state.DisplayMember = "name";
        }

        private void txt_patientName_Leave(object sender, EventArgs e)
        {

            if (!cls_v.letterValidation(txt_patientName.Text))
            {
                MessageBox.Show("اسم المريضة يجب ان يكون حروف فقط");
                txt_patientName.Focus();
            }
            else if (!cls_v.HasArabicCharacters(txt_patientName.Text))
            {
                MessageBox.Show("اسم المريضة يجب ان يكون حروف عربية فقط");
                txt_patientName.Focus();
            }
        }

        private void txt_identity_state_Leave(object sender, EventArgs e)
        {
            if (!cls_v.letterValidation(txt_identity_state.Text))
            {
                MessageBox.Show("جهه اصدار البطاقة يجب ان يكون حروف فقط");
                txt_identity_state.Focus();
            }
        }

        private void txt_husbandName_Leave(object sender, EventArgs e)
        {
            if (txt_husbandName.Text != "")
            {
                if (!cls_v.letterValidation(txt_husbandName.Text))
                {
                    MessageBox.Show("اسم الزوج يجب ان يكون حروف فقط");
                    txt_husbandName.Focus();
                }
                else if (!cls_v.HasArabicCharacters(txt_husbandName.Text))
                {
                    MessageBox.Show("اسم الزوج يجب ان يكون حروف عربية فقط");
                    txt_husbandName.Focus();
                }
            }
        }

        private void txt_patient_Relative_name_Leave(object sender, EventArgs e)
        {
            if (!cls_v.letterValidation(txt_patient_Relative_name.Text))
            {
                MessageBox.Show("اسم قريب المريضة يجب ان يكون حروف فقط");
                txt_patient_Relative_name.Focus();
            }
            else if (!cls_v.HasArabicCharacters(txt_patient_Relative_name.Text))
            {
                MessageBox.Show("اسم الزوج يجب ان يكون حروف عربية فقط");
                txt_patient_Relative_name.Focus();
            }
        }

        private void txt_husbandName_TextChanged(object sender, EventArgs e)
        {

        }

       
        }

    }

