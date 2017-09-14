using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_patient : Form
    {
        public frm_patient()
        {
            InitializeComponent();
        }

        Patient pat;
        string pat_id;
        DataTable dt;
        DataView dv;
        // increase the genrate the id of new patient
        public string increasekey(string id)
        {
            string new_id = "P_";
            new_id += (Convert.ToInt64(id.Substring(2, id.Length - 2)) + 1).ToString();
            return new_id;
        }
        private void frm_patient_Load(object sender, EventArgs e)
        {
            pat = new Patient();
            dt = new DataTable();
            dt = pat.selct_patient();
            dv = new DataView(dt);
            if (dt.Rows.Count > 0)
            {
                pat_id = dt.Rows[dt.Rows.Count - 1][0].ToString();
            }
            else
            {
                pat_id = "P_100";
            }
            try
            {
                dgv_patient.DataSource = dv;
                dgv_patient.Columns[0].HeaderText = "الكود";
                dgv_patient.Columns[1].HeaderText = "الاسم";
                dgv_patient.Columns[2].HeaderText = "النوع";
                dgv_patient.Columns[8].HeaderText = "الهاتف";
                dgv_patient.Columns[9].HeaderText = "الهاتف2";
                dgv_patient.Columns[3].Visible = false;
                dgv_patient.Columns[4].Visible = false;
                dgv_patient.Columns[5].Visible = false;
                dgv_patient.Columns[6].Visible = false;
                dgv_patient.Columns[7].Visible = false;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add_patient frm = new frm_add_patient();
            frm.Text = "اضافة مريض جديد";
            frm.Name = "add_patient";
            frm.txt_id.Text = increasekey(pat_id);
            frm.ShowDialog();
            this.frm_patient_Load(sender,e);
            
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_patient.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف المريض المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (pat.delete_patient(dgv_patient.CurrentRow.Cells[0].Value.ToString()))
                        {
                            frm_patient_Load(sender, e);
                            MessageBox.Show("تم الحذف بنجاح ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تم حذف جميع المرضى ","انتبه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_add_patient frm = new frm_add_patient();
            frm.Text = "تعديل بيانات المريض";
            frm.Name = "update_patient";
            frm.txt_id.Text = dgv_patient.CurrentRow.Cells[0].Value.ToString();
            frm.txt_name.Text = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            if (dgv_patient.CurrentRow.Cells[2].Value.ToString()=="ذكر")
            {
                frm.rdb_male.Checked = true;
            }
            else
            {
                frm.rdb_female.Checked = true;
            }
            if (dgv_patient.CurrentRow.Cells[5].Value.ToString().Substring(0, 4) == "ارمل")
            {
                frm.rdb_armal.Checked = true;
            }
            else if (dgv_patient.CurrentRow.Cells[5].Value.ToString().Substring(0, 4) == "اعزب")
            {
                frm.rdb_single.Checked = true;
            }
            else if (dgv_patient.CurrentRow.Cells[5].Value.ToString().Substring(0, 5) == "متزوج")
            {

                frm.rdb_mairried.Checked = true;
            }
            else
            {
                frm.rdb_motalk.Checked = true;
            }
            frm.dtp_birth_date.Value = Convert.ToDateTime(dgv_patient.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show(dgv_patient.CurrentRow.Cells[4].Value.ToString());
            frm.dtb_reg_date.Value = Convert.ToDateTime(dgv_patient.CurrentRow.Cells[4].Value.ToString());
            frm.txt_address.Text = dgv_patient.CurrentRow.Cells[6].Value.ToString();
            frm.txt_phone1.Text = dgv_patient.CurrentRow.Cells[7].Value.ToString();
            frm.txt_phone2.Text = dgv_patient.CurrentRow.Cells[8].Value.ToString();
            frm.txt_email.Text = dgv_patient.CurrentRow.Cells[9].Value.ToString();
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
            if (txt_search.Text != "ادخل نص البحث")
            {
                if (rdb_id.Checked)
                {
                    dv.RowFilter = "patient_id like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                    dgv_patient.DataSource = dv;
                }
                else if (rdb_name.Checked)
                {
                    dv.RowFilter = "patient_name like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                    dgv_patient.DataSource = dv;
                }
                else if (rdb_phone.Checked)
                {
                    dv.RowFilter = "patient_contact_no like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                    dgv_patient.DataSource = dv;
                }
            }
            else
            {
                dgv_patient.DataSource = dv;
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
    }
}
