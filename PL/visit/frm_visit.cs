using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace HIS
{
    public partial class frm_visit : Form
    {
        string patCode;
        string docCode;

        DataTable dt;
        Connection con = new Connection();
        public frm_visit()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string regis_date = DateTime.Now.Date.ToShortDateString();
            string entry_time=DateTime.Now.ToShortTimeString();
           // string EmpUserCode = con.selectt("selcet id from users where user_name=" );
            
            cls_visit v = new cls_visit();

            try
            {
                if (vaildate_text())
                {
                    if (this.Name == "add_visit")
                    {                       
                        if (v.insertdata(txt_visit_id.Text, regis_date.ToString(), entry_time,
                            cb_initialDiagnosis.Text.ToString(),cmb_entities.Text.ToString(),
                            cb_visit_type.Text.ToString(), txt_docName.Text, Main_Form.curnt_user, patCode,txt_patientName.Text))
                           
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (this.Name == "update_Pat")
                    {
                        //if (v.updatedata("update", txt_PatCode.Text, txt_patientName.Text, txt_resident_address.Text,
                        //    txt_phone.Text, cmb_status.SelectedItem.ToString(), Num_Age.Value.ToString(),
                        //    cmb_job.SelectedItem.ToString(), cmb_Nationality.SelectedItem.ToString(), txt_addressWorking.Text,
                        //    txt_identity.Text, txt_identity_state.Text, Nu_duration_year.Value.ToString(), txt_husbandName.Text,
                        //    txt_HusbandIdentity.Text, txt_patient_Relative_name.Text, patient_relatve_state,
                        //    cmb_patient_Relative_job.SelectedItem.ToString(),
                        //    txt_patient_Relative_address.Text, txt_patient_Relative_identity.Text,
                        //    txt_patient_Relative_phone.Text, regis_date, user))
                           
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

        private void frm_visit_Load(object sender, EventArgs e)
        {
            txt_entry_time.Text = DateTime.Now.ToShortTimeString();
            txt_entry_date.Text = DateTime.Now.ToShortDateString();

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lb_curent_user.Text = Main_Form.curnt_emp; 
            if (this.Name == "add_visit")
            {
                dt = con.selectt("select  id,name from diagnosis");
                cb_initialDiagnosis.DataSource = dt;
                cb_initialDiagnosis.ValueMember = "id";
                cb_initialDiagnosis.DisplayMember = "name";

                dt = new DataTable();
                dt = con.selectt("select * from Entities");
                cmb_entities.DataSource = dt;
                cmb_entities.ValueMember = "Entities_id";
                cmb_entities.DisplayMember = "Entities_name";

                cb_visit_type.SelectedIndex = 0;
            }
        }
        public bool vaildate_text()
        {
            try
            {        //{
            //    if (txt_patientName.Text == "")
            //    { MessageBox.Show("من فضلك ادخل اسم المريضة"); return false; }
            //    else if (Num_Age.Value == 1)
            //    { MessageBox.Show("من فضلك ادخل عمر المريضة"); return false; }
            //    else if (txt_resident_address.Text == "")
            //    { MessageBox.Show("من فضلك ادخل محل اقامة المريضة"); return false; }
            //    else if (txt_patient_Relative_name.Text == "")
            //    { MessageBox.Show("من فضلك ادخل اسم شخص من اقارب المريضة "); return false; }
            //    else if (txt_patient_Relative_identity.Text == "")
            //    { MessageBox.Show("من فضلك ادخل الرقم القومى للشخص القريب للمريضة "); return false; }
                return true;
            }
    
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            frm_patient frm = new frm_patient(this);
            frm.btn_add.Visible = false;
            frm.btn_delete.Visible = false;
            frm.btn_edit.Visible = false;
            frm.btn_exit.Visible = false;
            frm.btn_accept.Visible = true;
            frm.ShowDialog();

        }
        public void setData(string[] patData)
        {
            patCode = patData[0];
            txt_patientName.Text = patData[1];
            txt_patientAddress.Text = patData[2];
            txt_PatientAge.Text=patData[3];
            txt_patientJob.Text = patData[4];
            txt_patientIdentity.Text = patData[5];
            txt_Husband_Name.Text = patData[6];
            txt_PatRelativeName.Text = patData[7];
            txt_PatRelativeidentity.Text = patData[8];
            txt_PatRelativestate.Text = patData[9];
            txt_PatRelativePhone.Text = patData[10];
            txt_PatRelativeaddress.Text = patData[11];
            txt_PatRelativejob.Text = patData[12];
        }
        public void setDoc(string code, string name)
        {
            txt_docName.Text = name;
            docCode = code;
        
        }
        private void txt_docSearch_Click(object sender, EventArgs e)
        {
            docSearch frm = new docSearch(this);
            frm.ShowDialog();
        }

        private void txt_DiagnosisSearch_Click(object sender, EventArgs e)
        {
            frm_diagnosis frm = new frm_diagnosis();
            frm.ShowDialog();
             dt = new DataTable();
            dt = con.selectt("select id,name from diagnosis");
            cb_initialDiagnosis.DataSource = dt;
            cb_initialDiagnosis.ValueMember = "id";
            cb_initialDiagnosis.DisplayMember = "name";
        }

        private void txt_organizationSearch_Click(object sender, EventArgs e)
        {
            frm_Entities frm = new frm_Entities();
            frm.ShowDialog();
            dt = new DataTable();
            dt = con.selectt("select * from Entities");
            cmb_entities.DataSource = dt;
            cmb_entities.ValueMember = "Entities_id";
            cmb_entities.DisplayMember = "Entities_name";
        }

        private void txt_patientName_TextChanged(object sender, EventArgs e)
        {
            if (txt_patientName.Text != "")
            {
                btn_edit.Enabled = true;
                string v_id = "";
                v_id = "v_" + patCode.Substring(4, patCode.Length - 4);
                v_id += "1";
                DataTable dtt = new DataTable();
                dtt = con.selectt("select * from visit where pat_id='" + patCode + "';");
                if (dtt.Rows.Count > 0)
                {
                    for (int i = 0; i < dtt.Rows.Count; i++)
                    {
                        v_id = cls_validate.increasekey(v_id, 2);
                    }
                }
                txt_visit_id.Text = v_id;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            DataTable dtt = new DataTable();
            dtt = con.selectt("select * from patient where id='" + patCode + "';");
            frm_Add_Patient frm = new frm_Add_Patient();
            frm.Text = "تعديل بيانات مريض";
            frm.Name = "update_Pat";
            frm.txt_PatCode.Text = dtt.Rows[0][0].ToString();
            frm.txt_patientName.Text = dtt.Rows[0][1].ToString();
            frm.txt_resident_address.Text = dtt.Rows[0][2].ToString();
            frm.txt_phone.Text = dtt.Rows[0][3].ToString();
            frm.cmb_status.SelectedItem = dtt.Rows[0][4].ToString();
            frm.Num_Age.Value = int.Parse(dtt.Rows[0][5].ToString());

            frm.cmb_job.SelectedItem = dtt.Rows[0][6].ToString();
            frm.cmb_Nationality.SelectedItem = dtt.Rows[0][7].ToString();
            frm.txt_addressWorking.Text = dtt.Rows[0][8].ToString();
            frm.txt_identity.Text = dtt.Rows[0][9].ToString();
            frm.txt_identity_state.Text = dtt.Rows[0][10].ToString();
            frm.Nu_duration_year.Value = int.Parse(dtt.Rows[0][11].ToString());
            frm.txt_husbandName.Text = dtt.Rows[0][12].ToString();

            frm.txt_HusbandIdentity.Text = dtt.Rows[0][13].ToString();
            frm.txt_patient_Relative_name.Text = dtt.Rows[0][14].ToString();
            frm.txt_patient_Relative_identity.Text = dtt.Rows[0][15].ToString();
            frm.txt_patient_Relative_phone.Text = dtt.Rows[0][17].ToString();
            frm.txt_patient_Relative_address.Text = dtt.Rows[0][18].ToString();
            frm.cmb_patient_Relative_job.SelectedItem = dtt.Rows[0][19].ToString();
            frm.cmb_patient_Relative_state.SelectedValue = dtt.Rows[0][16].ToString();
            dt = con.selectt("select * from Patient_relarive ");

            frm.cmb_patient_Relative_state.DataSource = dt;
            frm.cmb_patient_Relative_state.ValueMember = "id";
            frm.cmb_patient_Relative_state.DisplayMember = "name";
            frm.cmb_patient_Relative_state.SelectedValue = dtt.Rows[0][16].ToString();

            frm.ts_btn_clear.Visible = false;
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
        
    }
}
