using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace HIS
{
    public partial class frm_patient : Form
    {
        frm_visit ob = new frm_visit();
       
        public frm_patient()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }
        public frm_patient(frm_visit frm)
        {
            this.KeyPreview = true;
            InitializeComponent();
            ob = frm;
        }
        Connection con = new Connection();
        cls_patient pat;
        string pat_id;
        DataTable dt;
        DataView dv;
        ToolTip tt;
        int VisibleTime = 1000;  //in milliseconds
        private void frm_patient_Load(object sender, EventArgs e)
        {
            try
            {
              
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblDate.Text = DateTime.Now.ToShortDateString();
                lb_curent_user.Text = Main_Form.curnt_emp;

                pat = new cls_patient();
                dt = new DataTable();
                dt = pat.select_patient();
                dv = new DataView(dt);
                if (dt.Rows.Count > 0)
                {
                    pat_id = dt.Rows[dt.Rows.Count - 1][0].ToString();
                }
                else
                {
                    pat_id = "Pat_100";
                }
                dgv_patient.DataSource = dv;
                dgv_patient.Columns[0].HeaderText = "الكود";
                dgv_patient.Columns[1].HeaderText = "الاسم";
                dgv_patient.Columns[3].HeaderText = "الهاتف";
                dgv_patient.Columns[4].HeaderText = "الحالة الاجتماعية";
                dgv_patient.Columns[5].HeaderText = "السن";

                dgv_patient.Columns[2].Visible = false;
                dgv_patient.Columns[6].Visible = false;
                dgv_patient.Columns[7].Visible = false;
                dgv_patient.Columns[8].Visible = false;
                dgv_patient.Columns[9].Visible = false;
                dgv_patient.Columns[10].Visible = false;
                dgv_patient.Columns[11].Visible = false;
                dgv_patient.Columns[12].Visible = false;
                dgv_patient.Columns[13].Visible = false;
                dgv_patient.Columns[14].Visible = false;
                dgv_patient.Columns[15].Visible = false;
                dgv_patient.Columns[16].Visible = false;
                dgv_patient.Columns[17].Visible = false;
                dgv_patient.Columns[18].Visible = false;
                dgv_patient.Columns[19].Visible = false;
                dgv_patient.Columns[20].Visible = false;
                dgv_patient.Columns[21].Visible = false;
                if (dt.Rows.Count > 0)
                {

                    dgv_patient.DataSource = dv;
                }
                else
                { MessageBox.Show("لا يوجد مرضى مسجلين"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_Add_Patient frm = new frm_Add_Patient();
            frm.Text = "اضافة مريض جديد";
            frm.Name = "add_patient";
            frm.txt_PatCode.Text = cls_validate.increasekey(pat_id, 4);
            frm.ShowDialog();
            this.frm_patient_Load(sender, e);

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cls_patient p = new cls_patient();
                if (dgv_patient.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف المريض المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (
                            p.deletedata("delete", dgv_patient.CurrentRow.Cells[0].Value.ToString(),
                            "delete","", "delete","delete", "5", "delete", "delete", "delete", "delete",
                            "delete", "5", "delete", "delete", "delete", "delete", "delete", "delete", "delete",
                            "delete", "1/1/2016",dgv_patient.CurrentRow.Cells[21].Value.ToString()))                           
                        {
                            this.frm_patient_Load(sender, e);
                            MessageBox.Show("تم الحذف بنجاح ");
                        }
                        else
                        {
                            MessageBox.Show("لم يتم الحذف لان هذ المريض له زيارات الرجاء حذف الزيارات ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تم حذف جميع المرضى ", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            frm_Add_Patient frm = new frm_Add_Patient();
            frm.Text = "تعديل بيانات مريض";
            frm.Name = "update_Pat";
            frm.txt_PatCode.Text = dgv_patient.CurrentRow.Cells[0].Value.ToString();
            frm.txt_patientName.Text = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            frm.txt_resident_address.Text = dgv_patient.CurrentRow.Cells[2].Value.ToString();
            frm.txt_phone.Text = dgv_patient.CurrentRow.Cells[3].Value.ToString();
            frm.cmb_status.SelectedItem = dgv_patient.CurrentRow.Cells[4].Value.ToString();
            frm.Num_Age.Value =int.Parse( dgv_patient.CurrentRow.Cells[5].Value.ToString());

            frm.cmb_job.SelectedItem = dgv_patient.CurrentRow.Cells[6].Value.ToString();
            frm.cmb_Nationality.SelectedItem = dgv_patient.CurrentRow.Cells[7].Value.ToString();
            frm.txt_addressWorking.Text = dgv_patient.CurrentRow.Cells[8].Value.ToString();            
            frm.txt_identity.Text = dgv_patient.CurrentRow.Cells[9].Value.ToString();
            frm.txt_identity_state.Text = dgv_patient.CurrentRow.Cells[10].Value.ToString();
            frm.Nu_duration_year.Value = int.Parse(dgv_patient.CurrentRow.Cells[11].Value.ToString());
            frm.txt_husbandName.Text = dgv_patient.CurrentRow.Cells[12].Value.ToString();

            frm.txt_HusbandIdentity.Text = dgv_patient.CurrentRow.Cells[13].Value.ToString();           
            frm.txt_patient_Relative_name.Text = dgv_patient.CurrentRow.Cells[14].Value.ToString();
            frm.txt_patient_Relative_identity.Text = dgv_patient.CurrentRow.Cells[15].Value.ToString();
            frm.txt_patient_Relative_phone.Text = dgv_patient.CurrentRow.Cells[17].Value.ToString();
            frm.txt_patient_Relative_address.Text = dgv_patient.CurrentRow.Cells[18].Value.ToString();
            frm.cmb_patient_Relative_job.SelectedItem = dgv_patient.CurrentRow.Cells[19].Value.ToString();
            frm.cmb_patient_Relative_state.SelectedValue = dgv_patient.CurrentRow.Cells[16].Value.ToString();
            dt = con.selectt("select * from Patient_relarive ;");

            frm.cmb_patient_Relative_state.DataSource = dt;
            frm.cmb_patient_Relative_state.ValueMember = "id";
            frm.cmb_patient_Relative_state.DisplayMember = "name";
            frm.cmb_patient_Relative_state.SelectedValue = dgv_patient.CurrentRow.Cells[16].Value.ToString();
            frm.patient_relatve_state = dgv_patient.CurrentRow.Cells[16].Value.ToString();
            
            frm.ts_btn_clear.Visible = false;
            frm.ShowDialog();
            this.frm_patient_Load(sender, e);
        }

        private void txt_search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search.Text == "ادخل نص البحث")
            {
                txt_search.Clear();
                txt_search.ForeColor = Color.Black;
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
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "id like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_patient.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "Name like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_patient.DataSource = dv;
                    }
                    else if (rdb_phone.Checked)
                    {
                        dv.RowFilter = "phone like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_patient.DataSource = dv;
                    }
                }
                else
                {
                    dgv_patient.DataSource = dv;
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

        private void rdb_phone_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "ادخل نص البحث";
            dv.RowFilter = string.Empty;
        }

        private void frm_patient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_add_Click(sender, e);
            }

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdb_name.Checked)
            {
                
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
                {
                    // btnSearch.Enabled = false;
              
                     tt = new ToolTip();
                    tt.Show("اسم المريض " + " يجب ان يكون حروف فقط ", txt_search, 0, 0, VisibleTime);
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
                else
                {
                  
                }
            }
        }

        private void rdb_id_CheckedChanged(object sender, EventArgs e)
        {
          //  txt_search.Focus();
        }

        private void rdb_phone_Click(object sender, EventArgs e)
        {
            txt_search.Focus();
        }

        private void dgv_patient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Add_Patient frm = new frm_Add_Patient();
            frm.txt_PatCode.Text = dgv_patient.CurrentRow.Cells[0].Value.ToString();
            frm.txt_patientName.Text = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            frm.txt_resident_address.Text = dgv_patient.CurrentRow.Cells[2].Value.ToString();
            frm.txt_phone.Text = dgv_patient.CurrentRow.Cells[3].Value.ToString();
            frm.cmb_status.SelectedItem = dgv_patient.CurrentRow.Cells[4].Value.ToString();
            frm.Num_Age.Value = int.Parse(dgv_patient.CurrentRow.Cells[5].Value.ToString());
            frm.cmb_job.SelectedItem = dgv_patient.CurrentRow.Cells[6].Value.ToString();
            frm.cmb_Nationality.SelectedItem = dgv_patient.CurrentRow.Cells[7].Value.ToString();
            frm.txt_addressWorking.Text = dgv_patient.CurrentRow.Cells[8].Value.ToString();
            frm.txt_identity.Text = dgv_patient.CurrentRow.Cells[9].Value.ToString();
            frm.txt_identity_state.Text = dgv_patient.CurrentRow.Cells[10].Value.ToString();
            frm.Nu_duration_year.Value = int.Parse(dgv_patient.CurrentRow.Cells[11].Value.ToString());
            frm.txt_husbandName.Text = dgv_patient.CurrentRow.Cells[12].Value.ToString();
            frm.txt_HusbandIdentity.Text = dgv_patient.CurrentRow.Cells[13].Value.ToString();
            frm.txt_patient_Relative_name.Text = dgv_patient.CurrentRow.Cells[14].Value.ToString();
            frm.txt_patient_Relative_identity.Text = dgv_patient.CurrentRow.Cells[15].Value.ToString();
            frm.txt_patient_Relative_phone.Text = dgv_patient.CurrentRow.Cells[17].Value.ToString();
            frm.txt_patient_Relative_address.Text = dgv_patient.CurrentRow.Cells[18].Value.ToString();
            frm.cmb_patient_Relative_job.SelectedItem = dgv_patient.CurrentRow.Cells[19].Value.ToString();
            frm.cmb_patient_Relative_state.SelectedValue = dgv_patient.CurrentRow.Cells[16].Value.ToString();
            dt = con.selectt("select * from Patient_relarive ");
            frm.cmb_patient_Relative_state.DataSource = dt;
            frm.cmb_patient_Relative_state.ValueMember = "id";
            frm.cmb_patient_Relative_state.DisplayMember = "name";
            frm.cmb_patient_Relative_state.SelectedValue = dgv_patient.CurrentRow.Cells[16].Value.ToString();
            frm.ts_btn_save.Visible = false;
            frm.ts_btn_clear.Visible = false;
            frm.panel2.Enabled = false;
            frm.panel3.Enabled = false;
           
            frm.ShowDialog();
            this.frm_patient_Load(sender, e);
        }
        public static string pat_cod;
        public static string pat_name;
        private void btn_accept_Click(object sender, EventArgs e)
        {
            string[] patData = new string[13];
            patData[0]=dgv_patient.CurrentRow.Cells[0].Value.ToString();
            patData[1] = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            patData[2] = dgv_patient.CurrentRow.Cells[2].Value.ToString();
            patData[3] = dgv_patient.CurrentRow.Cells[5].Value.ToString();
            patData[4] = dgv_patient.CurrentRow.Cells[6].Value.ToString();
            patData[5] = dgv_patient.CurrentRow.Cells[9].Value.ToString();
            patData[6] = dgv_patient.CurrentRow.Cells[12].Value.ToString();
            patData[7] = dgv_patient.CurrentRow.Cells[14].Value.ToString();
            patData[8] = dgv_patient.CurrentRow.Cells[15].Value.ToString();
           DataTable dtt=new DataTable();
            dtt=con.selectt("select name from Patient_relarive where id="+dgv_patient.CurrentRow.Cells[16].Value.ToString());          
            patData[9] =dtt.Rows[0][0].ToString();
            patData[10] = dgv_patient.CurrentRow.Cells[17].Value.ToString();
            patData[11] = dgv_patient.CurrentRow.Cells[18].Value.ToString();
            patData[12] = dgv_patient.CurrentRow.Cells[19].Value.ToString();
            ob.setData(patData);
            pat_cod = dgv_patient.CurrentRow.Cells[0].Value.ToString();
            pat_name = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
